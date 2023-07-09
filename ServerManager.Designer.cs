namespace MCServCare
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
            this.btnUpdateServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnWorldCreation = new System.Windows.Forms.Button();
            this.btnWhitelistActive = new System.Windows.Forms.Button();
            this.btnRam = new System.Windows.Forms.Button();
            this.btnWhitelistDesactive = new System.Windows.Forms.Button();
            this.btnWorldSelection = new System.Windows.Forms.Button();
            this.lvWorldSelection = new System.Windows.Forms.ListView();
            this.gbSystem = new System.Windows.Forms.GroupBox();
            this.gbWhitelist = new System.Windows.Forms.GroupBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.numRam = new System.Windows.Forms.NumericUpDown();
            this.gbMaps = new System.Windows.Forms.GroupBox();
            this.gbCracks = new System.Windows.Forms.GroupBox();
            this.btnCloseToCrack = new System.Windows.Forms.Button();
            this.btnOpenToCrack = new System.Windows.Forms.Button();
            this.gbCommandBlock = new System.Windows.Forms.GroupBox();
            this.btnCommandBlockDesactive = new System.Windows.Forms.Button();
            this.btnCommandBlockActive = new System.Windows.Forms.Button();
            this.gbPvp = new System.Windows.Forms.GroupBox();
            this.btnPVPDesactive = new System.Windows.Forms.Button();
            this.btnPVPActive = new System.Windows.Forms.Button();
            this.gbHardcore = new System.Windows.Forms.GroupBox();
            this.btnHardcoreActive = new System.Windows.Forms.Button();
            this.btnHardcoreDesactive = new System.Windows.Forms.Button();
            this.btnSlotAmount = new System.Windows.Forms.Button();
            this.btnSimulationDistance = new System.Windows.Forms.Button();
            this.btnViewDistance = new System.Windows.Forms.Button();
            this.gbSlot = new System.Windows.Forms.GroupBox();
            this.numSlotAmount = new System.Windows.Forms.NumericUpDown();
            this.gbMOTD = new System.Windows.Forms.GroupBox();
            this.btnMOTD = new System.Windows.Forms.Button();
            this.txbMOTD = new System.Windows.Forms.TextBox();
            this.gbDistances = new System.Windows.Forms.GroupBox();
            this.btnSpawnProtec = new System.Windows.Forms.Button();
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
            this.btnCreateBackup = new System.Windows.Forms.Button();
            this.gbSystem.SuspendLayout();
            this.gbWhitelist.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRam)).BeginInit();
            this.gbMaps.SuspendLayout();
            this.gbCracks.SuspendLayout();
            this.gbCommandBlock.SuspendLayout();
            this.gbPvp.SuspendLayout();
            this.gbHardcore.SuspendLayout();
            this.gbSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSlotAmount)).BeginInit();
            this.gbMOTD.SuspendLayout();
            this.gbDistances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpawnProtecDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulationDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDistance)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateServer
            // 
            this.btnUpdateServer.Location = new System.Drawing.Point(7, 30);
            this.btnUpdateServer.Name = "btnUpdateServer";
            this.btnUpdateServer.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateServer.TabIndex = 0;
            this.btnUpdateServer.Text = "Mettre a jour Serveur";
            this.btnUpdateServer.UseVisualStyleBackColor = true;
            this.btnUpdateServer.Click += new System.EventHandler(this.btnUpdateServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(6, 59);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(188, 23);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "Démarrer Serveur";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnWorldCreation
            // 
            this.btnWorldCreation.Location = new System.Drawing.Point(7, 29);
            this.btnWorldCreation.Name = "btnWorldCreation";
            this.btnWorldCreation.Size = new System.Drawing.Size(188, 48);
            this.btnWorldCreation.TabIndex = 2;
            this.btnWorldCreation.Text = "Ajouter un monde";
            this.btnWorldCreation.UseVisualStyleBackColor = true;
            this.btnWorldCreation.Click += new System.EventHandler(this.btnWorldCreation_Click);
            // 
            // btnWhitelistActive
            // 
            this.btnWhitelistActive.Location = new System.Drawing.Point(6, 30);
            this.btnWhitelistActive.Name = "btnWhitelistActive";
            this.btnWhitelistActive.Size = new System.Drawing.Size(177, 23);
            this.btnWhitelistActive.TabIndex = 3;
            this.btnWhitelistActive.Text = "Activer Whitelist";
            this.btnWhitelistActive.UseVisualStyleBackColor = true;
            this.btnWhitelistActive.Click += new System.EventHandler(this.btnWhitelistActive_Click);
            // 
            // btnRam
            // 
            this.btnRam.Location = new System.Drawing.Point(58, 31);
            this.btnRam.Name = "btnRam";
            this.btnRam.Size = new System.Drawing.Size(131, 23);
            this.btnRam.TabIndex = 4;
            this.btnRam.Text = "Changer RAM";
            this.btnRam.UseVisualStyleBackColor = true;
            this.btnRam.Click += new System.EventHandler(this.btnRam_Click);
            // 
            // btnWhitelistDesactive
            // 
            this.btnWhitelistDesactive.Location = new System.Drawing.Point(7, 59);
            this.btnWhitelistDesactive.Name = "btnWhitelistDesactive";
            this.btnWhitelistDesactive.Size = new System.Drawing.Size(176, 23);
            this.btnWhitelistDesactive.TabIndex = 7;
            this.btnWhitelistDesactive.Text = "Desactiver Whitelist";
            this.btnWhitelistDesactive.UseVisualStyleBackColor = true;
            this.btnWhitelistDesactive.Click += new System.EventHandler(this.btnWhitelistDesactive_Click);
            // 
            // btnWorldSelection
            // 
            this.btnWorldSelection.Location = new System.Drawing.Point(6, 304);
            this.btnWorldSelection.Name = "btnWorldSelection";
            this.btnWorldSelection.Size = new System.Drawing.Size(188, 23);
            this.btnWorldSelection.TabIndex = 8;
            this.btnWorldSelection.Text = "Changer de monde";
            this.btnWorldSelection.UseVisualStyleBackColor = true;
            this.btnWorldSelection.Click += new System.EventHandler(this.btnWorldSelection_Click);
            // 
            // lvWorldSelection
            // 
            this.lvWorldSelection.HideSelection = false;
            this.lvWorldSelection.Location = new System.Drawing.Point(6, 84);
            this.lvWorldSelection.Name = "lvWorldSelection";
            this.lvWorldSelection.Size = new System.Drawing.Size(188, 214);
            this.lvWorldSelection.TabIndex = 9;
            this.lvWorldSelection.UseCompatibleStateImageBehavior = false;
            this.lvWorldSelection.View = System.Windows.Forms.View.List;
            // 
            // gbSystem
            // 
            this.gbSystem.Controls.Add(this.btnStartServer);
            this.gbSystem.Controls.Add(this.btnUpdateServer);
            this.gbSystem.Location = new System.Drawing.Point(10, 27);
            this.gbSystem.Name = "gbSystem";
            this.gbSystem.Size = new System.Drawing.Size(200, 100);
            this.gbSystem.TabIndex = 10;
            this.gbSystem.TabStop = false;
            this.gbSystem.Text = "Système";
            // 
            // gbWhitelist
            // 
            this.gbWhitelist.Controls.Add(this.btnWhitelistDesactive);
            this.gbWhitelist.Controls.Add(this.btnWhitelistActive);
            this.gbWhitelist.Location = new System.Drawing.Point(11, 311);
            this.gbWhitelist.Name = "gbWhitelist";
            this.gbWhitelist.Size = new System.Drawing.Size(200, 100);
            this.gbWhitelist.TabIndex = 11;
            this.gbWhitelist.TabStop = false;
            this.gbWhitelist.Text = "Whitelist";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.numRam);
            this.gbSettings.Controls.Add(this.btnRam);
            this.gbSettings.Location = new System.Drawing.Point(11, 133);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(200, 66);
            this.gbSettings.TabIndex = 12;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Paramètres";
            // 
            // numRam
            // 
            this.numRam.Location = new System.Drawing.Point(6, 31);
            this.numRam.Name = "numRam";
            this.numRam.Size = new System.Drawing.Size(45, 20);
            this.numRam.TabIndex = 7;
            // 
            // gbMaps
            // 
            this.gbMaps.Controls.Add(this.btnCreateBackup);
            this.gbMaps.Controls.Add(this.lvWorldSelection);
            this.gbMaps.Controls.Add(this.btnWorldSelection);
            this.gbMaps.Controls.Add(this.btnWorldCreation);
            this.gbMaps.Location = new System.Drawing.Point(217, 27);
            this.gbMaps.Name = "gbMaps";
            this.gbMaps.Size = new System.Drawing.Size(200, 367);
            this.gbMaps.TabIndex = 13;
            this.gbMaps.TabStop = false;
            this.gbMaps.Text = "Maps";
            // 
            // gbCracks
            // 
            this.gbCracks.Controls.Add(this.btnCloseToCrack);
            this.gbCracks.Controls.Add(this.btnOpenToCrack);
            this.gbCracks.Location = new System.Drawing.Point(11, 206);
            this.gbCracks.Name = "gbCracks";
            this.gbCracks.Size = new System.Drawing.Size(200, 100);
            this.gbCracks.TabIndex = 14;
            this.gbCracks.TabStop = false;
            this.gbCracks.Text = "Crack";
            // 
            // btnCloseToCrack
            // 
            this.btnCloseToCrack.Location = new System.Drawing.Point(6, 55);
            this.btnCloseToCrack.Name = "btnCloseToCrack";
            this.btnCloseToCrack.Size = new System.Drawing.Size(182, 23);
            this.btnCloseToCrack.TabIndex = 1;
            this.btnCloseToCrack.Text = "Fermer aux cracks";
            this.btnCloseToCrack.UseVisualStyleBackColor = true;
            this.btnCloseToCrack.Click += new System.EventHandler(this.btnCloseToCrack_Click);
            // 
            // btnOpenToCrack
            // 
            this.btnOpenToCrack.Location = new System.Drawing.Point(6, 25);
            this.btnOpenToCrack.Name = "btnOpenToCrack";
            this.btnOpenToCrack.Size = new System.Drawing.Size(182, 23);
            this.btnOpenToCrack.TabIndex = 0;
            this.btnOpenToCrack.Text = "Ouvrir aux cracks";
            this.btnOpenToCrack.UseVisualStyleBackColor = true;
            this.btnOpenToCrack.Click += new System.EventHandler(this.btnOpenToCrack_Click);
            // 
            // gbCommandBlock
            // 
            this.gbCommandBlock.Controls.Add(this.btnCommandBlockDesactive);
            this.gbCommandBlock.Controls.Add(this.btnCommandBlockActive);
            this.gbCommandBlock.Location = new System.Drawing.Point(11, 476);
            this.gbCommandBlock.Name = "gbCommandBlock";
            this.gbCommandBlock.Size = new System.Drawing.Size(200, 53);
            this.gbCommandBlock.TabIndex = 15;
            this.gbCommandBlock.TabStop = false;
            this.gbCommandBlock.Text = "CommandBlock";
            // 
            // btnCommandBlockDesactive
            // 
            this.btnCommandBlockDesactive.Location = new System.Drawing.Point(107, 19);
            this.btnCommandBlockDesactive.Name = "btnCommandBlockDesactive";
            this.btnCommandBlockDesactive.Size = new System.Drawing.Size(81, 23);
            this.btnCommandBlockDesactive.TabIndex = 1;
            this.btnCommandBlockDesactive.Text = "Désactiver";
            this.btnCommandBlockDesactive.UseVisualStyleBackColor = true;
            this.btnCommandBlockDesactive.Click += new System.EventHandler(this.btnCommandBlockDesactive_Click);
            // 
            // btnCommandBlockActive
            // 
            this.btnCommandBlockActive.Location = new System.Drawing.Point(6, 19);
            this.btnCommandBlockActive.Name = "btnCommandBlockActive";
            this.btnCommandBlockActive.Size = new System.Drawing.Size(84, 23);
            this.btnCommandBlockActive.TabIndex = 0;
            this.btnCommandBlockActive.Text = "Activé";
            this.btnCommandBlockActive.UseVisualStyleBackColor = true;
            this.btnCommandBlockActive.Click += new System.EventHandler(this.btnCommandBlockActive_Click);
            // 
            // gbPvp
            // 
            this.gbPvp.Controls.Add(this.btnPVPDesactive);
            this.gbPvp.Controls.Add(this.btnPVPActive);
            this.gbPvp.Location = new System.Drawing.Point(11, 417);
            this.gbPvp.Name = "gbPvp";
            this.gbPvp.Size = new System.Drawing.Size(200, 53);
            this.gbPvp.TabIndex = 16;
            this.gbPvp.TabStop = false;
            this.gbPvp.Text = "PvP";
            // 
            // btnPVPDesactive
            // 
            this.btnPVPDesactive.Location = new System.Drawing.Point(107, 20);
            this.btnPVPDesactive.Name = "btnPVPDesactive";
            this.btnPVPDesactive.Size = new System.Drawing.Size(81, 23);
            this.btnPVPDesactive.TabIndex = 0;
            this.btnPVPDesactive.Text = "Désactivé";
            this.btnPVPDesactive.UseVisualStyleBackColor = true;
            this.btnPVPDesactive.Click += new System.EventHandler(this.btnPVPDesactive_Click);
            // 
            // btnPVPActive
            // 
            this.btnPVPActive.Location = new System.Drawing.Point(7, 20);
            this.btnPVPActive.Name = "btnPVPActive";
            this.btnPVPActive.Size = new System.Drawing.Size(84, 23);
            this.btnPVPActive.TabIndex = 0;
            this.btnPVPActive.Text = "Activé";
            this.btnPVPActive.UseVisualStyleBackColor = true;
            this.btnPVPActive.Click += new System.EventHandler(this.btnPVPActive_Click);
            // 
            // gbHardcore
            // 
            this.gbHardcore.Controls.Add(this.btnHardcoreActive);
            this.gbHardcore.Controls.Add(this.btnHardcoreDesactive);
            this.gbHardcore.Location = new System.Drawing.Point(10, 535);
            this.gbHardcore.Name = "gbHardcore";
            this.gbHardcore.Size = new System.Drawing.Size(200, 51);
            this.gbHardcore.TabIndex = 17;
            this.gbHardcore.TabStop = false;
            this.gbHardcore.Text = "Hardcore";
            // 
            // btnHardcoreActive
            // 
            this.btnHardcoreActive.Location = new System.Drawing.Point(7, 19);
            this.btnHardcoreActive.Name = "btnHardcoreActive";
            this.btnHardcoreActive.Size = new System.Drawing.Size(84, 23);
            this.btnHardcoreActive.TabIndex = 18;
            this.btnHardcoreActive.Text = "Activé";
            this.btnHardcoreActive.UseVisualStyleBackColor = true;
            this.btnHardcoreActive.Click += new System.EventHandler(this.btnHardcoreActive_Click);
            // 
            // btnHardcoreDesactive
            // 
            this.btnHardcoreDesactive.Location = new System.Drawing.Point(108, 19);
            this.btnHardcoreDesactive.Name = "btnHardcoreDesactive";
            this.btnHardcoreDesactive.Size = new System.Drawing.Size(81, 23);
            this.btnHardcoreDesactive.TabIndex = 0;
            this.btnHardcoreDesactive.Text = "Désactivé";
            this.btnHardcoreDesactive.UseVisualStyleBackColor = true;
            this.btnHardcoreDesactive.Click += new System.EventHandler(this.btnHardcoreDesactive_Click);
            // 
            // btnSlotAmount
            // 
            this.btnSlotAmount.Location = new System.Drawing.Point(58, 19);
            this.btnSlotAmount.Name = "btnSlotAmount";
            this.btnSlotAmount.Size = new System.Drawing.Size(136, 23);
            this.btnSlotAmount.TabIndex = 18;
            this.btnSlotAmount.Text = "mettre à jour";
            this.btnSlotAmount.UseVisualStyleBackColor = true;
            this.btnSlotAmount.Click += new System.EventHandler(this.btnSlotAmount_Click);
            // 
            // btnSimulationDistance
            // 
            this.btnSimulationDistance.Location = new System.Drawing.Point(58, 59);
            this.btnSimulationDistance.Name = "btnSimulationDistance";
            this.btnSimulationDistance.Size = new System.Drawing.Size(136, 23);
            this.btnSimulationDistance.TabIndex = 19;
            this.btnSimulationDistance.Text = "Distance de Simulation";
            this.btnSimulationDistance.UseVisualStyleBackColor = true;
            this.btnSimulationDistance.Click += new System.EventHandler(this.btnSimulationDistance_Click);
            // 
            // btnViewDistance
            // 
            this.btnViewDistance.Location = new System.Drawing.Point(58, 30);
            this.btnViewDistance.Name = "btnViewDistance";
            this.btnViewDistance.Size = new System.Drawing.Size(136, 23);
            this.btnViewDistance.TabIndex = 20;
            this.btnViewDistance.Text = "Distance de vue";
            this.btnViewDistance.UseVisualStyleBackColor = true;
            this.btnViewDistance.Click += new System.EventHandler(this.btnViewDistance_Click);
            // 
            // gbSlot
            // 
            this.gbSlot.Controls.Add(this.numSlotAmount);
            this.gbSlot.Controls.Add(this.btnSlotAmount);
            this.gbSlot.Location = new System.Drawing.Point(11, 592);
            this.gbSlot.Name = "gbSlot";
            this.gbSlot.Size = new System.Drawing.Size(200, 52);
            this.gbSlot.TabIndex = 21;
            this.gbSlot.TabStop = false;
            this.gbSlot.Text = "Nombre de slot";
            // 
            // numSlotAmount
            // 
            this.numSlotAmount.Location = new System.Drawing.Point(7, 21);
            this.numSlotAmount.Name = "numSlotAmount";
            this.numSlotAmount.Size = new System.Drawing.Size(45, 20);
            this.numSlotAmount.TabIndex = 19;
            // 
            // gbMOTD
            // 
            this.gbMOTD.Controls.Add(this.btnMOTD);
            this.gbMOTD.Controls.Add(this.txbMOTD);
            this.gbMOTD.Location = new System.Drawing.Point(217, 534);
            this.gbMOTD.Name = "gbMOTD";
            this.gbMOTD.Size = new System.Drawing.Size(200, 110);
            this.gbMOTD.TabIndex = 22;
            this.gbMOTD.TabStop = false;
            this.gbMOTD.Text = "MOTD";
            // 
            // btnMOTD
            // 
            this.btnMOTD.Location = new System.Drawing.Point(7, 78);
            this.btnMOTD.Name = "btnMOTD";
            this.btnMOTD.Size = new System.Drawing.Size(187, 23);
            this.btnMOTD.TabIndex = 1;
            this.btnMOTD.Text = "Changer MOTD";
            this.btnMOTD.UseVisualStyleBackColor = true;
            this.btnMOTD.Click += new System.EventHandler(this.btnMOTD_Click);
            // 
            // txbMOTD
            // 
            this.txbMOTD.Location = new System.Drawing.Point(7, 20);
            this.txbMOTD.Multiline = true;
            this.txbMOTD.Name = "txbMOTD";
            this.txbMOTD.Size = new System.Drawing.Size(187, 47);
            this.txbMOTD.TabIndex = 0;
            // 
            // gbDistances
            // 
            this.gbDistances.Controls.Add(this.btnSpawnProtec);
            this.gbDistances.Controls.Add(this.numSpawnProtecDistance);
            this.gbDistances.Controls.Add(this.numSimulationDistance);
            this.gbDistances.Controls.Add(this.numViewDistance);
            this.gbDistances.Controls.Add(this.btnViewDistance);
            this.gbDistances.Controls.Add(this.btnSimulationDistance);
            this.gbDistances.Location = new System.Drawing.Point(217, 400);
            this.gbDistances.Name = "gbDistances";
            this.gbDistances.Size = new System.Drawing.Size(200, 129);
            this.gbDistances.TabIndex = 23;
            this.gbDistances.TabStop = false;
            this.gbDistances.Text = "Distances";
            // 
            // btnSpawnProtec
            // 
            this.btnSpawnProtec.Location = new System.Drawing.Point(59, 87);
            this.btnSpawnProtec.Name = "btnSpawnProtec";
            this.btnSpawnProtec.Size = new System.Drawing.Size(135, 23);
            this.btnSpawnProtec.TabIndex = 24;
            this.btnSpawnProtec.Text = "Distance Protec. Spawn";
            this.btnSpawnProtec.UseVisualStyleBackColor = true;
            // 
            // numSpawnProtecDistance
            // 
            this.numSpawnProtecDistance.Location = new System.Drawing.Point(6, 88);
            this.numSpawnProtecDistance.Name = "numSpawnProtecDistance";
            this.numSpawnProtecDistance.Size = new System.Drawing.Size(45, 20);
            this.numSpawnProtecDistance.TabIndex = 23;
            // 
            // numSimulationDistance
            // 
            this.numSimulationDistance.Location = new System.Drawing.Point(7, 60);
            this.numSimulationDistance.Name = "numSimulationDistance";
            this.numSimulationDistance.Size = new System.Drawing.Size(45, 20);
            this.numSimulationDistance.TabIndex = 22;
            // 
            // numViewDistance
            // 
            this.numViewDistance.Location = new System.Drawing.Point(6, 31);
            this.numViewDistance.Name = "numViewDistance";
            this.numViewDistance.Size = new System.Drawing.Size(46, 20);
            this.numViewDistance.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.langueToolStripMenuItem,
            this.infosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.rechargerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // rechargerToolStripMenuItem
            // 
            this.rechargerToolStripMenuItem.Name = "rechargerToolStripMenuItem";
            this.rechargerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rechargerToolStripMenuItem.Text = "Recharger";
            this.rechargerToolStripMenuItem.Click += new System.EventHandler(this.rechargerToolStripMenuItem_Click);
            // 
            // langueToolStripMenuItem
            // 
            this.langueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.françaisToolStripMenuItem,
            this.anglaisToolStripMenuItem,
            this.allemandToolStripMenuItem,
            this.espagnolToolStripMenuItem});
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
            this.infosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.changelogToolStripMenuItem,
            this.reposToolStripMenuItem,
            this.créateursToolStripMenuItem,
            this.contributeursToolStripMenuItem});
            this.infosToolStripMenuItem.Name = "infosToolStripMenuItem";
            this.infosToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.infosToolStripMenuItem.Text = "Infos";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // reposToolStripMenuItem
            // 
            this.reposToolStripMenuItem.Name = "reposToolStripMenuItem";
            this.reposToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.reposToolStripMenuItem.Text = "Repos";
            this.reposToolStripMenuItem.Click += new System.EventHandler(this.reposToolStripMenuItem_Click);
            // 
            // créateursToolStripMenuItem
            // 
            this.créateursToolStripMenuItem.Name = "créateursToolStripMenuItem";
            this.créateursToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.créateursToolStripMenuItem.Text = "Créateurs";
            this.créateursToolStripMenuItem.Click += new System.EventHandler(this.créateursToolStripMenuItem_Click);
            // 
            // contributeursToolStripMenuItem
            // 
            this.contributeursToolStripMenuItem.Name = "contributeursToolStripMenuItem";
            this.contributeursToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.contributeursToolStripMenuItem.Text = "Contributeurs";
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.Location = new System.Drawing.Point(6, 334);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Size = new System.Drawing.Size(188, 23);
            this.btnCreateBackup.TabIndex = 10;
            this.btnCreateBackup.Text = "Backup";
            this.btnCreateBackup.UseVisualStyleBackColor = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.btnCreateBackup_Click);
            // 
            // ServerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 645);
            this.Controls.Add(this.gbDistances);
            this.Controls.Add(this.gbMOTD);
            this.Controls.Add(this.gbSlot);
            this.Controls.Add(this.gbHardcore);
            this.Controls.Add(this.gbPvp);
            this.Controls.Add(this.gbCommandBlock);
            this.Controls.Add(this.gbCracks);
            this.Controls.Add(this.gbMaps);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbWhitelist);
            this.Controls.Add(this.gbSystem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServerManager";
            this.Text = "ServerManager";
            this.Load += new System.EventHandler(this.ServerManager_Load);
            this.gbSystem.ResumeLayout(false);
            this.gbWhitelist.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRam)).EndInit();
            this.gbMaps.ResumeLayout(false);
            this.gbCracks.ResumeLayout(false);
            this.gbCommandBlock.ResumeLayout(false);
            this.gbPvp.ResumeLayout(false);
            this.gbHardcore.ResumeLayout(false);
            this.gbSlot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSlotAmount)).EndInit();
            this.gbMOTD.ResumeLayout(false);
            this.gbMOTD.PerformLayout();
            this.gbDistances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSpawnProtecDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSimulationDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numViewDistance)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnWorldCreation;
        private System.Windows.Forms.Button btnWhitelistActive;
        private System.Windows.Forms.Button btnRam;
        private System.Windows.Forms.Button btnWhitelistDesactive;
        private System.Windows.Forms.Button btnWorldSelection;
        private System.Windows.Forms.ListView lvWorldSelection;
        private System.Windows.Forms.GroupBox gbSystem;
        private System.Windows.Forms.GroupBox gbWhitelist;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbMaps;
        private System.Windows.Forms.NumericUpDown numRam;
        private System.Windows.Forms.GroupBox gbCracks;
        private System.Windows.Forms.Button btnCloseToCrack;
        private System.Windows.Forms.Button btnOpenToCrack;
        private System.Windows.Forms.GroupBox gbCommandBlock;
        private System.Windows.Forms.GroupBox gbPvp;
        private System.Windows.Forms.GroupBox gbHardcore;
        private System.Windows.Forms.Button btnPVPDesactive;
        private System.Windows.Forms.Button btnPVPActive;
        private System.Windows.Forms.Button btnCommandBlockActive;
        private System.Windows.Forms.Button btnHardcoreActive;
        private System.Windows.Forms.Button btnCommandBlockDesactive;
        private System.Windows.Forms.Button btnHardcoreDesactive;
        private System.Windows.Forms.Button btnSlotAmount;
        private System.Windows.Forms.Button btnSimulationDistance;
        private System.Windows.Forms.Button btnViewDistance;
        private System.Windows.Forms.GroupBox gbSlot;
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
        private System.Windows.Forms.Button btnSpawnProtec;
        private System.Windows.Forms.NumericUpDown numSpawnProtecDistance;
        private System.Windows.Forms.ToolStripMenuItem rechargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contributeursToolStripMenuItem;
        private System.Windows.Forms.Button btnCreateBackup;
    }
}

