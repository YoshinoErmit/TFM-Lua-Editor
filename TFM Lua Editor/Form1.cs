using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using FastColoredTextBoxNS;
using TFM_Lua_Editor.FastControl;
using System.Collections.Generic;
using TFM_Lua_Editor.Language;
using AutocompleteMenuNS;

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
        ToolItem tool;
        #endregion

        public Form1(string name, string path)
        {
            InitializeComponent();
            _name = name;
            _path = path;
            tool = new ToolItem();
        }

        #region Editor
        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (lua_editor.Text != "")
            {
                tool.Text.Clear();
                List<string> newFuncs = new List<string>();
                foreach (var line in lua_editor.Lines)
                {
                    string pattern = @"function \w+-?\([(\w+-?)*(\W+-?)*]+-?\)";
                    foreach (Match m in Regex.Matches(line, pattern))
                    {
                        if (m.Success)//(line.Contains("function "))
                        {
                            string[] arr = line.Split(new[] { "function ", }, StringSplitOptions.RemoveEmptyEntries);
                            string[] sorting = arr[0].Split('(');
                            if (tool.Text.Exists(x => x.Contains(sorting[0])))
                            {//tool.Text.RemoveAt(tool.Text.FindIndex(x => x.Contains(sorting[0])));
                                tool.Text.Add(arr[0]);
                            }
                            else
                                tool.Text.Add(arr[0]);
                        }
                    }
                }
                tool.AddNewItem(this);
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

            tool.ReadFile();
            tool.BuildAutoCompleteMenu();
            am_lua.SetAutocompleteItems(tool.Items);

            lua_editor.Language = FastColoredTextBoxNS.Language.Lua;

            this.Text = _name;

            fichierToolStripMenuItem.Text = LanguageManager.GetText("FormFile");
            enregistrerToolStripMenuItem.Text = LanguageManager.GetText("FormSave");
            enregistrerSousToolStripMenuItem.Text = LanguageManager.GetText("FormSaveAs");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.Text.EndsWith("untitled"))
            {
                if (this.Text.EndsWith("*"))
                {
                    if (!(MessageBox.Show(string.Format(LanguageManager.GetText("WarningSave"), _name), LanguageManager.GetText("WarningTitle"), MessageBoxButtons.YesNo) == DialogResult.Yes))
                    {
                        this.OnClosed(null);
                    }
                    else
                    {
                        enregistrerToolStripMenuItem_Click(sender, new EventArgs());
                        this.OnClosed(null);
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
