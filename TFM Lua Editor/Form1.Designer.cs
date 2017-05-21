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
            this.NouveautoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tFMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.tFMToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NouveautoolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // NouveautoolStripMenuItem
            // 
            this.NouveautoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NouveautoolStripMenuItem.Image")));
            this.NouveautoolStripMenuItem.Name = "NouveautoolStripMenuItem";
            this.NouveautoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NouveautoolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.NouveautoolStripMenuItem.Text = "Nouveau";
            this.NouveautoolStripMenuItem.Click += new System.EventHandler(this.NouveautoolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
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
            // tFMToolStripMenuItem
            // 
            this.tFMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPIToolStripMenuItem,
            this.forumToolStripMenuItem});
            this.tFMToolStripMenuItem.Name = "tFMToolStripMenuItem";
            this.tFMToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.tFMToolStripMenuItem.Text = "TFM";
            // 
            // aPIToolStripMenuItem
            // 
            this.aPIToolStripMenuItem.Name = "aPIToolStripMenuItem";
            this.aPIToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.aPIToolStripMenuItem.Text = "API";
            this.aPIToolStripMenuItem.Click += new System.EventHandler(this.aPIToolStripMenuItem_Click);
            // 
            // forumToolStripMenuItem
            // 
            this.forumToolStripMenuItem.Name = "forumToolStripMenuItem";
            this.forumToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.forumToolStripMenuItem.Text = "Forum";
            this.forumToolStripMenuItem.Click += new System.EventHandler(this.forumToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Fichiers Lua|*.lua";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Fichiers Lua|*.lua";
            // 
            // lua_editor
            // 
            this.lua_editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lua_editor.AutoScrollMinSize = new System.Drawing.Size(0, 14);
            this.lua_editor.BackBrush = null;
            this.lua_editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.lua_editor.CaretColor = System.Drawing.Color.White;
            this.lua_editor.CharHeight = 14;
            this.lua_editor.CharWidth = 8;
            this.lua_editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lua_editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lua_editor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.lua_editor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(218)))));
            this.lua_editor.IsReplaceMode = false;
            this.lua_editor.Location = new System.Drawing.Point(0, 24);
            this.lua_editor.Name = "lua_editor";
            this.lua_editor.Paddings = new System.Windows.Forms.Padding(0);
            this.lua_editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lua_editor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("lua_editor.ServiceColors")));
            this.lua_editor.Size = new System.Drawing.Size(875, 609);
            this.lua_editor.TabIndex = 1;
            this.lua_editor.WordWrap = true;
            this.lua_editor.Zoom = 100;
            this.lua_editor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.Box_TextChanged);
            // 
            // dm_lua
            // 
            this.dm_lua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dm_lua.ForeColor = System.Drawing.Color.Maroon;
            this.dm_lua.Location = new System.Drawing.Point(881, 24);
            this.dm_lua.Name = "dm_lua";
            this.dm_lua.Size = new System.Drawing.Size(220, 609);
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
            this.am_lua.Items = new string[] {
        "tfm.exec.giveCheese(playerName)",
        "tfm.exec.playerVictory (playerName)",
        "tfm.exec.movePlayer (playerName, xPosition, yPosition, offset, xSpeed, ySpeed, of" +
            "fset)",
        "tfm.exec.killPlayer (playerName)",
        "tfm.exec.respawnPlayer (playerName)",
        "tfm.exec.setVampirePlayer (playerName)",
        "tfm.exec.giveMeep (playerName)",
        "tfm.exec.setNameColor (playerName, color)",
        "tfm.exec.playEmote (playerName, emoteId, emoteParam)",
        "tfm.exec.addShamanObject (objectId, xPosition, yPosition, angle, xSpeed, ySpeed, " +
            "ghost)tfm.exec.moveObject (objectId, xPosition, yPosition, offset, xSpeed, ySpee" +
            "d, offset)",
        "tfm.exec.removeObject (objectId)",
        "tfm.exec.addConjuration (xPosition, yPosition, timeInMillis)",
        "tfm.exec.addJoint (id, ground1, ground2, definition)",
        "tfm.exec.removeJoint (id)",
        "tfm.exec.addPhysicObject (id, xPosition, yPosition, definition)",
        "tfm.exec.removePhysicObject (id)",
        "tfm.exec.explosion (xPosition, yPosition, power, distance, miceOnly)",
        "tfm.exec.snow (secondes, snowballPower)",
        "tfm.exec.displayParticle (particleId, xPosition, yPosition, xSpeed, ySpeed, xAcce" +
            "leration, yAcceleration, targetPlayer)",
        "tfm.exec.newGame (mapCode, mirrored)",
        "tfm.exec.setAutoMapFlipMode (yes)",
        "tfm.exec.disableAutoNewGame (yes)",
        "tfm.exec.setShaman (playerName)",
        "tfm.exec.disableAutoShaman (yes)",
        "tfm.exec.disableAllShamanSkills (yes)",
        "tfm.exec.setGameTime (seconds, init)",
        "tfm.exec.disableAutoTimeLeft (yes)",
        "tfm.exec.setPlayerScore (playerName, score, add)",
        "tfm.exec.disableAutoScore (yes)",
        "tfm.exec.disableAfkDeath (yes)",
        "tfm.exec.disableMortCommand (yes)",
        "tfm.exec.disableWatchCommand (yes)",
        "tfm.exec.disableDebugCommand (yes)",
        "tfm.exec.disableMinimalistMode (yes)",
        "tfm.exec.disablePhysicalConsumables (yes)",
        "system.disableChatCommandDisplay (command, yes)",
        "ui.addTextArea (id, text, targetPlayer, x, y, width, height, backgroundColor, bor" +
            "derColor, backgroundAlpha, fixedPos)",
        "ui.updateTextArea (id, text, targetPlayer)",
        "ui.removeTextArea (id, targetPlayer)",
        "ui.addPopup (id, type, text, targetPlayer, x, y, width, fixedPos)",
        "ui.showColorPicker (id, targetPlayer, defaultColor, title)",
        "ui.setShamanName (text)",
        "ui.setMapName (text)",
        "system.bindKeyboard (playerName, keyCode, down, yes)",
        "system.bindMouse (playerName, yes)",
        "print (something)",
        "system.exit ()",
        "debug.disableEventLog (yes)"};
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
            this.ClientSize = new System.Drawing.Size(1101, 633);
            this.Controls.Add(this.dm_lua);
            this.Controls.Add(this.lua_editor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TFM Lua Editor - untitled";
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
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tFMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NouveautoolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private FastControl.Box box_lua;
        private FastColoredTextBoxNS.FastColoredTextBox lua_editor;
        private FastColoredTextBoxNS.DocumentMap dm_lua;
        private AutocompleteMenuNS.AutocompleteMenu am_lua;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

