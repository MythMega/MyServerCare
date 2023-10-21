namespace MCServCare
{
    partial class WorldCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldCreation));
            this.chbWorldAlreadyExist = new System.Windows.Forms.CheckBox();
            this.txbWorldName = new System.Windows.Forms.TextBox();
            this.lblWorldNameSettings = new System.Windows.Forms.Label();
            this.gbCreationEditWorld = new System.Windows.Forms.GroupBox();
            this.btnVerifNom = new System.Windows.Forms.Button();
            this.gbGenerationSettings = new System.Windows.Forms.GroupBox();
            this.btnRefreshWorldPresets = new System.Windows.Forms.Button();
            this.btnGenerationType = new System.Windows.Forms.Button();
            this.lvWorldPreset = new System.Windows.Forms.ListView();
            this.gbDatapackSettings = new System.Windows.Forms.GroupBox();
            this.btnRefreshDatapackList = new System.Windows.Forms.Button();
            this.btnValidateDatapackList = new System.Windows.Forms.Button();
            this.btnDatapackDB = new System.Windows.Forms.Button();
            this.lvDatapackList = new System.Windows.Forms.ListView();
            this.btnGenerateWorld = new System.Windows.Forms.Button();
            this.lblWorldName = new System.Windows.Forms.Label();
            this.lblWorldNameData = new System.Windows.Forms.Label();
            this.lblTypeGeneration = new System.Windows.Forms.Label();
            this.lblTypeGenerationData = new System.Windows.Forms.Label();
            this.lblDatapackList = new System.Windows.Forms.Label();
            this.lblDatapackListData = new System.Windows.Forms.Label();
            this.btnEditWorld = new System.Windows.Forms.Button();
            this.gbCreationEditWorld.SuspendLayout();
            this.gbGenerationSettings.SuspendLayout();
            this.gbDatapackSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbWorldAlreadyExist
            // 
            this.chbWorldAlreadyExist.AutoSize = true;
            this.chbWorldAlreadyExist.Location = new System.Drawing.Point(267, 29);
            this.chbWorldAlreadyExist.Name = "chbWorldAlreadyExist";
            this.chbWorldAlreadyExist.Size = new System.Drawing.Size(127, 17);
            this.chbWorldAlreadyExist.TabIndex = 0;
            this.chbWorldAlreadyExist.Text = "Ce monde existe déjà";
            this.chbWorldAlreadyExist.UseVisualStyleBackColor = true;
            this.chbWorldAlreadyExist.CheckedChanged += new System.EventHandler(this.chbWorldAlreadyExist_CheckedChanged);
            // 
            // txbWorldName
            // 
            this.txbWorldName.ForeColor = System.Drawing.Color.White;
            this.txbWorldName.Location = new System.Drawing.Point(96, 26);
            this.txbWorldName.Name = "txbWorldName";
            this.txbWorldName.Size = new System.Drawing.Size(158, 20);
            this.txbWorldName.TabIndex = 1;
            // 
            // lblWorldNameSettings
            // 
            this.lblWorldNameSettings.AutoSize = true;
            this.lblWorldNameSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblWorldNameSettings.ForeColor = System.Drawing.Color.White;
            this.lblWorldNameSettings.Location = new System.Drawing.Point(6, 29);
            this.lblWorldNameSettings.Name = "lblWorldNameSettings";
            this.lblWorldNameSettings.Size = new System.Drawing.Size(85, 13);
            this.lblWorldNameSettings.TabIndex = 2;
            this.lblWorldNameSettings.Text = "Nom du monde :";
            // 
            // gbCreationEditWorld
            // 
            this.gbCreationEditWorld.BackColor = System.Drawing.Color.Transparent;
            this.gbCreationEditWorld.Controls.Add(this.btnVerifNom);
            this.gbCreationEditWorld.Controls.Add(this.txbWorldName);
            this.gbCreationEditWorld.Controls.Add(this.lblWorldNameSettings);
            this.gbCreationEditWorld.Controls.Add(this.chbWorldAlreadyExist);
            this.gbCreationEditWorld.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbCreationEditWorld.Location = new System.Drawing.Point(12, 12);
            this.gbCreationEditWorld.Name = "gbCreationEditWorld";
            this.gbCreationEditWorld.Size = new System.Drawing.Size(423, 100);
            this.gbCreationEditWorld.TabIndex = 3;
            this.gbCreationEditWorld.TabStop = false;
            this.gbCreationEditWorld.Text = "Création/Ajout de monde";
            // 
            // btnVerifNom
            // 
            this.btnVerifNom.BackColor = System.Drawing.Color.Transparent;
            this.btnVerifNom.FlatAppearance.BorderSize = 0;
            this.btnVerifNom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnVerifNom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnVerifNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifNom.ForeColor = System.Drawing.Color.White;
            this.btnVerifNom.Location = new System.Drawing.Point(255, 61);
            this.btnVerifNom.Name = "btnVerifNom";
            this.btnVerifNom.Size = new System.Drawing.Size(113, 23);
            this.btnVerifNom.TabIndex = 3;
            this.btnVerifNom.Text = "Vérifier le nom";
            this.btnVerifNom.UseVisualStyleBackColor = false;
            this.btnVerifNom.Click += new System.EventHandler(this.btnVerifNom_Click);
            // 
            // gbGenerationSettings
            // 
            this.gbGenerationSettings.BackColor = System.Drawing.Color.Transparent;
            this.gbGenerationSettings.Controls.Add(this.btnRefreshWorldPresets);
            this.gbGenerationSettings.Controls.Add(this.btnGenerationType);
            this.gbGenerationSettings.Controls.Add(this.lvWorldPreset);
            this.gbGenerationSettings.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbGenerationSettings.Location = new System.Drawing.Point(12, 118);
            this.gbGenerationSettings.Name = "gbGenerationSettings";
            this.gbGenerationSettings.Size = new System.Drawing.Size(423, 132);
            this.gbGenerationSettings.TabIndex = 4;
            this.gbGenerationSettings.TabStop = false;
            this.gbGenerationSettings.Text = "Génération du monde";
            // 
            // btnRefreshWorldPresets
            // 
            this.btnRefreshWorldPresets.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshWorldPresets.FlatAppearance.BorderSize = 0;
            this.btnRefreshWorldPresets.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRefreshWorldPresets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnRefreshWorldPresets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshWorldPresets.ForeColor = System.Drawing.Color.White;
            this.btnRefreshWorldPresets.Location = new System.Drawing.Point(342, 45);
            this.btnRefreshWorldPresets.Name = "btnRefreshWorldPresets";
            this.btnRefreshWorldPresets.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshWorldPresets.TabIndex = 2;
            this.btnRefreshWorldPresets.Text = "Actualiser";
            this.btnRefreshWorldPresets.UseVisualStyleBackColor = false;
            // 
            // btnGenerationType
            // 
            this.btnGenerationType.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerationType.FlatAppearance.BorderSize = 0;
            this.btnGenerationType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGenerationType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnGenerationType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerationType.ForeColor = System.Drawing.Color.White;
            this.btnGenerationType.Location = new System.Drawing.Point(255, 74);
            this.btnGenerationType.Name = "btnGenerationType";
            this.btnGenerationType.Size = new System.Drawing.Size(162, 52);
            this.btnGenerationType.TabIndex = 1;
            this.btnGenerationType.Text = "Valider";
            this.btnGenerationType.UseVisualStyleBackColor = false;
            this.btnGenerationType.Click += new System.EventHandler(this.btnGenerationType_Click);
            // 
            // lvWorldPreset
            // 
            this.lvWorldPreset.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lvWorldPreset.HideSelection = false;
            this.lvWorldPreset.Location = new System.Drawing.Point(6, 19);
            this.lvWorldPreset.MultiSelect = false;
            this.lvWorldPreset.Name = "lvWorldPreset";
            this.lvWorldPreset.Size = new System.Drawing.Size(243, 107);
            this.lvWorldPreset.TabIndex = 0;
            this.lvWorldPreset.UseCompatibleStateImageBehavior = false;
            this.lvWorldPreset.View = System.Windows.Forms.View.List;
            // 
            // gbDatapackSettings
            // 
            this.gbDatapackSettings.BackColor = System.Drawing.Color.Transparent;
            this.gbDatapackSettings.Controls.Add(this.btnRefreshDatapackList);
            this.gbDatapackSettings.Controls.Add(this.btnValidateDatapackList);
            this.gbDatapackSettings.Controls.Add(this.btnDatapackDB);
            this.gbDatapackSettings.Controls.Add(this.lvDatapackList);
            this.gbDatapackSettings.ForeColor = System.Drawing.Color.Goldenrod;
            this.gbDatapackSettings.Location = new System.Drawing.Point(12, 256);
            this.gbDatapackSettings.Name = "gbDatapackSettings";
            this.gbDatapackSettings.Size = new System.Drawing.Size(423, 261);
            this.gbDatapackSettings.TabIndex = 5;
            this.gbDatapackSettings.TabStop = false;
            this.gbDatapackSettings.Text = "Insertion Datapacks";
            // 
            // btnRefreshDatapackList
            // 
            this.btnRefreshDatapackList.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshDatapackList.FlatAppearance.BorderSize = 0;
            this.btnRefreshDatapackList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRefreshDatapackList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnRefreshDatapackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDatapackList.ForeColor = System.Drawing.Color.White;
            this.btnRefreshDatapackList.Location = new System.Drawing.Point(342, 116);
            this.btnRefreshDatapackList.Name = "btnRefreshDatapackList";
            this.btnRefreshDatapackList.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDatapackList.TabIndex = 3;
            this.btnRefreshDatapackList.Text = "Actualiser";
            this.btnRefreshDatapackList.UseVisualStyleBackColor = false;
            // 
            // btnValidateDatapackList
            // 
            this.btnValidateDatapackList.BackColor = System.Drawing.Color.Transparent;
            this.btnValidateDatapackList.FlatAppearance.BorderSize = 0;
            this.btnValidateDatapackList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnValidateDatapackList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnValidateDatapackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateDatapackList.ForeColor = System.Drawing.Color.White;
            this.btnValidateDatapackList.Location = new System.Drawing.Point(255, 203);
            this.btnValidateDatapackList.Name = "btnValidateDatapackList";
            this.btnValidateDatapackList.Size = new System.Drawing.Size(162, 52);
            this.btnValidateDatapackList.TabIndex = 2;
            this.btnValidateDatapackList.Text = "Valider";
            this.btnValidateDatapackList.UseVisualStyleBackColor = false;
            this.btnValidateDatapackList.Visible = false;
            // 
            // btnDatapackDB
            // 
            this.btnDatapackDB.BackColor = System.Drawing.Color.Transparent;
            this.btnDatapackDB.FlatAppearance.BorderSize = 0;
            this.btnDatapackDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDatapackDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnDatapackDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatapackDB.ForeColor = System.Drawing.Color.White;
            this.btnDatapackDB.Location = new System.Drawing.Point(255, 145);
            this.btnDatapackDB.Name = "btnDatapackDB";
            this.btnDatapackDB.Size = new System.Drawing.Size(162, 52);
            this.btnDatapackDB.TabIndex = 1;
            this.btnDatapackDB.Text = "Banque de Datapack";
            this.btnDatapackDB.UseVisualStyleBackColor = false;
            this.btnDatapackDB.Visible = false;
            this.btnDatapackDB.Click += new System.EventHandler(this.btnDatapackDB_Click);
            // 
            // lvDatapackList
            // 
            this.lvDatapackList.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lvDatapackList.HideSelection = false;
            this.lvDatapackList.Location = new System.Drawing.Point(7, 20);
            this.lvDatapackList.Name = "lvDatapackList";
            this.lvDatapackList.Size = new System.Drawing.Size(242, 235);
            this.lvDatapackList.TabIndex = 0;
            this.lvDatapackList.UseCompatibleStateImageBehavior = false;
            this.lvDatapackList.View = System.Windows.Forms.View.List;
            this.lvDatapackList.SelectedIndexChanged += new System.EventHandler(this.lvDatapackList_SelectedIndexChanged);
            // 
            // btnGenerateWorld
            // 
            this.btnGenerateWorld.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateWorld.FlatAppearance.BorderSize = 0;
            this.btnGenerateWorld.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGenerateWorld.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnGenerateWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateWorld.ForeColor = System.Drawing.Color.White;
            this.btnGenerateWorld.Location = new System.Drawing.Point(12, 649);
            this.btnGenerateWorld.Name = "btnGenerateWorld";
            this.btnGenerateWorld.Size = new System.Drawing.Size(423, 23);
            this.btnGenerateWorld.TabIndex = 6;
            this.btnGenerateWorld.Text = "Génerer le monde";
            this.btnGenerateWorld.UseVisualStyleBackColor = false;
            this.btnGenerateWorld.Click += new System.EventHandler(this.btnGenerateWorld_Click);
            // 
            // lblWorldName
            // 
            this.lblWorldName.AutoSize = true;
            this.lblWorldName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorldName.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblWorldName.Location = new System.Drawing.Point(18, 520);
            this.lblWorldName.Name = "lblWorldName";
            this.lblWorldName.Size = new System.Drawing.Size(85, 13);
            this.lblWorldName.TabIndex = 7;
            this.lblWorldName.Text = "Nom du monde :";
            // 
            // lblWorldNameData
            // 
            this.lblWorldNameData.AutoSize = true;
            this.lblWorldNameData.BackColor = System.Drawing.Color.Transparent;
            this.lblWorldNameData.ForeColor = System.Drawing.Color.White;
            this.lblWorldNameData.Location = new System.Drawing.Point(137, 520);
            this.lblWorldNameData.Name = "lblWorldNameData";
            this.lblWorldNameData.Size = new System.Drawing.Size(13, 13);
            this.lblWorldNameData.TabIndex = 8;
            this.lblWorldNameData.Text = "()";
            // 
            // lblTypeGeneration
            // 
            this.lblTypeGeneration.AutoSize = true;
            this.lblTypeGeneration.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeGeneration.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTypeGeneration.Location = new System.Drawing.Point(18, 544);
            this.lblTypeGeneration.Name = "lblTypeGeneration";
            this.lblTypeGeneration.Size = new System.Drawing.Size(111, 13);
            this.lblTypeGeneration.TabIndex = 9;
            this.lblTypeGeneration.Text = "Preset de génération :";
            // 
            // lblTypeGenerationData
            // 
            this.lblTypeGenerationData.AutoSize = true;
            this.lblTypeGenerationData.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeGenerationData.ForeColor = System.Drawing.Color.White;
            this.lblTypeGenerationData.Location = new System.Drawing.Point(137, 544);
            this.lblTypeGenerationData.Name = "lblTypeGenerationData";
            this.lblTypeGenerationData.Size = new System.Drawing.Size(13, 13);
            this.lblTypeGenerationData.TabIndex = 10;
            this.lblTypeGenerationData.Text = "()";
            // 
            // lblDatapackList
            // 
            this.lblDatapackList.AutoSize = true;
            this.lblDatapackList.BackColor = System.Drawing.Color.Transparent;
            this.lblDatapackList.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDatapackList.Location = new System.Drawing.Point(18, 568);
            this.lblDatapackList.Name = "lblDatapackList";
            this.lblDatapackList.Size = new System.Drawing.Size(98, 13);
            this.lblDatapackList.TabIndex = 11;
            this.lblDatapackList.Text = "Liste de datapack :";
            // 
            // lblDatapackListData
            // 
            this.lblDatapackListData.AutoSize = true;
            this.lblDatapackListData.BackColor = System.Drawing.Color.Transparent;
            this.lblDatapackListData.ForeColor = System.Drawing.Color.White;
            this.lblDatapackListData.Location = new System.Drawing.Point(137, 568);
            this.lblDatapackListData.MaximumSize = new System.Drawing.Size(300, 0);
            this.lblDatapackListData.Name = "lblDatapackListData";
            this.lblDatapackListData.Size = new System.Drawing.Size(13, 13);
            this.lblDatapackListData.TabIndex = 12;
            this.lblDatapackListData.Text = "()";
            // 
            // btnEditWorld
            // 
            this.btnEditWorld.BackColor = System.Drawing.Color.Transparent;
            this.btnEditWorld.FlatAppearance.BorderSize = 0;
            this.btnEditWorld.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEditWorld.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnEditWorld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditWorld.ForeColor = System.Drawing.Color.White;
            this.btnEditWorld.Location = new System.Drawing.Point(12, 649);
            this.btnEditWorld.Name = "btnEditWorld";
            this.btnEditWorld.Size = new System.Drawing.Size(422, 23);
            this.btnEditWorld.TabIndex = 13;
            this.btnEditWorld.Text = "Ajouter/Editer le monde";
            this.btnEditWorld.UseVisualStyleBackColor = false;
            this.btnEditWorld.Visible = false;
            this.btnEditWorld.Click += new System.EventHandler(this.btnEditWorld_Click);
            // 
            // WorldCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(447, 680);
            this.Controls.Add(this.btnEditWorld);
            this.Controls.Add(this.lblDatapackListData);
            this.Controls.Add(this.lblDatapackList);
            this.Controls.Add(this.lblTypeGenerationData);
            this.Controls.Add(this.lblTypeGeneration);
            this.Controls.Add(this.lblWorldNameData);
            this.Controls.Add(this.lblWorldName);
            this.Controls.Add(this.btnGenerateWorld);
            this.Controls.Add(this.gbDatapackSettings);
            this.Controls.Add(this.gbGenerationSettings);
            this.Controls.Add(this.gbCreationEditWorld);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorldCreation";
            this.Text = "WorldCreation";
            this.Load += new System.EventHandler(this.WorldCreation_Load);
            this.gbCreationEditWorld.ResumeLayout(false);
            this.gbCreationEditWorld.PerformLayout();
            this.gbGenerationSettings.ResumeLayout(false);
            this.gbDatapackSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbWorldAlreadyExist;
        private System.Windows.Forms.TextBox txbWorldName;
        private System.Windows.Forms.Label lblWorldNameSettings;
        private System.Windows.Forms.GroupBox gbCreationEditWorld;
        private System.Windows.Forms.Button btnVerifNom;
        private System.Windows.Forms.GroupBox gbGenerationSettings;
        private System.Windows.Forms.ListView lvWorldPreset;
        private System.Windows.Forms.GroupBox gbDatapackSettings;
        private System.Windows.Forms.Button btnGenerationType;
        private System.Windows.Forms.Button btnValidateDatapackList;
        private System.Windows.Forms.Button btnDatapackDB;
        private System.Windows.Forms.ListView lvDatapackList;
        private System.Windows.Forms.Button btnGenerateWorld;
        private System.Windows.Forms.Label lblWorldName;
        private System.Windows.Forms.Label lblWorldNameData;
        private System.Windows.Forms.Label lblTypeGeneration;
        private System.Windows.Forms.Label lblTypeGenerationData;
        private System.Windows.Forms.Label lblDatapackList;
        private System.Windows.Forms.Label lblDatapackListData;
        private System.Windows.Forms.Button btnRefreshWorldPresets;
        private System.Windows.Forms.Button btnRefreshDatapackList;
        private System.Windows.Forms.Button btnEditWorld;
    }
}