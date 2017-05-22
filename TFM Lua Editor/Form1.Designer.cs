namespace TFM_Lua_Editor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lua_editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.dm_lua = new FastColoredTextBoxNS.DocumentMap();
            this.am_lua = new AutocompleteMenuNS.AutocompleteMenu();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.box_lua = new TFM_Lua_Editor.FastControl.Box();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lua_editor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_lua)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Fichiers Lua|*.lua";
            // 
            // lua_editor
            // 
            this.lua_editor.AutoCompleteBrackets = true;
            this.lua_editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.am_lua.SetAutocompleteMenu(this.lua_editor, this.am_lua);
            this.lua_editor.AutoIndentChars = false;
            this.lua_editor.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.lua_editor.BackBrush = null;
            this.lua_editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.lua_editor.CaretColor = System.Drawing.Color.White;
            this.lua_editor.CharHeight = 14;
            this.lua_editor.CharWidth = 8;
            this.lua_editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lua_editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lua_editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lua_editor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.lua_editor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(218)))));
            this.lua_editor.IsReplaceMode = false;
            this.lua_editor.Location = new System.Drawing.Point(0, 24);
            this.lua_editor.Name = "lua_editor";
            this.lua_editor.Paddings = new System.Windows.Forms.Padding(0);
            this.lua_editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lua_editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("lua_editor.ServiceColors")));
            this.lua_editor.Size = new System.Drawing.Size(808, 423);
            this.lua_editor.TabIndex = 1;
            this.lua_editor.WordWrap = true;
            this.lua_editor.Zoom = 100;
            this.lua_editor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.Box_TextChanged);
            // 
            // dm_lua
            // 
            this.dm_lua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.dm_lua.Dock = System.Windows.Forms.DockStyle.Right;
            this.dm_lua.ForeColor = System.Drawing.Color.Maroon;
            this.dm_lua.Location = new System.Drawing.Point(612, 24);
            this.dm_lua.Name = "dm_lua";
            this.dm_lua.Size = new System.Drawing.Size(196, 423);
            this.dm_lua.TabIndex = 2;
            this.dm_lua.Target = this.lua_editor;
            // 
            // am_lua
            // 
            this.am_lua.AllowsTabKey = true;
            this.am_lua.AppearInterval = 250;
            this.am_lua.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("am_lua.Colors")));
            this.am_lua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.am_lua.ImageList = this.imgList;
            this.am_lua.Items = new string[0];
            this.am_lua.TargetControlWrapper = null;
            this.am_lua.ToolTipDuration = 10000;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "Mouse.png");
            this.imgList.Images.SetKeyName(1, "Wind_master.png");
            this.imgList.Images.SetKeyName(2, "Grass.png");
            this.imgList.Images.SetKeyName(3, "300px-Heavy_ball_icon_(Transformice).png");
            this.imgList.Images.SetKeyName(4, "Under_maintenance.png");
            this.imgList.Images.SetKeyName(5, "Keyboard and Mouse Settings.png");
            this.imgList.Images.SetKeyName(6, "debug.png");
            this.imgList.Images.SetKeyName(7, "Speed.png");
            // 
            // box_lua
            // 
            this.box_lua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_lua.AutoCompleteBrackets = true;
            this.box_lua.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.am_lua.SetAutocompleteMenu(this.box_lua, null);
            this.box_lua.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.box_lua.BackBrush = null;
            this.box_lua.BackColor = System.Drawing.SystemColors.Control;
            this.box_lua.CharHeight = 14;
            this.box_lua.CharWidth = 8;
            this.box_lua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box_lua.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.box_lua.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.box_lua.IsReplaceMode = false;
            this.box_lua.Location = new System.Drawing.Point(0, 24);
            this.box_lua.Name = "box_lua";
            this.box_lua.Paddings = new System.Windows.Forms.Padding(0);
            this.box_lua.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.box_lua.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("box_lua.ServiceColors")));
            this.box_lua.Size = new System.Drawing.Size(1101, 609);
            this.box_lua.TabIndex = 1;
            this.box_lua.WordWrap = true;
            this.box_lua.Zoom = 100;
            this.box_lua.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.Box_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(36)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(808, 447);
            this.Controls.Add(this.dm_lua);
            this.Controls.Add(this.lua_editor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "untitled";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lua_editor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box_lua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private FastControl.Box box_lua;
        private FastColoredTextBoxNS.DocumentMap dm_lua;
        private System.Windows.Forms.ImageList imgList;
        public FastColoredTextBoxNS.FastColoredTextBox lua_editor;
        public AutocompleteMenuNS.AutocompleteMenu am_lua;
    }
}

