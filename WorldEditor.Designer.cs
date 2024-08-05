namespace MCServCare
{
    partial class WorldEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldEditor));
            this.lvCoreDatapack = new System.Windows.Forms.ListView();
            this.lvMapDatapack = new System.Windows.Forms.ListView();
            this.lvCustomDatapack = new System.Windows.Forms.ListView();
            this.gbDatapack = new System.Windows.Forms.GroupBox();
            this.lblNewDataPack = new System.Windows.Forms.Label();
            this.lblDPCustom = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.lblWorldName = new System.Windows.Forms.Label();
            this.txbDatapackNew = new System.Windows.Forms.TextBox();
            this.lblDPSystem = new System.Windows.Forms.Label();
            this.btnDeleteDatapack = new System.Windows.Forms.Button();
            this.btnAddCustomDP = new System.Windows.Forms.Button();
            this.btnAddCoreDP = new System.Windows.Forms.Button();
            this.txbWorldNameEdit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWorldNameChange = new System.Windows.Forms.Label();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.gbDatapack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCoreDatapack
            // 
            this.lvCoreDatapack.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCoreDatapack.HideSelection = false;
            this.lvCoreDatapack.Location = new System.Drawing.Point(6, 39);
            this.lvCoreDatapack.Name = "lvCoreDatapack";
            this.lvCoreDatapack.Size = new System.Drawing.Size(232, 163);
            this.lvCoreDatapack.TabIndex = 0;
            this.lvCoreDatapack.UseCompatibleStateImageBehavior = false;
            this.lvCoreDatapack.View = System.Windows.Forms.View.List;
            // 
            // lvMapDatapack
            // 
            this.lvMapDatapack.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMapDatapack.HideSelection = false;
            this.lvMapDatapack.Location = new System.Drawing.Point(325, 39);
            this.lvMapDatapack.Name = "lvMapDatapack";
            this.lvMapDatapack.Size = new System.Drawing.Size(239, 350);
            this.lvMapDatapack.TabIndex = 1;
            this.lvMapDatapack.UseCompatibleStateImageBehavior = false;
            this.lvMapDatapack.View = System.Windows.Forms.View.List;
            // 
            // lvCustomDatapack
            // 
            this.lvCustomDatapack.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCustomDatapack.HideSelection = false;
            this.lvCustomDatapack.Location = new System.Drawing.Point(6, 228);
            this.lvCustomDatapack.Name = "lvCustomDatapack";
            this.lvCustomDatapack.Size = new System.Drawing.Size(232, 163);
            this.lvCustomDatapack.TabIndex = 2;
            this.lvCustomDatapack.UseCompatibleStateImageBehavior = false;
            this.lvCustomDatapack.View = System.Windows.Forms.View.List;
            // 
            // gbDatapack
            // 
            this.gbDatapack.Controls.Add(this.cbVersion);
            this.gbDatapack.Controls.Add(this.lblNewDataPack);
            this.gbDatapack.Controls.Add(this.lblDPCustom);
            this.gbDatapack.Controls.Add(this.generate);
            this.gbDatapack.Controls.Add(this.lblWorldName);
            this.gbDatapack.Controls.Add(this.txbDatapackNew);
            this.gbDatapack.Controls.Add(this.lblDPSystem);
            this.gbDatapack.Controls.Add(this.btnDeleteDatapack);
            this.gbDatapack.Controls.Add(this.btnAddCustomDP);
            this.gbDatapack.Controls.Add(this.btnAddCoreDP);
            this.gbDatapack.Controls.Add(this.lvMapDatapack);
            this.gbDatapack.Controls.Add(this.lvCustomDatapack);
            this.gbDatapack.Controls.Add(this.lvCoreDatapack);
            this.gbDatapack.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatapack.Location = new System.Drawing.Point(12, 12);
            this.gbDatapack.Name = "gbDatapack";
            this.gbDatapack.Size = new System.Drawing.Size(570, 468);
            this.gbDatapack.TabIndex = 3;
            this.gbDatapack.TabStop = false;
            this.gbDatapack.Text = "Datapacks";
            // 
            // lblNewDataPack
            // 
            this.lblNewDataPack.AutoSize = true;
            this.lblNewDataPack.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewDataPack.Location = new System.Drawing.Point(6, 412);
            this.lblNewDataPack.Name = "lblNewDataPack";
            this.lblNewDataPack.Size = new System.Drawing.Size(153, 16);
            this.lblNewDataPack.TabIndex = 9;
            this.lblNewDataPack.Text = "Generate New Datapack";
            // 
            // lblDPCustom
            // 
            this.lblDPCustom.AutoSize = true;
            this.lblDPCustom.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPCustom.Location = new System.Drawing.Point(6, 212);
            this.lblDPCustom.Name = "lblDPCustom";
            this.lblDPCustom.Size = new System.Drawing.Size(56, 16);
            this.lblDPCustom.TabIndex = 8;
            this.lblDPCustom.Text = "Custom";
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.Color.CadetBlue;
            this.generate.FlatAppearance.BorderSize = 0;
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.generate.Location = new System.Drawing.Point(302, 431);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 7;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.GenerateDtapack);
            // 
            // lblWorldName
            // 
            this.lblWorldName.AutoSize = true;
            this.lblWorldName.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorldName.Location = new System.Drawing.Point(322, 23);
            this.lblWorldName.Name = "lblWorldName";
            this.lblWorldName.Size = new System.Drawing.Size(42, 16);
            this.lblWorldName.TabIndex = 7;
            this.lblWorldName.Text = "label2";
            // 
            // txbDatapackNew
            // 
            this.txbDatapackNew.BackColor = System.Drawing.Color.Teal;
            this.txbDatapackNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDatapackNew.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDatapackNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbDatapackNew.Location = new System.Drawing.Point(128, 431);
            this.txbDatapackNew.Name = "txbDatapackNew";
            this.txbDatapackNew.Size = new System.Drawing.Size(168, 22);
            this.txbDatapackNew.TabIndex = 6;
            this.txbDatapackNew.TextChanged += new System.EventHandler(this.txbDatapackNew_TextChanged);
            // 
            // lblDPSystem
            // 
            this.lblDPSystem.AutoSize = true;
            this.lblDPSystem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPSystem.Location = new System.Drawing.Point(6, 23);
            this.lblDPSystem.Name = "lblDPSystem";
            this.lblDPSystem.Size = new System.Drawing.Size(52, 16);
            this.lblDPSystem.TabIndex = 6;
            this.lblDPSystem.Text = "System";
            // 
            // btnDeleteDatapack
            // 
            this.btnDeleteDatapack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDeleteDatapack.FlatAppearance.BorderSize = 0;
            this.btnDeleteDatapack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDatapack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteDatapack.Location = new System.Drawing.Point(286, 199);
            this.btnDeleteDatapack.Name = "btnDeleteDatapack";
            this.btnDeleteDatapack.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteDatapack.TabIndex = 5;
            this.btnDeleteDatapack.Text = "<<";
            this.btnDeleteDatapack.UseVisualStyleBackColor = false;
            this.btnDeleteDatapack.Click += new System.EventHandler(this.btnDeleteDatapack_Click);
            // 
            // btnAddCustomDP
            // 
            this.btnAddCustomDP.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddCustomDP.FlatAppearance.BorderSize = 0;
            this.btnAddCustomDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomDP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCustomDP.Location = new System.Drawing.Point(248, 258);
            this.btnAddCustomDP.Name = "btnAddCustomDP";
            this.btnAddCustomDP.Size = new System.Drawing.Size(32, 32);
            this.btnAddCustomDP.TabIndex = 4;
            this.btnAddCustomDP.Tag = "custom";
            this.btnAddCustomDP.Text = ">>";
            this.btnAddCustomDP.UseVisualStyleBackColor = false;
            this.btnAddCustomDP.Click += new System.EventHandler(this.btnAddDP_Click);
            // 
            // btnAddCoreDP
            // 
            this.btnAddCoreDP.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddCoreDP.FlatAppearance.BorderSize = 0;
            this.btnAddCoreDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCoreDP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCoreDP.Location = new System.Drawing.Point(248, 140);
            this.btnAddCoreDP.Name = "btnAddCoreDP";
            this.btnAddCoreDP.Size = new System.Drawing.Size(32, 32);
            this.btnAddCoreDP.TabIndex = 3;
            this.btnAddCoreDP.Tag = "core";
            this.btnAddCoreDP.Text = ">>";
            this.btnAddCoreDP.UseVisualStyleBackColor = false;
            this.btnAddCoreDP.Click += new System.EventHandler(this.btnAddDP_Click);
            // 
            // txbWorldNameEdit
            // 
            this.txbWorldNameEdit.BackColor = System.Drawing.Color.Teal;
            this.txbWorldNameEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbWorldNameEdit.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWorldNameEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbWorldNameEdit.Location = new System.Drawing.Point(12, 567);
            this.txbWorldNameEdit.Name = "txbWorldNameEdit";
            this.txbWorldNameEdit.Size = new System.Drawing.Size(152, 22);
            this.txbWorldNameEdit.TabIndex = 4;
            this.txbWorldNameEdit.TextChanged += new System.EventHandler(this.txbWorldNameEdit_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(186, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWorldNameChange
            // 
            this.lblWorldNameChange.AutoSize = true;
            this.lblWorldNameChange.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorldNameChange.Location = new System.Drawing.Point(12, 548);
            this.lblWorldNameChange.Name = "lblWorldNameChange";
            this.lblWorldNameChange.Size = new System.Drawing.Size(83, 16);
            this.lblWorldNameChange.TabIndex = 8;
            this.lblWorldNameChange.Text = "World Name";
            // 
            // cbVersion
            // 
            this.cbVersion.BackColor = System.Drawing.Color.Teal;
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Items.AddRange(new object[] {
            "1.21 and higher",
            "1.20 and lower"});
            this.cbVersion.Location = new System.Drawing.Point(9, 430);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(113, 24);
            this.cbVersion.TabIndex = 10;
            // 
            // WorldEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 692);
            this.Controls.Add(this.lblWorldNameChange);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbWorldNameEdit);
            this.Controls.Add(this.gbDatapack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorldEditor";
            this.Text = "WorldEditor";
            this.gbDatapack.ResumeLayout(false);
            this.gbDatapack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCoreDatapack;
        private System.Windows.Forms.ListView lvMapDatapack;
        private System.Windows.Forms.ListView lvCustomDatapack;
        private System.Windows.Forms.GroupBox gbDatapack;
        private System.Windows.Forms.Button btnDeleteDatapack;
        private System.Windows.Forms.Button btnAddCustomDP;
        private System.Windows.Forms.Button btnAddCoreDP;
        private System.Windows.Forms.TextBox txbWorldNameEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDPSystem;
        private System.Windows.Forms.Label lblDPCustom;
        private System.Windows.Forms.Label lblWorldName;
        private System.Windows.Forms.TextBox txbDatapackNew;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label lblWorldNameChange;
        private System.Windows.Forms.Label lblNewDataPack;
        private System.Windows.Forms.ComboBox cbVersion;
    }
}