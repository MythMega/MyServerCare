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
    public partial class DatapackDB : Form
    {
        string dbDatapackFolder = Path.Combine(Application.StartupPath, ".data", "datapackdb");
        private Color background = Color.FromArgb(255, 36, 36, 44);
        private Color deeperBackground = Color.FromArgb(255, 27, 27, 33);
        public DatapackDB()
        {
            InitializeComponent();
            lvDatapacksCustom.AllowDrop = true;

            // Ajouter les gestionnaires d'événements
            lvDatapacksCustom.DragEnter += lvDatapacksCustom_DragEnter;
            lvDatapacksCustom.DragDrop += lvDatapacksCustom_DragDrop;

            // Vérifier si le dossier datapack existe
            if (!Directory.Exists(dbDatapackFolder))
            {
                // Créer le dossier s'il n'existe pas
                Directory.CreateDirectory(dbDatapackFolder);
            }

            LoadDP();
            this.BackColor = background;
            lvDatapacksCustom.BackColor = deeperBackground;
            lvDatapacksCustom.ForeColor = Color.White;

            btnAddDP.Text = Traduction.TranslateByCode("DatapackDB.AddDatapack");
            btnDeleteDatapack.Text = Traduction.TranslateByCode("DatapackDB.DelDatapack");
        }

        private void btnAddDP_Click(object sender, EventArgs e)
        {
            bool needReload = false;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog.FileNames)
                    {
                        if (Path.GetExtension(file) == ".zip")
                        {
                            // Copier le fichier zip dans le dossier de datapack
                            File.Copy(file, Path.Combine(Application.StartupPath, ".data/datapackdb", Path.GetFileName(file)), true);
                            needReload = true;
                        }
                        else if (Directory.Exists(file) && File.Exists(Path.Combine(file, "pack.mcmeta")))
                        {
                            // Copier le dossier dans le dossier de datapack
                            DirectoryCopy(file, Path.Combine(Application.StartupPath, ".data/datapackdb", Path.GetFileName(file)), true);
                            needReload = true;
                        }
                        else
                        {
                            MessageBox.Show(Traduction.TranslateByCode("DatapackDB.InvalidDatapack", Path.GetFileName(file)));
                        }
                    }
                }
            }
            if(needReload)
            {
                LoadDP();
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void lvDatapacksCustom_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void lvDatapacksCustom_DragDrop(object sender, DragEventArgs e)
        {
            bool needReload = false;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".zip")
                {
                    // Copier le fichier zip dans le dossier de datapack
                    File.Copy(file, Path.Combine(Application.StartupPath, ".data/datapackdb", Path.GetFileName(file)), true);
                    needReload = true;
                }
                else if (Directory.Exists(file) && File.Exists(Path.Combine(file, "pack.mcmeta")))
                {
                    // Copier le dossier dans le dossier de datapack
                    DirectoryCopy(file, Path.Combine(Application.StartupPath, ".data/datapackdb", Path.GetFileName(file)), true);
                    needReload = true;
                }
                else
                {
                    MessageBox.Show($"L'élément nommé {Path.GetFileName(file)} n'est pas valide.");
                }
            }
            if (needReload)
            {
                LoadDP();
            }
        }


        private void LoadDP()
        {
            string datapackDir = Path.Combine(Application.StartupPath, ".data/datapackdb");

            // Supprimer tous les éléments de la ListView
            lvDatapacksCustom.Items.Clear();

            // Vérifier si le dossier datapack existe
            if (Directory.Exists(datapackDir))
            {
                // Parcourir tous les fichiers et dossiers dans le dossier datapack
                foreach (string file in Directory.EnumerateFileSystemEntries(datapackDir))
                {
                    if (Path.GetExtension(file) == ".zip" || (Directory.Exists(file) && File.Exists(Path.Combine(file, "pack.mcmeta"))))
                    {
                        // Ajouter l'élément à la ListView
                        lvDatapacksCustom.Items.Add(Path.GetFileName(file));
                    }
                }
            }
            else
            {
                // Créer le dossier s'il n'existe pas
                Directory.CreateDirectory(datapackDir);
            }
        }

        private void btnDeleteDatapack_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvDatapacksCustom.Items)
            {
                if(item.Text.EndsWith(".zip"))
                    File.Delete(Path.Combine(Application.StartupPath, ".data", "datapackdb", item.Text));
                else
                    Directory.Delete(Path.Combine(Application.StartupPath, ".data", "datapackdb", item.Text), true);
            }
        }
    }
}
