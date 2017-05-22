using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using FastColoredTextBoxNS;
using TFM_Lua_Editor.FastControl;
using System.Collections.Generic;

namespace TFM_Lua_Editor
{
    public partial class Form1 : Form
    {
        #region Fields
        Style CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        Style KeywordStyle = new TextStyle(Brushes.Aqua, null, FontStyle.Bold);
        Style ArgStyle = new TextStyle(Brushes.Orange, null, FontStyle.Italic);
        Style StringStyle = new TextStyle(Brushes.OrangeRed, null, FontStyle.Regular);
        string _name;
        string _path;
        public static Form1 _MainForm;
        #endregion

        public Form1(string name, string path)
        {
            InitializeComponent();
            _MainForm = this;
            _name = name;
            _path = path;
        }

        #region Editor
        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lua_editor.Text != "")
            {
                List<string> newFuncs = new List<string>();
                foreach (var line in lua_editor.Lines)
                {
                    string pattern = @"[^function ][\(][\w]+]*[\)$]";
                    foreach (Match m in Regex.Matches(line, pattern))
                    {
                        string[] arr = line.Split(new[] { "function ", }, StringSplitOptions.RemoveEmptyEntries);
                        string[] sorting = arr[0].Split('(');
                        if (line.Contains("function "))
                        {
                            if (ToolItem.Text.Exists(x => x.Contains(sorting[0])))
                            {
                                ToolItem.Text.RemoveAt(ToolItem.Text.FindIndex(x => x.Contains(sorting[0])));
                                ToolItem.Text.Add(arr[0]);
                            }
                            else
                                ToolItem.Text.Add(arr[0]);
                        }
                    }
                }
                ToolItem.AddNewItem();
            }

            if (!this.Text.EndsWith("*"))
                    this.Text = $"{this.Text}*";

            //Init the style
            e.ChangedRange.ClearStyle(CommentStyle);
            e.ChangedRange.ClearStyle(KeywordStyle);
            e.ChangedRange.ClearStyle(ArgStyle);
            e.ChangedRange.ClearStyle(StringStyle);
            //Set the style
            e.ChangedRange.SetStyle(CommentStyle, @"--.*$", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(KeywordStyle, @"\b(and|end|in|repeat|break|false|local|return|do|for|nil|then|else|function|not|true|elseif|if|or|untile|while)\b");
            e.ChangedRange.SetStyle(ArgStyle, @"\((.*?)[^\""]\)", RegexOptions.Multiline);
            e.ChangedRange.SetStyle(StringStyle, @"\""(.*?)\""");

            //Init folding marker
            e.ChangedRange.ClearFoldingMarkers();
            //Set the folding marker
            e.ChangedRange.SetFoldingMarkers(@"--region\b", @"--endregion\b");
        }
        #endregion

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            lua_editor.BackColor = (Color)new ColorConverter().ConvertFromString(Properties.Settings.Default.BackColor);
            lua_editor.ForeColor = (Color)new ColorConverter().ConvertFromString(Properties.Settings.Default.FontColor);

            ToolItem.ReadFile();
            ToolItem.BuildAutoCompleteMenu();
            am_lua.SetAutocompleteItems(ToolItem.Items);

            lua_editor.Language = Language.Lua;

            this.Text = _name;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.Text.EndsWith("untitled"))
            {
                if (this.Text.EndsWith("*"))
                {
                    if (MessageBox.Show("Voulez-vous enregistrer avant de quitter ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        enregistrerToolStripMenuItem_Click(sender, new EventArgs());
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                }
            }
        }
        #endregion

        #region MenuStrip
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Text != $"untitled*" && this.Text != $"untitled")
            {
                if (Program.File != "")
                    File.WriteAllText(Program.File, lua_editor.Text);
                else
                    File.WriteAllText(_path, lua_editor.Text);
            }
            else
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, lua_editor.Text);
                    this.Text = $"{saveFileDialog1.FileName}";
                    _path = saveFileDialog1.FileName;
                }
            }
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, lua_editor.Text);
                this.Text = $"{saveFileDialog1.FileName}";
                _path = saveFileDialog1.FileName;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Développer par Yoshino (Leshamane) - Copyright 2017");
        }

        private void aPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponible à la prochaine version.");
        }

        private void forumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://atelier801.com/");
        }

        private void apparencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog();
        }
        #endregion
    }
}
