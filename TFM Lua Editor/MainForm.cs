using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFM_Lua_Editor.FastControl;

namespace TFM_Lua_Editor
{
    public partial class MainForm : Form
    {
        Form1 frm;
        public MainForm()
        {
            InitializeComponent();
        }

        #region Form
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.Args)
            {
                frm = new Form1($"{Path.GetFileName(Program.File)}", "");
                frm.MdiParent = this;

                frm.lua_editor.Text = File.ReadAllText(Program.File);
                ShowForm(frm);
            }
            else
            {
                frm = new Form1($"untitled", "");
                frm.MdiParent = this;

                ShowForm(frm);
            }

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackgroundImage = Properties.Resources.back_lua;
                    ctrl.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void ShowForm(Form childForm)
        {
            childForm.Show();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Refresh();
        }
        #endregion

        #region MenuStrip
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm = new Form1($"untitled", "");
            frm.MdiParent = this;
            frm.lua_editor.Text = "";
            ShowForm(frm);
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                frm = new Form1($"{openFileDialog1.SafeFileName}", openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.lua_editor.Text = File.ReadAllText(openFileDialog1.FileName);
                Program.File = "";
                ShowForm(frm);
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
