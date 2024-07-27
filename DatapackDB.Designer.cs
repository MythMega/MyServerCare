namespace MCServCare
{
    partial class DatapackDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatapackDB));
            this.lvDatapacksCustom = new System.Windows.Forms.ListView();
            this.btnDeleteDatapack = new System.Windows.Forms.Button();
            this.btnAddDP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDatapacksCustom
            // 
            this.lvDatapacksCustom.HideSelection = false;
            this.lvDatapacksCustom.Location = new System.Drawing.Point(12, 53);
            this.lvDatapacksCustom.Name = "lvDatapacksCustom";
            this.lvDatapacksCustom.Size = new System.Drawing.Size(232, 251);
            this.lvDatapacksCustom.TabIndex = 0;
            this.lvDatapacksCustom.UseCompatibleStateImageBehavior = false;
            this.lvDatapacksCustom.View = System.Windows.Forms.View.List;
            // 
            // btnDeleteDatapack
            // 
            this.btnDeleteDatapack.AutoEllipsis = true;
            this.btnDeleteDatapack.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDeleteDatapack.FlatAppearance.BorderSize = 0;
            this.btnDeleteDatapack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDatapack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteDatapack.Location = new System.Drawing.Point(12, 24);
            this.btnDeleteDatapack.Name = "btnDeleteDatapack";
            this.btnDeleteDatapack.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteDatapack.TabIndex = 1;
            this.btnDeleteDatapack.Text = "Delete Datapack";
            this.btnDeleteDatapack.UseVisualStyleBackColor = false;
            this.btnDeleteDatapack.Click += new System.EventHandler(this.btnDeleteDatapack_Click);
            // 
            // btnAddDP
            // 
            this.btnAddDP.AutoEllipsis = true;
            this.btnAddDP.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddDP.FlatAppearance.BorderSize = 0;
            this.btnAddDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddDP.Location = new System.Drawing.Point(131, 24);
            this.btnAddDP.Name = "btnAddDP";
            this.btnAddDP.Size = new System.Drawing.Size(113, 23);
            this.btnAddDP.TabIndex = 2;
            this.btnAddDP.Text = "Ajouter un Datapack";
            this.btnAddDP.UseVisualStyleBackColor = false;
            this.btnAddDP.Click += new System.EventHandler(this.btnAddDP_Click);
            // 
            // DatapackDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 316);
            this.Controls.Add(this.btnAddDP);
            this.Controls.Add(this.btnDeleteDatapack);
            this.Controls.Add(this.lvDatapacksCustom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatapackDB";
            this.Text = "DatapackDB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDatapacksCustom;
        private System.Windows.Forms.Button btnDeleteDatapack;
        private System.Windows.Forms.Button btnAddDP;
    }
}