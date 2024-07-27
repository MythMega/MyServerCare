using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCServCare
{
    public partial class JavaFinder : Form
    {
        private Color background = Color.FromArgb(255, 36, 36, 44);
        private Color deeperBackground = Color.FromArgb(255, 27, 27, 33);
        private Color orangeTextColor = Color.Orange;
        public JavaFinder()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            btnDL.Visible = false;

            btnDL.Text = Traduction.TranslateByCode("Common.Download");
            label1.Text = Traduction.TranslateByCode("JavaFinder.Explanation");

            this.BackColor = background;
            comboBox1.BackColor = deeperBackground;
            this.ForeColor = orangeTextColor; comboBox1.ForeColor = orangeTextColor;
        }

        private void btnDL_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(btnDL.Tag.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    btnDL.Visible=false;
                    break;

                case 1:
                    btnDL.Visible=true;
                    btnDL.Tag = "https://download.oracle.com/java/22/latest/jdk-22_windows-x64_bin.zip";
                    break;

                case 2:
                    btnDL.Visible=true;
                    btnDL.Tag = "https://download.java.net/java/GA/jdk16.0.2/d4a915d82b4c4fbb9bde534da945d746/7/GPL/openjdk-16.0.2_windows-x64_bin.zip";
                    break;

                case 3:
                    btnDL.Visible=true;
                    btnDL.Tag = "https://download.java.net/java/GA/jdk17/0d483333a00540d886896bac774ff48b/35/GPL/openjdk-17_windows-x64_bin.zip";
                    break;

                case 4:
                    btnDL.Visible=true;
                    btnDL.Tag = "https://download.java.net/java/GA/jdk21.0.2/f2283984656d49d69e91c558476027ac/13/GPL/openjdk-21.0.2_windows-x64_bin.zip";
                    break;

            }
        }
    }
}
