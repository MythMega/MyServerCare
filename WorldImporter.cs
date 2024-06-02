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
using static System.Windows.Forms.ListView;

namespace MCServCare
{
    public partial class WorldImporter : Form
    {
        public WorldImporter(Color background, Color deeperBackground, Color orangeTextColor)
        {
            InitializeComponent();
            loadWorlds();
            this.BackColor = background;
            lvWorlds.BackColor = deeperBackground;
            btnCancel.BackColor = background;
            btnImport.BackColor = background;
            btnCancel.ForeColor = orangeTextColor;
            btnImport.ForeColor = orangeTextColor;
            lvWorlds.ForeColor = orangeTextColor;

            btnSelect.BackColor = background;
            btnSelect.ForeColor = orangeTextColor;
            btnDeselect.BackColor = background;
            btnDeselect.ForeColor = orangeTextColor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadWorlds()
        {
            string worldDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "saves");

            if (Directory.Exists(worldDirectory))
            {
                string[] subdirectories = Directory.GetDirectories(worldDirectory);
                foreach (string subdirectory in subdirectories)
                {
                    string levelDatPath = Path.Combine(subdirectory, "level.dat");
                    if (File.Exists(levelDatPath))
                    {
                        lvWorlds.Items.Add(new ListViewItem(Path.GetFileName(subdirectory)));
                    }
                }
            }
        }
        private void importWorlds()
        {
            string path = Directory.GetCurrentDirectory();
            string worldDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft", "saves");
            if (Directory.Exists(worldDirectory))
            {
                foreach (ListViewItem item in lvWorlds.Items)
                {
                    if (item.Checked)
                    {
                        string sourceDirectory = Path.Combine(worldDirectory, item.Text);
                        string destinationDirectory = Path.Combine(path, item.Text);
                        if (Directory.Exists(sourceDirectory))
                        {
                            CopyDirectory(sourceDirectory, destinationDirectory);
                        }
                    }
                }
            }
        }

        private static void CopyDirectory(string sourceDirName, string destDirName)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + sourceDirName);
            }

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string tempPath = Path.Combine(destDirName, subdir.Name);
                CopyDirectory(subdir.FullName, tempPath);
            }
        }


        private void btnImport_Click(object sender, EventArgs e)
        {
            importWorlds();
            this.Close();
        }

        private void lvWorlds_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvWorlds.SelectedItems)
            {
                item.Checked = !item.Checked;
            }
        }

        private void selectAll(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvWorlds.Items)
            {
                item.Checked = true;
            }
        }
        private void deselectAll(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvWorlds.Items)
            {
                item.Checked = false;
            }
        }
    }
}
