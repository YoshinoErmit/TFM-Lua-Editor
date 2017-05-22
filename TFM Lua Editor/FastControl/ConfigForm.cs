using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFM_Lua_Editor.FastControl
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void pb_color_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pb_color.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_color.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pb_font.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_font.BackColor = colorDialog1.Color;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            pb_color.BackColor = (Color)new ColorConverter().ConvertFromString(Properties.Settings.Default.BackColor);
            pb_font.BackColor = (Color)new ColorConverter().ConvertFromString(Properties.Settings.Default.FontColor);
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackColor = $"#{pb_color.BackColor.R.ToString("X2")}{pb_color.BackColor.G.ToString("X2")}{pb_color.BackColor.B.ToString("X2")}";
            Properties.Settings.Default.FontColor = $"#{pb_font.BackColor.R.ToString("X2")}{pb_font.BackColor.G.ToString("X2")}{pb_font.BackColor.B.ToString("X2")}";
            Properties.Settings.Default.Save();
            Form1._MainForm.lua_editor.BackColor = pb_color.BackColor;
            this.Close();
        }
    }
}
