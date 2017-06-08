namespace Updater
{
    partial class UpdateForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.lbl_dl = new System.Windows.Forms.Label();
            this.pgbar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbl_ko = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pgbar_file = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbl_file = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dl
            // 
            this.lbl_dl.AutoSize = true;
            this.lbl_dl.ForeColor = System.Drawing.Color.Black;
            this.lbl_dl.Location = new System.Drawing.Point(116, 147);
            this.lbl_dl.Name = "lbl_dl";
            this.lbl_dl.Size = new System.Drawing.Size(186, 13);
            this.lbl_dl.TabIndex = 0;
            this.lbl_dl.Text = "Téléchargement du fichier : undefined";
            // 
            // pgbar
            // 
            this.pgbar.BackColor = System.Drawing.Color.Silver;
            this.pgbar.BorderRadius = 5;
            this.pgbar.Location = new System.Drawing.Point(12, 134);
            this.pgbar.MaximumValue = 100;
            this.pgbar.Name = "pgbar";
            this.pgbar.ProgressColor = System.Drawing.Color.Teal;
            this.pgbar.Size = new System.Drawing.Size(499, 10);
            this.pgbar.TabIndex = 1;
            this.pgbar.Value = 0;
            // 
            // lbl_ko
            // 
            this.lbl_ko.AutoSize = true;
            this.lbl_ko.Location = new System.Drawing.Point(368, 147);
            this.lbl_ko.Name = "lbl_ko";
            this.lbl_ko.Size = new System.Drawing.Size(48, 13);
            this.lbl_ko.TabIndex = 2;
            this.lbl_ko.Text = "0ko/0ko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Soopafresh", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "TFM Lua Editor Updater";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(215, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pgbar_file
            // 
            this.pgbar_file.BackColor = System.Drawing.Color.Silver;
            this.pgbar_file.BorderRadius = 5;
            this.pgbar_file.Location = new System.Drawing.Point(12, 118);
            this.pgbar_file.MaximumValue = 100;
            this.pgbar_file.Name = "pgbar_file";
            this.pgbar_file.ProgressColor = System.Drawing.Color.Teal;
            this.pgbar_file.Size = new System.Drawing.Size(499, 10);
            this.pgbar_file.TabIndex = 5;
            this.pgbar_file.Value = 0;
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Location = new System.Drawing.Point(212, 102);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(56, 13);
            this.lbl_file.TabIndex = 6;
            this.lbl_file.Text = "Fichier x/x";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 174);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.pgbar_file);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ko);
            this.Controls.Add(this.pgbar);
            this.Controls.Add(this.lbl_dl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.Text = "Updater";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dl;
        private Bunifu.Framework.UI.BunifuProgressBar pgbar;
        private System.Windows.Forms.Label lbl_ko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuProgressBar pgbar_file;
        private System.Windows.Forms.Label lbl_file;
    }
}

