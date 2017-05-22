namespace TFM_Lua_Editor.FastControl
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.lbl_color = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pb_color = new System.Windows.Forms.PictureBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_fontColor = new System.Windows.Forms.Label();
            this.pb_font = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_font)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(12, 22);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(197, 13);
            this.lbl_color.TabIndex = 0;
            this.lbl_color.Text = "Configurer la couleur de fond de l\'éditeur";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // pb_color
            // 
            this.pb_color.BackColor = System.Drawing.Color.White;
            this.pb_color.Location = new System.Drawing.Point(215, 12);
            this.pb_color.Name = "pb_color";
            this.pb_color.Size = new System.Drawing.Size(87, 34);
            this.pb_color.TabIndex = 1;
            this.pb_color.TabStop = false;
            this.pb_color.Click += new System.EventHandler(this.pb_color_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(227, 92);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Appliquer";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(146, 92);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_fontColor
            // 
            this.lbl_fontColor.AutoSize = true;
            this.lbl_fontColor.Location = new System.Drawing.Point(15, 58);
            this.lbl_fontColor.Name = "lbl_fontColor";
            this.lbl_fontColor.Size = new System.Drawing.Size(149, 13);
            this.lbl_fontColor.TabIndex = 4;
            this.lbl_fontColor.Text = "Couleur du texte dans l\'éditeur";
            // 
            // pb_font
            // 
            this.pb_font.BackColor = System.Drawing.Color.White;
            this.pb_font.Location = new System.Drawing.Point(215, 52);
            this.pb_font.Name = "pb_font";
            this.pb_font.Size = new System.Drawing.Size(87, 34);
            this.pb_font.TabIndex = 5;
            this.pb_font.TabStop = false;
            this.pb_font.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 120);
            this.Controls.Add(this.pb_font);
            this.Controls.Add(this.lbl_fontColor);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.pb_color);
            this.Controls.Add(this.lbl_color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_font)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pb_color;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_fontColor;
        private System.Windows.Forms.PictureBox pb_font;
    }
}