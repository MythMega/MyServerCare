﻿namespace MCServCare
{
    partial class ServerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerManager));
            this.btnUpdateServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnWorldCreation = new System.Windows.Forms.Button();
            this.btnWhitelist = new System.Windows.Forms.Button();
            this.btnWorldSelection = new System.Windows.Forms.Button();
            this.lvWorldSelection = new System.Windows.Forms.ListView();
            this.gbSystem = new System.Windows.Forms.GroupBox();
            this.btnDownloadServJar = new System.Windows.Forms.Button();
            this.gbWhitelist = new System.Windows.Forms.GroupBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.numSlotAmount = new System.Windows.Forms.NumericUpDown();
            this.lblGamemode = new System.Windows.Forms.Label();
            this.comboGamemode = new System.Windows.Forms.ComboBox();
            this.lblMaxPlayers = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.numRam = new System.Windows.Forms.NumericUpDown();
            this.gbMaps = new System.Windows.Forms.GroupBox();
            this.btnCreateBackup = new System.Windows.Forms.Button();
            this.gbCracks = new System.Windows.Forms.GroupBox();
            this.btnOpenToCrack = new System.Windows.Forms.Button();
            this.gbCommandBlock = new System.Windows.Forms.GroupBox();
            this.btnCommandBlockActive = new System.Windows.Forms.Button();
            this.gbPvp = new System.Windows.Forms.GroupBox();
            this.btnPVPActive = new System.Windows.Forms.Button();
            this.gbHardcore = new System.Windows.Forms.GroupBox();
            this.btnHardcoreActive = new System.Windows.Forms.Button();
            this.gbMOTD = new System.Windows.Forms.GroupBox();
            this.btnMOTD = new System.Windows.Forms.Button();
            this.txbMOTD = new System.Windows.Forms.TextBox();
            this.gbDistances = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblViewDistance = new System.Windows.Forms.Label();
            this.numSpawnProtecDistance = new System.Windows.Forms.NumericUpDown();
            this.numSimulationDistance = new System.Windows.Forms.NumericUpDown();
            this.numViewDistance = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.langueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.françaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anglaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allemandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espagnolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contributeursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnUpdateSC = new System.Windows.Forms.Button();
            this.gbEnd = new System.Windows.Forms.GroupBox();
            this.btnEndOff = new System.Windows.Forms.Button();
            this.btnNetherOff = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblNotif = new System.Windows.Forms.Label();
            this.timerItem = new System.Windows.Forms.Timer(this.components);
            this.bgNether = new System.Windows.Forms.GroupBox();
            this.lblCurrWorld = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSystem.SuspendLayout();
            this.gbWhitelist.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRam)).BeginInit();
            this.gbMaps.SuspendLayout();
            this.gbCracks.SuspendLayout();
            this.gbCommandBlock.SuspendLayout();
            this.gbPvp.SuspendLayout();
            this.gbHardcore.SuspendLayout();
            this.gbMOTD.SuspendLayout();
            this.gbDistances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpawnProtecDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulationDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDistance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEnd.SuspendLayout();
            this.bgNether.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateServer
            // 
            this.btnUpdateServer.Enabled = false;
            this.btnUpdateServer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateServer.FlatAppearance.BorderSize = 0;
            this.btnUpdateServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdateServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateServer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateServer.Location = new System.Drawing.Point(1, 54);
            this.btnUpdateServer.Name = "btnUpdateServer";
            this.btnUpdateServer.Size = new System.Drawing.Size(198, 23);
            this.btnUpdateServer.TabIndex = 0;
            this.btnUpdateServer.Text = "Mettre a jour Serveur";
            this.btnUpdateServer.UseVisualStyleBackColor = true;
            this.btnUpdateServer.Click += new System.EventHandler(this.btnUpdateServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartServer.FlatAppearance.BorderSize = 0;
            this.btnStartServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnStartServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.ForeColor = System.Drawing.Color.White;
            this.btnStartServer.Location = new System.Drawing.Point(1, 84);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(198, 23);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "Démarrer Serveur";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnWorldCreation
            // 
            this.btnWorldCreation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWorldCreation.FlatAppearance.BorderSize = 0;
            this.btnWorldCreation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnWorldCreation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnWorldCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorldCreation.ForeColor = System.Drawing.Color.White;
            this.btnWorldCreation.Location = new System.Drawing.Point(1, 16);
            this.btnWorldCreation.Name = "btnWorldCreation";
            this.btnWorldCreation.Size = new System.Drawing.Size(198, 48);
            this.btnWorldCreation.TabIndex = 2;
            this.btnWorldCreation.Text = "Ajouter un monde";
            this.btnWorldCreation.UseVisualStyleBackColor = true;
            this.btnWorldCreation.Click += new System.EventHandler(this.btnWorldCreation_Click);
            // 
            // btnWhitelist
            // 
            this.btnWhitelist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWhitelist.FlatAppearance.BorderSize = 0;
            this.btnWhitelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhitelist.ForeColor = System.Drawing.Color.White;
            this.btnWhitelist.Location = new System.Drawing.Point(1, 24);
            this.btnWhitelist.Name = "btnWhitelist";
            this.btnWhitelist.Size = new System.Drawing.Size(198, 23);
            this.btnWhitelist.TabIndex = 3;
            this.btnWhitelist.Tag = "ON";
            this.btnWhitelist.Text = "ON";
            this.btnWhitelist.UseVisualStyleBackColor = true;
            this.btnWhitelist.Click += new System.EventHandler(this.btnWhitelistActive_Click);
            // 
            // btnWorldSelection
            // 
            this.btnWorldSelection.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWorldSelection.FlatAppearance.BorderSize = 0;
            this.btnWorldSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnWorldSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnWorldSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorldSelection.ForeColor = System.Drawing.Color.White;
            this.btnWorldSelection.Location = new System.Drawing.Point(1, 321);
            this.btnWorldSelection.Name = "btnWorldSelection";
            this.btnWorldSelection.Size = new System.Drawing.Size(198, 23);
            this.btnWorldSelection.TabIndex = 8;
            this.btnWorldSelection.Text = "Changer de monde";
            this.btnWorldSelection.UseVisualStyleBackColor = true;
            this.btnWorldSelection.Click += new System.EventHandler(this.btnWorldSelection_Click);
            // 
            // lvWorldSelection
            // 
            this.lvWorldSelection.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lvWorldSelection.ForeColor = System.Drawing.Color.White;
            this.lvWorldSelection.HideSelection = false;
            this.lvWorldSelection.Location = new System.Drawing.Point(6, 94);
            this.lvWorldSelection.Name = "lvWorldSelection";
            this.lvWorldSelection.Size = new System.Drawing.Size(188, 221);
            this.lvWorldSelection.TabIndex = 9;
            this.lvWorldSelection.UseCompatibleStateImageBehavior = false;
            this.lvWorldSelection.View = System.Windows.Forms.View.List;
            // 
            // gbSystem
            // 
            this.gbSystem.BackColor = System.Drawing.Color.Transparent;
            this.gbSystem.Controls.Add(this.btnDownloadServJar);
            this.gbSystem.Controls.Add(this.btnStartServer);
            this.gbSystem.Controls.Add(this.btnUpdateServer);
            this.gbSystem.ForeColor = System.Drawing.Color.Orange;
            this.gbSystem.Location = new System.Drawing.Point(10, 27);
            this.gbSystem.Name = "gbSystem";
            this.gbSystem.Size = new System.Drawing.Size(200, 129);
            this.gbSystem.TabIndex = 10;
            this.gbSystem.TabStop = false;
            this.gbSystem.Text = "Système";
            // 
            // btnDownloadServJar
            // 
            this.btnDownloadServJar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDownloadServJar.FlatAppearance.BorderSize = 0;
            this.btnDownloadServJar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnDownloadServJar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDownloadServJar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadServJar.ForeColor = System.Drawing.Color.White;
            this.btnDownloadServJar.Location = new System.Drawing.Point(1, 24);
            this.btnDownloadServJar.Name = "btnDownloadServJar";
            this.btnDownloadServJar.Size = new System.Drawing.Size(198, 23);
            this.btnDownloadServJar.TabIndex = 2;
            this.btnDownloadServJar.Text = "Télécharger serveur";
            this.btnDownloadServJar.UseVisualStyleBackColor = true;
            this.btnDownloadServJar.Click += new System.EventHandler(this.btnDownloadServJar_Click);
            // 
            // gbWhitelist
            // 
            this.gbWhitelist.BackColor = System.Drawing.Color.Transparent;
            this.gbWhitelist.Controls.Add(this.btnWhitelist);
            this.gbWhitelist.ForeColor = System.Drawing.Color.Orange;
            this.gbWhitelist.Location = new System.Drawing.Point(419, 150);
            this.gbWhitelist.Name = "gbWhitelist";
            this.gbWhitelist.Size = new System.Drawing.Size(200, 53);
            this.gbWhitelist.TabIndex = 11;
            this.gbWhitelist.TabStop = false;
            this.gbWhitelist.Text = "Whitelist";
            // 
            // gbSettings
            // 
            this.gbSettings.BackColor = System.Drawing.Color.Transparent;
            this.gbSettings.Controls.Add(this.numSlotAmount);
            this.gbSettings.Controls.Add(this.lblGamemode);
            this.gbSettings.Controls.Add(this.comboGamemode);
            this.gbSettings.Controls.Add(this.lblMaxPlayers);
            this.gbSettings.Controls.Add(this.lblRam);
            this.gbSettings.Controls.Add(this.numRam);
            this.gbSettings.ForeColor = System.Drawing.Color.Orange;
            this.gbSettings.Location = new System.Drawing.Point(10, 155);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(200, 170);
            this.gbSettings.TabIndex = 12;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Paramètres";
            // 
            // numSlotAmount
            // 
            this.numSlotAmount.BackColor = System.Drawing.SystemColors.MenuText;
            this.numSlotAmount.ForeColor = System.Drawing.Color.White;
            this.numSlotAmount.Location = new System.Drawing.Point(9, 89);
            this.numSlotAmount.Name = "numSlotAmount";
            this.numSlotAmount.Size = new System.Drawing.Size(185, 20);
            this.numSlotAmount.TabIndex = 19;
            this.numSlotAmount.ValueChanged += new System.EventHandler(this.numMaxPlayer_ValueChanged);
            // 
            // lblGamemode
            // 
            this.lblGamemode.AutoSize = true;
            this.lblGamemode.Location = new System.Drawing.Point(8, 125);
            this.lblGamemode.Name = "lblGamemode";
            this.lblGamemode.Size = new System.Drawing.Size(61, 13);
            this.lblGamemode.TabIndex = 12;
            this.lblGamemode.Text = "Gamemode";
            // 
            // comboGamemode
            // 
            this.comboGamemode.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboGamemode.ForeColor = System.Drawing.Color.White;
            this.comboGamemode.FormattingEnabled = true;
            this.comboGamemode.Items.AddRange(new object[] {
            "survival",
            "creative",
            "adventure",
            "spectator"});
            this.comboGamemode.Location = new System.Drawing.Point(10, 140);
            this.comboGamemode.Name = "comboGamemode";
            this.comboGamemode.Size = new System.Drawing.Size(185, 21);
            this.comboGamemode.TabIndex = 11;
            this.comboGamemode.SelectedIndexChanged += new System.EventHandler(this.comboGamemode_SelectedIndexChanged);
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.Location = new System.Drawing.Point(7, 74);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(63, 13);
            this.lblMaxPlayers.TabIndex = 10;
            this.lblMaxPlayers.Text = "Max players";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(7, 27);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(31, 13);
            this.lblRam.TabIndex = 9;
            this.lblRam.Text = "RAM";
            // 
            // numRam
            // 
            this.numRam.BackColor = System.Drawing.SystemColors.MenuText;
            this.numRam.ForeColor = System.Drawing.Color.White;
            this.numRam.Location = new System.Drawing.Point(9, 42);
            this.numRam.Name = "numRam";
            this.numRam.Size = new System.Drawing.Size(185, 20);
            this.numRam.TabIndex = 7;
            this.numRam.ValueChanged += new System.EventHandler(this.numRam_ValueChanged);
            // 
            // gbMaps
            // 
            this.gbMaps.BackColor = System.Drawing.Color.Transparent;
            this.gbMaps.Controls.Add(this.pictureBox1);
            this.gbMaps.Controls.Add(this.lblCurrWorld);
            this.gbMaps.Controls.Add(this.btnCreateBackup);
            this.gbMaps.Controls.Add(this.lvWorldSelection);
            this.gbMaps.Controls.Add(this.btnWorldSelection);
            this.gbMaps.Controls.Add(this.btnWorldCreation);
            this.gbMaps.ForeColor = System.Drawing.Color.Orange;
            this.gbMaps.Location = new System.Drawing.Point(215, 27);
            this.gbMaps.Name = "gbMaps";
            this.gbMaps.Size = new System.Drawing.Size(200, 384);
            this.gbMaps.TabIndex = 13;
            this.gbMaps.TabStop = false;
            this.gbMaps.Text = "Maps";
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateBackup.FlatAppearance.BorderSize = 0;
            this.btnCreateBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnCreateBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCreateBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBackup.ForeColor = System.Drawing.Color.White;
            this.btnCreateBackup.Location = new System.Drawing.Point(1, 351);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Size = new System.Drawing.Size(198, 23);
            this.btnCreateBackup.TabIndex = 10;
            this.btnCreateBackup.Text = "Backup";
            this.btnCreateBackup.UseVisualStyleBackColor = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // gbCracks
            // 
            this.gbCracks.BackColor = System.Drawing.Color.Transparent;
            this.gbCracks.Controls.Add(this.btnOpenToCrack);
            this.gbCracks.ForeColor = System.Drawing.Color.Orange;
            this.gbCracks.Location = new System.Drawing.Point(420, 466);
            this.gbCracks.Name = "gbCracks";
            this.gbCracks.Size = new System.Drawing.Size(200, 55);
            this.gbCracks.TabIndex = 14;
            this.gbCracks.TabStop = false;
            this.gbCracks.Text = "Only Premium";
            // 
            // btnOpenToCrack
            // 
            this.btnOpenToCrack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpenToCrack.FlatAppearance.BorderSize = 0;
            this.btnOpenToCrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenToCrack.ForeColor = System.Drawing.Color.White;
            this.btnOpenToCrack.Location = new System.Drawing.Point(1, 24);
            this.btnOpenToCrack.Name = "btnOpenToCrack";
            this.btnOpenToCrack.Size = new System.Drawing.Size(198, 23);
            this.btnOpenToCrack.TabIndex = 0;
            this.btnOpenToCrack.Text = "Ouvrir aux cracks";
            this.btnOpenToCrack.UseVisualStyleBackColor = true;
            this.btnOpenToCrack.Click += new System.EventHandler(this.btnOpenToCrack_Click);
            // 
            // gbCommandBlock
            // 
            this.gbCommandBlock.BackColor = System.Drawing.Color.Transparent;
            this.gbCommandBlock.Controls.Add(this.btnCommandBlockActive);
            this.gbCommandBlock.ForeColor = System.Drawing.Color.Orange;
            this.gbCommandBlock.Location = new System.Drawing.Point(419, 203);
            this.gbCommandBlock.Name = "gbCommandBlock";
            this.gbCommandBlock.Size = new System.Drawing.Size(200, 53);
            this.gbCommandBlock.TabIndex = 15;
            this.gbCommandBlock.TabStop = false;
            this.gbCommandBlock.Text = "CommandBlock";
            // 
            // btnCommandBlockActive
            // 
            this.btnCommandBlockActive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCommandBlockActive.FlatAppearance.BorderSize = 0;
            this.btnCommandBlockActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommandBlockActive.ForeColor = System.Drawing.Color.White;
            this.btnCommandBlockActive.Location = new System.Drawing.Point(1, 24);
            this.btnCommandBlockActive.Name = "btnCommandBlockActive";
            this.btnCommandBlockActive.Size = new System.Drawing.Size(198, 23);
            this.btnCommandBlockActive.TabIndex = 0;
            this.btnCommandBlockActive.Text = "ON";
            this.btnCommandBlockActive.UseVisualStyleBackColor = true;
            this.btnCommandBlockActive.Click += new System.EventHandler(this.btnCommandBlockActive_Click);
            // 
            // gbPvp
            // 
            this.gbPvp.BackColor = System.Drawing.Color.Transparent;
            this.gbPvp.Controls.Add(this.btnPVPActive);
            this.gbPvp.ForeColor = System.Drawing.Color.Orange;
            this.gbPvp.Location = new System.Drawing.Point(419, 256);
            this.gbPvp.Name = "gbPvp";
            this.gbPvp.Size = new System.Drawing.Size(200, 53);
            this.gbPvp.TabIndex = 16;
            this.gbPvp.TabStop = false;
            this.gbPvp.Text = "PvP";
            // 
            // btnPVPActive
            // 
            this.btnPVPActive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPVPActive.FlatAppearance.BorderSize = 0;
            this.btnPVPActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPVPActive.ForeColor = System.Drawing.Color.White;
            this.btnPVPActive.Location = new System.Drawing.Point(1, 24);
            this.btnPVPActive.Name = "btnPVPActive";
            this.btnPVPActive.Size = new System.Drawing.Size(198, 23);
            this.btnPVPActive.TabIndex = 0;
            this.btnPVPActive.Text = "ON";
            this.btnPVPActive.UseVisualStyleBackColor = true;
            this.btnPVPActive.Click += new System.EventHandler(this.btnPVPActive_Click);
            // 
            // gbHardcore
            // 
            this.gbHardcore.BackColor = System.Drawing.Color.Transparent;
            this.gbHardcore.Controls.Add(this.btnHardcoreActive);
            this.gbHardcore.ForeColor = System.Drawing.Color.Orange;
            this.gbHardcore.Location = new System.Drawing.Point(419, 309);
            this.gbHardcore.Name = "gbHardcore";
            this.gbHardcore.Size = new System.Drawing.Size(200, 51);
            this.gbHardcore.TabIndex = 17;
            this.gbHardcore.TabStop = false;
            this.gbHardcore.Text = "Hardcore";
            // 
            // btnHardcoreActive
            // 
            this.btnHardcoreActive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHardcoreActive.FlatAppearance.BorderSize = 0;
            this.btnHardcoreActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardcoreActive.ForeColor = System.Drawing.Color.White;
            this.btnHardcoreActive.Location = new System.Drawing.Point(1, 24);
            this.btnHardcoreActive.Name = "btnHardcoreActive";
            this.btnHardcoreActive.Size = new System.Drawing.Size(198, 23);
            this.btnHardcoreActive.TabIndex = 18;
            this.btnHardcoreActive.Text = "ON";
            this.btnHardcoreActive.UseVisualStyleBackColor = true;
            this.btnHardcoreActive.Click += new System.EventHandler(this.btnHardcoreActive_Click);
            // 
            // gbMOTD
            // 
            this.gbMOTD.BackColor = System.Drawing.Color.Transparent;
            this.gbMOTD.Controls.Add(this.btnMOTD);
            this.gbMOTD.Controls.Add(this.txbMOTD);
            this.gbMOTD.ForeColor = System.Drawing.Color.Orange;
            this.gbMOTD.Location = new System.Drawing.Point(215, 411);
            this.gbMOTD.Name = "gbMOTD";
            this.gbMOTD.Size = new System.Drawing.Size(200, 110);
            this.gbMOTD.TabIndex = 22;
            this.gbMOTD.TabStop = false;
            this.gbMOTD.Text = "MOTD";
            // 
            // btnMOTD
            // 
            this.btnMOTD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMOTD.FlatAppearance.BorderSize = 0;
            this.btnMOTD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnMOTD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnMOTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMOTD.ForeColor = System.Drawing.Color.White;
            this.btnMOTD.Location = new System.Drawing.Point(1, 78);
            this.btnMOTD.Name = "btnMOTD";
            this.btnMOTD.Size = new System.Drawing.Size(198, 23);
            this.btnMOTD.TabIndex = 1;
            this.btnMOTD.Text = "Changer MOTD";
            this.btnMOTD.UseVisualStyleBackColor = true;
            this.btnMOTD.Click += new System.EventHandler(this.btnMOTD_Click);
            // 
            // txbMOTD
            // 
            this.txbMOTD.BackColor = System.Drawing.SystemColors.MenuText;
            this.txbMOTD.ForeColor = System.Drawing.Color.White;
            this.txbMOTD.Location = new System.Drawing.Point(7, 20);
            this.txbMOTD.Multiline = true;
            this.txbMOTD.Name = "txbMOTD";
            this.txbMOTD.Size = new System.Drawing.Size(187, 47);
            this.txbMOTD.TabIndex = 0;
            // 
            // gbDistances
            // 
            this.gbDistances.BackColor = System.Drawing.Color.Transparent;
            this.gbDistances.Controls.Add(this.label3);
            this.gbDistances.Controls.Add(this.label2);
            this.gbDistances.Controls.Add(this.lblViewDistance);
            this.gbDistances.Controls.Add(this.numSpawnProtecDistance);
            this.gbDistances.Controls.Add(this.numSimulationDistance);
            this.gbDistances.Controls.Add(this.numViewDistance);
            this.gbDistances.ForeColor = System.Drawing.Color.Orange;
            this.gbDistances.Location = new System.Drawing.Point(10, 325);
            this.gbDistances.Name = "gbDistances";
            this.gbDistances.Size = new System.Drawing.Size(200, 170);
            this.gbDistances.TabIndex = 23;
            this.gbDistances.TabStop = false;
            this.gbDistances.Text = "Distances";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Spawn protection (blocs)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Simulation (chunk)";
            // 
            // lblViewDistance
            // 
            this.lblViewDistance.AutoSize = true;
            this.lblViewDistance.Location = new System.Drawing.Point(7, 27);
            this.lblViewDistance.Name = "lblViewDistance";
            this.lblViewDistance.Size = new System.Drawing.Size(64, 13);
            this.lblViewDistance.TabIndex = 24;
            this.lblViewDistance.Text = "vue (chunk)";
            // 
            // numSpawnProtecDistance
            // 
            this.numSpawnProtecDistance.BackColor = System.Drawing.SystemColors.MenuText;
            this.numSpawnProtecDistance.ForeColor = System.Drawing.Color.White;
            this.numSpawnProtecDistance.Location = new System.Drawing.Point(10, 140);
            this.numSpawnProtecDistance.Name = "numSpawnProtecDistance";
            this.numSpawnProtecDistance.Size = new System.Drawing.Size(185, 20);
            this.numSpawnProtecDistance.TabIndex = 23;
            this.numSpawnProtecDistance.ValueChanged += new System.EventHandler(this.numSpawnProtecDistance_ValueChanged);
            // 
            // numSimulationDistance
            // 
            this.numSimulationDistance.BackColor = System.Drawing.SystemColors.MenuText;
            this.numSimulationDistance.ForeColor = System.Drawing.Color.White;
            this.numSimulationDistance.Location = new System.Drawing.Point(9, 89);
            this.numSimulationDistance.Name = "numSimulationDistance";
            this.numSimulationDistance.Size = new System.Drawing.Size(185, 20);
            this.numSimulationDistance.TabIndex = 22;
            this.numSimulationDistance.ValueChanged += new System.EventHandler(this.numSimulationDistance_ValueChanged);
            // 
            // numViewDistance
            // 
            this.numViewDistance.BackColor = System.Drawing.SystemColors.MenuText;
            this.numViewDistance.ForeColor = System.Drawing.Color.White;
            this.numViewDistance.Location = new System.Drawing.Point(9, 42);
            this.numViewDistance.Name = "numViewDistance";
            this.numViewDistance.Size = new System.Drawing.Size(185, 20);
            this.numViewDistance.TabIndex = 21;
            this.numViewDistance.ValueChanged += new System.EventHandler(this.numViewDistance_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.langueToolStripMenuItem,
            this.infosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.rechargerToolStripMenuItem});
            this.fichierToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // rechargerToolStripMenuItem
            // 
            this.rechargerToolStripMenuItem.Name = "rechargerToolStripMenuItem";
            this.rechargerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rechargerToolStripMenuItem.Text = "Recharger";
            this.rechargerToolStripMenuItem.Click += new System.EventHandler(this.rechargerToolStripMenuItem_Click);
            // 
            // langueToolStripMenuItem
            // 
            this.langueToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.langueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.françaisToolStripMenuItem,
            this.anglaisToolStripMenuItem,
            this.allemandToolStripMenuItem,
            this.espagnolToolStripMenuItem});
            this.langueToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.langueToolStripMenuItem.Name = "langueToolStripMenuItem";
            this.langueToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.langueToolStripMenuItem.Text = "Langue";
            // 
            // françaisToolStripMenuItem
            // 
            this.françaisToolStripMenuItem.Name = "françaisToolStripMenuItem";
            this.françaisToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.françaisToolStripMenuItem.Text = "Français";
            this.françaisToolStripMenuItem.Click += new System.EventHandler(this.françaisToolStripMenuItem_Click);
            // 
            // anglaisToolStripMenuItem
            // 
            this.anglaisToolStripMenuItem.Name = "anglaisToolStripMenuItem";
            this.anglaisToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.anglaisToolStripMenuItem.Text = "Anglais";
            this.anglaisToolStripMenuItem.Click += new System.EventHandler(this.anglaisToolStripMenuItem_Click);
            // 
            // allemandToolStripMenuItem
            // 
            this.allemandToolStripMenuItem.Name = "allemandToolStripMenuItem";
            this.allemandToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.allemandToolStripMenuItem.Text = "Allemand";
            this.allemandToolStripMenuItem.Click += new System.EventHandler(this.allemandToolStripMenuItem_Click);
            // 
            // espagnolToolStripMenuItem
            // 
            this.espagnolToolStripMenuItem.Name = "espagnolToolStripMenuItem";
            this.espagnolToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.espagnolToolStripMenuItem.Text = "Espagnol";
            this.espagnolToolStripMenuItem.Click += new System.EventHandler(this.espagnolToolStripMenuItem_Click);
            // 
            // infosToolStripMenuItem
            // 
            this.infosToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.infosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.reposToolStripMenuItem,
            this.créateursToolStripMenuItem,
            this.contributeursToolStripMenuItem});
            this.infosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.infosToolStripMenuItem.Name = "infosToolStripMenuItem";
            this.infosToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.infosToolStripMenuItem.Text = "Infos";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // reposToolStripMenuItem
            // 
            this.reposToolStripMenuItem.Name = "reposToolStripMenuItem";
            this.reposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reposToolStripMenuItem.Text = "Repos";
            this.reposToolStripMenuItem.Click += new System.EventHandler(this.reposToolStripMenuItem_Click);
            // 
            // créateursToolStripMenuItem
            // 
            this.créateursToolStripMenuItem.Name = "créateursToolStripMenuItem";
            this.créateursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.créateursToolStripMenuItem.Text = "Créateurs";
            this.créateursToolStripMenuItem.Click += new System.EventHandler(this.créateursToolStripMenuItem_Click);
            // 
            // contributeursToolStripMenuItem
            // 
            this.contributeursToolStripMenuItem.Name = "contributeursToolStripMenuItem";
            this.contributeursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contributeursToolStripMenuItem.Text = "Contributeurs";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOpenFolder);
            this.groupBox1.Controls.Add(this.btnUpdateSC);
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(10, 521);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 80);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ServerCare";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOpenFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnOpenFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Location = new System.Drawing.Point(7, 50);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(592, 23);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnUpdateSC
            // 
            this.btnUpdateSC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateSC.FlatAppearance.BorderSize = 0;
            this.btnUpdateSC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdateSC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUpdateSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSC.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSC.Location = new System.Drawing.Point(7, 20);
            this.btnUpdateSC.Name = "btnUpdateSC";
            this.btnUpdateSC.Size = new System.Drawing.Size(592, 23);
            this.btnUpdateSC.TabIndex = 0;
            this.btnUpdateSC.Text = "Update .SC";
            this.btnUpdateSC.UseVisualStyleBackColor = true;
            this.btnUpdateSC.Click += new System.EventHandler(this.btnUpdateSC_Click);
            // 
            // gbEnd
            // 
            this.gbEnd.Controls.Add(this.btnEndOff);
            this.gbEnd.ForeColor = System.Drawing.Color.Orange;
            this.gbEnd.Location = new System.Drawing.Point(420, 413);
            this.gbEnd.Name = "gbEnd";
            this.gbEnd.Size = new System.Drawing.Size(200, 53);
            this.gbEnd.TabIndex = 26;
            this.gbEnd.TabStop = false;
            this.gbEnd.Text = "Dimension : The End";
            // 
            // btnEndOff
            // 
            this.btnEndOff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEndOff.FlatAppearance.BorderSize = 0;
            this.btnEndOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndOff.ForeColor = System.Drawing.Color.White;
            this.btnEndOff.Location = new System.Drawing.Point(1, 24);
            this.btnEndOff.Name = "btnEndOff";
            this.btnEndOff.Size = new System.Drawing.Size(198, 23);
            this.btnEndOff.TabIndex = 2;
            this.btnEndOff.Text = "The End OFF";
            this.btnEndOff.UseVisualStyleBackColor = true;
            // 
            // btnNetherOff
            // 
            this.btnNetherOff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNetherOff.FlatAppearance.BorderSize = 0;
            this.btnNetherOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetherOff.ForeColor = System.Drawing.Color.White;
            this.btnNetherOff.Location = new System.Drawing.Point(1, 24);
            this.btnNetherOff.Name = "btnNetherOff";
            this.btnNetherOff.Size = new System.Drawing.Size(198, 23);
            this.btnNetherOff.TabIndex = 0;
            this.btnNetherOff.Text = "Nether OFF";
            this.btnNetherOff.UseVisualStyleBackColor = true;
            this.btnNetherOff.Click += new System.EventHandler(this.btnNetherOff_Click);
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Location = new System.Drawing.Point(429, 36);
            this.lblNotif.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(0, 13);
            this.lblNotif.TabIndex = 27;
            this.lblNotif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerItem
            // 
            this.timerItem.Interval = 4000;
            this.timerItem.Tick += new System.EventHandler(this.TimerItem_Tick);
            // 
            // bgNether
            // 
            this.bgNether.Controls.Add(this.btnNetherOff);
            this.bgNether.ForeColor = System.Drawing.Color.Orange;
            this.bgNether.Location = new System.Drawing.Point(420, 360);
            this.bgNether.Name = "bgNether";
            this.bgNether.Size = new System.Drawing.Size(200, 53);
            this.bgNether.TabIndex = 27;
            this.bgNether.TabStop = false;
            this.bgNether.Text = "Dimension : The Nether";
            // 
            // lblCurrWorld
            // 
            this.lblCurrWorld.AutoSize = true;
            this.lblCurrWorld.Location = new System.Drawing.Point(7, 71);
            this.lblCurrWorld.Name = "lblCurrWorld";
            this.lblCurrWorld.Size = new System.Drawing.Size(16, 13);
            this.lblCurrWorld.TabIndex = 11;
            this.lblCurrWorld.Text = "- -";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MCServCare.Properties.Resources.orangerefresh;
            this.pictureBox1.Location = new System.Drawing.Point(170, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.bgNether);
            this.Controls.Add(this.lblNotif);
            this.Controls.Add(this.gbEnd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDistances);
            this.Controls.Add(this.gbMOTD);
            this.Controls.Add(this.gbHardcore);
            this.Controls.Add(this.gbPvp);
            this.Controls.Add(this.gbCommandBlock);
            this.Controls.Add(this.gbCracks);
            this.Controls.Add(this.gbMaps);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbWhitelist);
            this.Controls.Add(this.gbSystem);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServerManager";
            this.Text = "ServerManager";
            this.Load += new System.EventHandler(this.ServerManager_Load);
            this.gbSystem.ResumeLayout(false);
            this.gbWhitelist.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRam)).EndInit();
            this.gbMaps.ResumeLayout(false);
            this.gbMaps.PerformLayout();
            this.gbCracks.ResumeLayout(false);
            this.gbCommandBlock.ResumeLayout(false);
            this.gbPvp.ResumeLayout(false);
            this.gbHardcore.ResumeLayout(false);
            this.gbMOTD.ResumeLayout(false);
            this.gbMOTD.PerformLayout();
            this.gbDistances.ResumeLayout(false);
            this.gbDistances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpawnProtecDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulationDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDistance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbEnd.ResumeLayout(false);
            this.bgNether.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnWorldCreation;
        private System.Windows.Forms.Button btnWhitelist;
        private System.Windows.Forms.Button btnWorldSelection;
        private System.Windows.Forms.ListView lvWorldSelection;
        private System.Windows.Forms.GroupBox gbSystem;
        private System.Windows.Forms.GroupBox gbWhitelist;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbMaps;
        private System.Windows.Forms.NumericUpDown numRam;
        private System.Windows.Forms.GroupBox gbCracks;
        private System.Windows.Forms.Button btnOpenToCrack;
        private System.Windows.Forms.GroupBox gbCommandBlock;
        private System.Windows.Forms.GroupBox gbPvp;
        private System.Windows.Forms.GroupBox gbHardcore;
        private System.Windows.Forms.Button btnPVPActive;
        private System.Windows.Forms.Button btnCommandBlockActive;
        private System.Windows.Forms.Button btnHardcoreActive;
        private System.Windows.Forms.NumericUpDown numSlotAmount;
        private System.Windows.Forms.GroupBox gbMOTD;
        private System.Windows.Forms.GroupBox gbDistances;
        private System.Windows.Forms.NumericUpDown numSimulationDistance;
        private System.Windows.Forms.NumericUpDown numViewDistance;
        private System.Windows.Forms.Button btnMOTD;
        private System.Windows.Forms.TextBox txbMOTD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem langueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem françaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anglaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allemandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espagnolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créateursToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numSpawnProtecDistance;
        private System.Windows.Forms.ToolStripMenuItem rechargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contributeursToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateBackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnUpdateSC;
        private System.Windows.Forms.GroupBox gbEnd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEndOff;
        private System.Windows.Forms.Button btnNetherOff;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblMaxPlayers;
        private System.Windows.Forms.Label lblGamemode;
        private System.Windows.Forms.ComboBox comboGamemode;
        private System.Windows.Forms.Button btnDownloadServJar;
        private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblViewDistance;
        private System.Windows.Forms.Timer timerItem;
        private System.Windows.Forms.GroupBox bgNether;
        private System.Windows.Forms.Label lblCurrWorld;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

