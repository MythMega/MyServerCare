using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCServCare
{
    
    public partial class WorldCreation : Form
    {
        public WorldCreation()
        {
            InitializeComponent();
        }

        private void WorldCreation_Load(object sender, EventArgs e)
        {
            //traitement du load
            //load liste of world preset
            List<string> worldPresetList = getDirectoryList(@".\.sc\worldtype");
            foreach (string directory in worldPresetList)
            {
                lvWorldPreset.Items.Add(directory);
            }
            // Sélection de l'élément "normal" par défaut
            ListViewItem defaultItem = lvWorldPreset.FindItemWithText("normal");
            if (defaultItem != null)
            {
                defaultItem.Selected = true;
            }

            //load liste of world preset
            List<string> datapackList = getDirectoryList(@".\.sc\datapack");
            foreach (string directory in datapackList)
            {
                lvDatapackList.Items.Add(directory);
            }

            lblTypeGenerationData.Text = "normal";



            //World Selection
            gbCreationEditWorld.Text = Traduction.TranslateByCode("WorldCreator.CreationEditionWorld");
            lblWorldNameSettings.Text = Traduction.TranslateByCode("WorldCreator.WorldName");
            chbWorldAlreadyExist.Text = Traduction.TranslateByCode("WorldCreator.WorldAlreadyExist");
            btnVerifNom.Text = Traduction.TranslateByCode("WorldCreator.VerifyName");

            //Generate World
            gbGenerationSettings.Text = Traduction.TranslateByCode("Common.Generate");
            btnRefreshWorldPresets.Text = Traduction.TranslateByCode("Common.Refresh");
            btnGenerationType.Text = Traduction.TranslateByCode("Common.Validate");

            //Datapack management
            btnRefreshDatapackList.Text = Traduction.TranslateByCode("Common.Refresh");
            btnDatapackDB.Text = Traduction.TranslateByCode("WorldCreator.DatapackBank");
            btnValidateDatapackList.Text = Traduction.TranslateByCode("Common.Validate");

            //Other settings
            lblWorldName.Text = Traduction.TranslateByCode("WorldCreator.WorldName");
            lblTypeGeneration.Text = Traduction.TranslateByCode("WorldCreator.GenerationPreset");
            lblDatapackList.Text = Traduction.TranslateByCode("WorldCreator.DatapackList");
            btnEditWorld.Text = Traduction.TranslateByCode("WorldCreator.EditWorld");
            btnGenerateWorld.Text = Traduction.TranslateByCode("Common.Generate");

            gbDatapackSettings.Text = "Datapacks";
        }
        

        private void chbWorldAlreadyExist_CheckedChanged(object sender, EventArgs e)
        {
            if(chbWorldAlreadyExist.Checked) {
                gbGenerationSettings.Enabled = false;
                btnGenerateWorld.Visible = false;
                btnEditWorld.Visible = true;
            }
            else {
                gbGenerationSettings.Enabled = true;
                btnGenerateWorld.Visible = true;
                btnEditWorld.Visible = false;
            }
        }

        private void btnVerifNom_Click(object sender, EventArgs e)
        {
            string directoryPath = Path.Combine(getCurrentDirectory(), txbWorldName.Text);
            // Expression régulière pour vérifier si le string contient au moins 3 lettres,
            // avec la possibilité d'avoir des espaces, des tirets et des underscores,
            // mais le premier caractère ne doit pas être un espace.
            string pattern = @"^(?![\s])[a-zA-Z0-9\s_-]{3,}$";
            Regex regex = new Regex(pattern);

            if(regex.IsMatch(txbWorldName.Text) == false)
            {
                MessageBox.Show("Votre nom doit contenir au moins 3 lettres, ne pas commencer par un espace et ne contenir que des lettres ou chiffres, espaces et tiret (-/_).");
                return;
            }
            else if(txbWorldName.Text == "backups" || txbWorldName.Text == "bundler" || txbWorldName.Text == "cache" || txbWorldName.Text == "config" || txbWorldName.Text == "crash-reports" || txbWorldName.Text == "libraries" || txbWorldName.Text == "logs" || txbWorldName.Text == "plugins" || txbWorldName.Text == "versions")
            {
                MessageBox.Show("Votre nom n'est pas autorisé : celui ci correspond à un des dossiers important du serveur.");
                return;
            }
            else if (chbWorldAlreadyExist.Checked)
            {
                if (!Directory.Exists(directoryPath))
                {
                    MessageBox.Show("Erreur, ce nom n'existe pas.");
                    lblWorldNameData.Text = "()";
                }
                else
                {
                    MessageBox.Show("Ce nom de monde est valide !");
                    lblWorldNameData.Text = txbWorldName.Text;
                }
            }
            else
            {
                if (!Directory.Exists(directoryPath))
                {
                    MessageBox.Show("Ce nom de monde est valide !");
                    lblWorldNameData.Text = txbWorldName.Text;
                }
                else
                {
                    MessageBox.Show("Erreur, ce nom existe déjà.");
                    lblWorldNameData.Text = "()";
                }
            }
        }

        private void btnGenerationType_Click(object sender, EventArgs e)
        {
            if (lvWorldPreset.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = lvWorldPreset.SelectedItems[0];
                lblTypeGenerationData.Text = selectedItem.Text;
            }
            else
            {
                MessageBox.Show("une erreur est apparue");
            }
        }

        private void btnDatapackDB_Click(object sender, EventArgs e)
        {
            DatapackDB datapckDB = new DatapackDB();
            datapckDB.ShowDialog();
        }

        private void btnGenerateWorld_Click(object sender, EventArgs e)
        {
            if(lblWorldNameData.Text != "()")
            {
                string appDirectory = Application.StartupPath;
                string sourceDirectory = Path.Combine(appDirectory, ".sc", "worldtype", lblTypeGenerationData.Text);
                string destinationDirectory = Path.Combine(appDirectory, lblWorldNameData.Text);

                try
                {
                    Directory.CreateDirectory(destinationDirectory);
                    DirectoryCopy(sourceDirectory, destinationDirectory, true);

                    //MessageBox.Show("Le dossier du datapack a été créé et son contenu a été copié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la création du dossier datapack et de la copie de son contenu.\n\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                addDatapack();
            }
            else
            {
                MessageBox.Show("Pas Good !");
            }
        }

        private void btnEditWorld_Click(object sender, EventArgs e)
        {
            if (lblWorldNameData.Text == "()")
            {
                MessageBox.Show("Erreur, aucun monde n'a été trouvé. Essayez de cliquer sur 'Verifier le nom'");
                return;
            }
            addDatapack();
            MessageBox.Show(Traduction.TranslateByCode("WorldCreator.Success"));

        }

        public void setColor(Color background, Color deeperBackground)
        {
            this.BackColor = background;
            txbWorldName.BackColor = deeperBackground;
            lvDatapackList.BackColor = deeperBackground;
            lvWorldPreset.BackColor = deeperBackground;
        }



        #region utilities


        public void addDatapack()
        {
            
            //EDITION DE MONDE
            //TO DO : DEPLACER LES DOSSIERS avec pour nom chaque SELECTEDITEMS DE DATAPACKS PRESENTS DE .sc/datapacks
            foreach (ListViewItem lvItem in lvDatapackList.SelectedItems)
            {
                string sourceDirectory = Path.Combine(Application.StartupPath, ".sc", "datapack", lvItem.Text);
                string destinationDirectory = Path.Combine(Application.StartupPath, lblWorldNameData.Text, "datapacks", lvItem.Text);

                try
                {
                    Directory.CreateDirectory(destinationDirectory);
                    DirectoryCopy(sourceDirectory, (destinationDirectory), true);
                    MessageBox.Show(destinationDirectory);

                    MessageBox.Show("Le datapack" + lvItem.Text + " a été copié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la copie du dossier " + lvItem.Text + ".\n\n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DirectoryCopy(string sourceDir, string destDir, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDir);

            if (!dir.Exists)
                throw new DirectoryNotFoundException("Le répertoire source n'existe pas ou n'a pas pu être trouvé: " + sourceDir);

            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destDir);

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDir, file.Name);
                file.CopyTo(temppath, true);
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDir, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }


        public string getCurrentDirectory()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public List<string> getDirectoryList(string relativePath)
        {
            string currentDirectory = getCurrentDirectory();
            string directoryPath = Path.Combine(currentDirectory, relativePath);

            List<string> folderNames = new List<string>();
            if (Directory.Exists(directoryPath))
            {
                string[] directories = Directory.GetDirectories(directoryPath);

                foreach (string directory in directories)
                {
                    string folderName = Path.GetFileName(directory);
                    folderNames.Add(folderName);
                }
            }
            return folderNames;
        }

        #endregion

        private void lvDatapackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDatapackList.SelectedItems.Count < 1)
            {
                lblDatapackListData.Text = "{}";
            }
            else
            {
                string r = "";
                foreach(ListViewItem selectedItem in  lvDatapackList.SelectedItems)
                {
                    r += selectedItem.Text + "; ";
                }
                lblDatapackListData.Text = "{" + r + "}";
                 
            }
        }

        private void txbWorldName_TextChanged(object sender, EventArgs e)
        {
            // Créer une expression régulière qui correspond à tout ce qui n'est pas une lettre, un nombre, un espace, un point ou un underscore
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9 ._-]");

            // Utiliser l'expression régulière pour remplacer les caractères non désirés par une chaîne vide
            txbWorldName.Text = regex.Replace(txbWorldName.Text, "");

            // Supprimer les espaces en première et dernière position
            txbWorldName.Text = txbWorldName.Text.Trim();

            // Positionner le curseur à la fin du texte
            txbWorldName.SelectionStart = txbWorldName.Text.Length;
        }
    }




}