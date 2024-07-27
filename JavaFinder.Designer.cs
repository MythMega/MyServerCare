namespace MCServCare
{
    partial class JavaFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JavaFinder));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.MaximumSize = new System.Drawing.Size(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Looking for a version of Java to download ? Select your target minecraft server v" +
    "ersion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "< chose a Minecraft version>",
            "1.0 > 1.16",
            "1.17",
            "1.18 > 1.19",
            "1.20 > 1.21"});
            this.comboBox1.Location = new System.Drawing.Point(56, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnDL
            // 
            this.btnDL.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDL.FlatAppearance.BorderSize = 0;
            this.btnDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDL.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDL.Location = new System.Drawing.Point(56, 132);
            this.btnDL.Name = "btnDL";
            this.btnDL.Size = new System.Drawing.Size(121, 38);
            this.btnDL.TabIndex = 2;
            this.btnDL.Text = "Download";
            this.btnDL.UseVisualStyleBackColor = false;
            this.btnDL.Click += new System.EventHandler(this.btnDL_Click);
            // 
            // JavaFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(245, 182);
            this.Controls.Add(this.btnDL);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JavaFinder";
            this.Text = "JavaFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDL;
    }
}