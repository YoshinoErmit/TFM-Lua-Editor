using AutocompleteMenuNS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TFM_Lua_Editor.FastControl
{
    public class ToolItem
    {
        public static List<AutocompleteItem> Items = new List<AutocompleteMenuNS.AutocompleteItem>();
        static List<string> arr = new List<string>();
        static List<Tableau> Infos = new List<Tableau>();
        public static void ReadFile()
        {
            foreach (var line in File.ReadAllLines($"{Application.StartupPath}\\API.info"))
                arr.Add(line);

            foreach(var keys in arr)
            {
                string[] ar = keys.Split('|');
                Infos.Add(new Tableau() { Name = ar[0], ImageIndex = ar[1], Details = ar[2] });
            }
        }

        public static void BuildAutoCompleteMenu()
        {
            foreach (var item in Infos)
                Items.Add(new AutocompleteMenuNS.AutocompleteItem() { Text = item.Name, ImageIndex = Convert.ToInt32(item.ImageIndex), ToolTipText = item.Details, ToolTipTitle = item.Name });
        }
    }

    class Tableau
    {
        public string Name { get; set; }
        public string ImageIndex { get; set; }
        public string Details { get; set; }
        
    }
}
