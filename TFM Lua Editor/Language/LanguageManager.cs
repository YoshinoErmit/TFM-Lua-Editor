using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFM_Lua_Editor.Language
{
    public class LanguageManager
    {
        public static LanguageEnum Language { get; set; }
        private static SQLiteConnection data;
        private static object lockObject;

        public static void Load()
        {
            data = new SQLiteConnection($"Data Source={Application.StartupPath + @"\Translation.db"}; Version=3");
            lockObject = new object();
        }

        public static string GetText(string key)
        {
            lock (lockObject)
            {
                string text;
                data.Open();
                using (SQLiteCommand cmd = data.CreateCommand())
                {
                    cmd.CommandText = string.Format("SELECT Value From {0} WHERE Key='{1}'", Language.ToString(), key);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                            text = "";
                        else
                        {
                            reader.Read();
                            text = reader[0].ToString();
                        }
                    }
                }
                data.Close();
                return text;
            }
        }

        public static void Translate(Control ctrl)
        {
            lock (lockObject)
            {
                string key, value, ctrlName, property;
                Component comp;

                data.Open();
                using (SQLiteCommand cmd = data.CreateCommand())
                {
                    cmd.CommandText = string.Format("SELECT * FROM {0} WHERE Key like '{1}.%'", Language.ToString(), ctrl.Name);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                key = reader[0].ToString();
                                string[] s = key.Split('.');
                                value = reader[1].ToString();

                                if (s.Length == 3)
                                {
                                    ctrlName = s[1];
                                    property = s[2];
                                    comp = FindControl(ctrl.Controls, ctrlName);
                                    if (comp != null)
                                        comp.GetType().GetProperty(property).SetValue(comp, value);
                                }
                                else if (s.Length == 2)
                                {
                                    property = s[1];
                                    ctrl.GetType().GetProperty(property).SetValue(ctrl, value);
                                }
                            }
                        }
                    }
                }
                data.Close();
            }
        }

        private static string GetNameForComponent(Component component)
        {
            if (component is ToolStripItem)
                return (component as ToolStripItem).Name;
            else if (component is Control)
                return (component as Control).Name;
            else
                return null;
        }

        private static Component FindControl(IEnumerable controlCollection, string name)
        {
            foreach (Component component in controlCollection)
            {
                if (GetNameForComponent(component) == name)
                    return component;

                IEnumerable childControlCollection = GetChildrenForComponent(component);

                if (childControlCollection != null)
                {
                    Component result = FindControl(childControlCollection, name);

                    if (result != null)
                        return result;
                }
            }

            return null;
        }

        private static IEnumerable GetChildrenForComponent(Component component)
        {
            if (component is ToolStrip)
                return (component as ToolStrip).Items;
            else if (component is ToolStripMenuItem)
                return (component as ToolStripMenuItem).DropDownItems;
            else if (component is Control && (component as Control).HasChildren)
                return (component as Control).Controls;
            else
                return null;
        }
    }

    public enum LanguageEnum
    {
        Français = 0,
        English = 1
    }
}
