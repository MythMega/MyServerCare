using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCServCare
{
    public partial class RemoveJava : Form
    {
        private Color background = Color.FromArgb(255, 36, 36, 44);
        private Color deeperBackground = Color.FromArgb(255, 27, 27, 33);
        private Color orangeTextColor = Color.Orange;
        public List<string> toAdd = new List<string>();
        public List<string> toDel = new List<string>();
        public RemoveJava(List<string> items)
        {
            InitializeComponent();
            items.ForEach(item => { lvJavaList.Items.Add(new ListViewItem { Text = item }); });

            this.BackColor = background;
            lvJavaList.BackColor = deeperBackground;
            lvJavaList.ForeColor = orangeTextColor;

            btnAdd.Text = Traduction.TranslateByCode("Common.Add");
            btnRemove.Text = Traduction.TranslateByCode("Common.Remove");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files|*.exe";
            openFileDialog.Title = Traduction.TranslateByCode("RemoveJava.SelectExeFile");


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                toAdd.Add(openFileDialog.FileName);
                lvJavaList.Items.Add(new ListViewItem(Text=openFileDialog.FileName));
                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvJavaList.SelectedItems)
            {
                DialogResult dialogResult = MessageBox.Show(Traduction.TranslateByCode("RemoveJava.ConfirmDeleteJavaVersion", item.Text), "Are you sure ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    toDel.Add(item.Text);
                    lvJavaList.Items.Remove(item);
                }
            }
        }
    }
}
