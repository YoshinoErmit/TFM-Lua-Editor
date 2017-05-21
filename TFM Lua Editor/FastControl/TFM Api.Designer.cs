namespace TFM_Lua_Editor.FastControl
{
    partial class TFM_Api
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("exec");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("tfm", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("updateTextArea");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ui", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("system");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TFM_Api));
            this.tv_api = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tv_api
            // 
            this.tv_api.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.tv_api.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tv_api.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(218)))));
            this.tv_api.Location = new System.Drawing.Point(0, 52);
            this.tv_api.Name = "tv_api";
            treeNode1.Name = "node_exec";
            treeNode1.Text = "exec";
            treeNode2.Name = "node_tfm";
            treeNode2.Text = "tfm";
            treeNode3.Name = "node_updateTextArea";
            treeNode3.Text = "updateTextArea";
            treeNode4.Name = "node_ui";
            treeNode4.Text = "ui";
            treeNode5.Name = "node_system";
            treeNode5.Text = "system";
            this.tv_api.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode5});
            this.tv_api.Size = new System.Drawing.Size(566, 374);
            this.tv_api.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Soopafresh", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(119)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(115, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transformice API";
            // 
            // TFM_Api
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(566, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tv_api);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TFM_Api";
            this.Text = "TFM_Api";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_api;
        private System.Windows.Forms.Label label1;
    }
}