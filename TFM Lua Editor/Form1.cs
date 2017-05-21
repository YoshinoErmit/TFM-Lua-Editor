using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using FastColoredTextBoxNS;
using TFM_Lua_Editor.FastControl;

namespace TFM_Lua_Editor
{
    public partial class Form1 : Form
    {
        string FormName = "TFM Lua Editor";
        Style CommentStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
        Style KeywordStyle = new TextStyle(Brushes.Aqua, null, FontStyle.Bold);
        Style ArgStyle = new TextStyle(Brushes.Orange, null, FontStyle.Italic);
        Style StringStyle = new TextStyle(Brushes.OrangeRed, null, FontStyle.Regular);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Program.Args)
            {
                lua_editor.Text = File.ReadAllText(Program.File);
                this.Text = $"{FormName} - {Path.GetFileName(Program.File)}";
            }
            else
                this.Text = $"{FormName} - untitled";

            ToolItem.ReadFile();
            ToolItem.BuildAutoCompleteMenu();
            am_lua.SetAutocompleteItems(ToolItem.Items);

            lua_editor.Language = Language.Lua;
        }

        private void NouveautoolStripMenuItem_Click(object sender, EventArgs e)
        {
            lua_editor.Text = "";
            this.Text = $"{FormName} - untitled";
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lua_editor.Text = File.ReadAllText(openFileDialog1.FileName);
                this.Text = $"{FormName} - {openFileDialog1.SafeFileName}";
                Program.File = "";
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.Text != $"{FormName} - untitled*" && this.Text != $"{FormName} - untitled")
            {
                if (Program.File != "")
                    File.WriteAllText(Program.File, lua_editor.Text);
                else
                    File.WriteAllText(openFileDialog1.FileName, lua_editor.Text);
            }
            else
            {
                if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, lua_editor.Text);
                    this.Text = $"{FormName} - {saveFileDialog1.FileName}";
                    openFileDialog1.FileName = saveFileDialog1.FileName;
                }
            }
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, lua_editor.Text);
                this.Text = $"{FormName} - {saveFileDialog1.FileName}";
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.Text.EndsWith("untitled"))
                if (this.Text.EndsWith("*"))
                    if (MessageBox.Show("Êtes-vous sûr de vouloir femrer sans enregistrer ?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Process.GetCurrentProcess().Kill();
                    else
                        e.Cancel = true;
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
    }
}
