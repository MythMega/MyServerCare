using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCServCare
{
    public partial class ServerManager : Form
    {

        private string FULL_APP_LANGUAGE = "EN";
        public ServerManager()
        {
            InitializeComponent();
            this.Icon = new Icon("chemin_vers_votre_icone.ico");
        }

        private void ServerManager_Load(object sender, EventArgs e)
        {
            numRam.Value = GetMemoryAllocationFromStartBat();
            numSlotAmount.Value = int.Parse(GetProperty("max-players"));
            numViewDistance.Value = int.Parse(GetProperty("view-distance"));
            numSimulationDistance.Value = int.Parse(GetProperty("simulation-distance"));
            numSpawnProtecDistance.Value = int.Parse(GetProperty("spawn-protection"));



            foreach (string worldName in getWorldList())
            {
                lvWorldSelection.Items.Add(new ListViewItem($"{worldName}"));
            }

            makeTranslation("FR");
        }

        private void btnRam_Click(object sender, EventArgs e)
        {
            if (numRam.Value > 7)
            {
                DialogResult dialogResult = MessageBox.Show("Vous avez saisie une valeur de ram élevée, attention celle ci sera alloué au serveur, êtes vous sur ?", "Attention, Warning Achtung", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Pas de soucis mon reuf");
                    return;
                }
            }
            string pre = "java -Xmx";
            string post = "G -jar server.jar nogui";
            string newString = pre + numRam.Value.ToString() + post;

            WriteInformationToFile(newString, "start.bat");
        }

        private void WriteInformationToFile(string information, string file)
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(directoryPath, file);

            // Vérifier si le fichier existe déjà
            if (File.Exists(filePath))
            {
                // Supprimer le fichier existant
                File.Delete(filePath);
            }

            // Créer le nouveau fichier avec l'information
            using (StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine(information);
            }
        }

        private int GetMemoryAllocationFromStartBat()
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(directoryPath, "start.bat");

            if (!File.Exists(filePath))
            {
                // Le fichier start.bat n'existe pas
                return 0;
            }

            string fileContent = File.ReadAllText(filePath);

            // Utiliser une expression régulière pour trouver la valeur du paramètre -Xmx
            Match match = Regex.Match(fileContent, @"-Xmx(\d+)G");

            if (match.Success)
            {
                string memorySize = match.Groups[1].Value;

                // Convertir la valeur en entier
                if (int.TryParse(memorySize, out int memoryAllocation))
                {
                    return memoryAllocation;
                }
            }

            // La valeur du paramètre -Xmx n'a pas été trouvée ou n'est pas valide
            MessageBox.Show("erreur");
            return 0;
        }

        private void UpdateServerProperties(string property, string value)
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(directoryPath, "server.properties");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("pas de fichier properties");
                // Le fichier serveur.properties n'existe pas
                return;
            }

            // Lire le contenu du fichier
            string[] lines = File.ReadAllLines(filePath);

            // Parcourir toutes les lignes du fichier
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                // Vérifier si la ligne contient la variable "white-list"
                if (line.StartsWith(property))
                {
                    // Modifier la valeur de la variable à "true"
                    lines[i] = property + "=" + value;
                    break;
                }
            }

            // Écrire le contenu modifié dans le fichier
            File.WriteAllLines(filePath, lines);
        }

        private void btnWorldCreation_Click(object sender, EventArgs e)
        {
            WorldCreation frmWorldCreation = new WorldCreation();
            frmWorldCreation.makeTranslation(FULL_APP_LANGUAGE);
            frmWorldCreation.ShowDialog();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<string> getWorldList()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] directories = Directory.GetDirectories(currentDirectory);

            List<string> foldersWithLevelDat = new List<string>();

            foreach (string directory in directories)
            {
                string levelDatPath = Path.Combine(directory, "level.dat");

                if (File.Exists(levelDatPath))
                {
                    string folderName = Path.GetFileName(directory);
                    foldersWithLevelDat.Add(folderName);
                }
            }

            return foldersWithLevelDat;
        }

        private void btnWhitelistActive_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("white-list", "true");
        }

        private void btnWhitelistDesactive_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("white-list", "false");
        }

        private void btnOpenToCrack_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("online-mode", "false");
        }

        private void btnCloseToCrack_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("online-mode", "true");
        }

        private void btnPVPActive_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("pvp", "true");
        }

        private void btnPVPDesactive_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("pvp", "false");
        }

        private void btnCommandBlockActive_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("enable-command-block", "true");
        }

        private void btnCommandBlockDesactive_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("enable-command-block", "false");
        }

        private void btnHardcoreActive_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("hardcore", "true");
        }

        private void btnHardcoreDesactive_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("hardcore", "false");
        }

        private void btnWorldSelection_Click(object sender, EventArgs e)
        {
            string activeWorld = lvWorldSelection.SelectedItems[0].Text;
            UpdateServerProperties("level-name", activeWorld);
        }

        private void btnViewDistance_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("view-distance", ((int)numViewDistance.Value).ToString());
        }

        private void btnSimulationDistance_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("simulation-distance", ((int)numSimulationDistance.Value).ToString());
        }

        private void btnSlotAmount_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("max-players", ((int)numSlotAmount.Value).ToString());
        }

        private void btnMOTD_Click(object sender, EventArgs e)
        {
            UpdateServerProperties("motd", txbMOTD.Text);
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            string batchFilePath = Path.Combine(Application.StartupPath, "start.bat");

            if (File.Exists(batchFilePath))
            {
                Process process = new Process();
                process.StartInfo.FileName = batchFilePath;
                process.StartInfo.WorkingDirectory = Application.StartupPath;

                process.Start();
            }
            else
            {
                MessageBox.Show("Le fichier 'start.bat' n'a pas été trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateServer_Click(object sender, EventArgs e)
        {
            string batchFilePath = Path.Combine(Application.StartupPath, "update.bat");

            if (File.Exists(batchFilePath))
            {
                Process process = new Process();
                process.StartInfo.FileName = batchFilePath;
                process.StartInfo.WorkingDirectory = Application.StartupPath;

                process.Start();
            }
            else
            {
                MessageBox.Show("Le fichier 'update.bat' n'a pas été trouvé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }












        public string GetProperty(string propertyName)
        {
            string filePath = "server.properties";

            // Vérifier si le fichier existe
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Le fichier server.properties n'existe pas.");
            }

            // Lire toutes les lignes du fichier
            string[] lines = File.ReadAllLines(filePath);

            // Parcourir chaque ligne et extraire la valeur associée à la propriété
            foreach (string line in lines)
            {
                // Séparer la ligne en propriété et valeur en utilisant le signe "=" comme délimiteur
                string[] parts = line.Split('=');

                // Vérifier si la propriété correspond
                if (parts.Length == 2 && parts[0].Trim().Equals(propertyName))
                {
                    // Retourner la valeur associée à la propriété
                    return parts[1].Trim();
                }
            }

            // Si la propriété n'est pas trouvée, retourner une valeur par défaut ou générer une exception selon vos besoins
            throw new ArgumentException($"La propriété '{propertyName}' n'a pas été trouvée dans le fichier server.properties.");
        }

        public List<Button> GetButtonsTags(string tag)
        {
            switch (tag)
            {
                case "active":
                    return new List<Button>()
                    {
                        btnHardcoreActive, btnPVPActive, btnCommandBlockActive
                    };
                case "desactive":
                    return new List<Button>()
                    {
                        btnHardcoreDesactive, btnPVPDesactive, btnCommandBlockDesactive
                    };
            }
            return new List<Button>();

        }

        public void makeTranslation(string languageCode)
        {
            FULL_APP_LANGUAGE = languageCode;
            switch (languageCode)
            {
                case "FR":
                    translationFR();
                    break;
                case "EN":
                    translationEN();
                    break;
                    //case "DE":
                    //    translationDE();
                    //    break;
                    //case "ES":
                    //    translationES();
                    //    break;
            }
        }



        private void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeTranslation("FR");
        }

        private void anglaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeTranslation("EN");
        }

        private void allemandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeTranslation("DE");
        }

        private void espagnolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeTranslation("ES");
        }


        public void translationFR()
        {
            // DEBUT TRADUCTION

            //---Boutons
            //boutons activer
            string btnActiveText = "Activer";
            string btnDesactiveText = "Desactiver";

            //boutons whitelist
            btnWhitelistActive.Text = "Activer Whitelist";
            btnWhitelistDesactive.Text = "Désactier Whitelist";

            //boutons systemes
            btnUpdateServer.Text = "Mettre à jour Serveur";
            btnStartServer.Text = "Démarrer Serveur";

            //boutons paramètres
            btnRam.Text = "Changer RAM";

            //cracks
            btnCloseToCrack.Text = "Fermer aux cracks";
            btnOpenToCrack.Text = "Ouvrir aux cracks";

            //Maps
            btnWorldCreation.Text = "Gestion des mondes";
            btnWorldSelection.Text = "Changer de monde";

            //Distances
            btnViewDistance.Text = "Distance de vue";
            btnSimulationDistance.Text = "Distance de Simulation";
            btnSpawnProtec.Text = "Distance protec. Spawn";

            //Nombre de slots
            btnSlotAmount.Text = "Mettre à jour";

            //MOTD
            btnMOTD.Text = "changer MOTD";

            //---Groupes
            gbSystem.Text = "Système";
            gbSettings.Text = "Paramètres";
            gbCracks.Text = "Crack";
            gbWhitelist.Text = "Whitelist";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "CommandBlock";
            gbHardcore.Text = "Hardcore";
            gbSlot.Text = "Nombre de slot";
            gbMaps.Text = "Gestion de maps";
            gbDistances.Text = "Distances";
            gbMOTD.Text = "MOTD";

            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = "Fichier";
            //Items
            quitterToolStripMenuItem.Text = "Quitter";
            rechargerToolStripMenuItem.Text = "Recharger";

            //-Langue
            //Head
            langueToolStripMenuItem.Text = "Langue";
            //Items
            françaisToolStripMenuItem.Text = "Français";
            anglaisToolStripMenuItem.Text = "Anglais";
            allemandToolStripMenuItem.Text = "Allemand";
            espagnolToolStripMenuItem.Text = "Espagnol";

            //-Infos
            //Head
            infosToolStripMenuItem.Text = "Infos";
            //Items
            versionToolStripMenuItem.Text = "Version";
            changelogToolStripMenuItem.Text = "Changelog";
            reposToolStripMenuItem.Text = "Repository";
            créateursToolStripMenuItem.Text = "Créateurs";


            foreach (Button myBtn in GetButtonsTags("active"))
            {
                myBtn.Text = btnActiveText;
            }
            foreach (Button myBtn in GetButtonsTags("desactive"))
            {
                myBtn.Text = btnDesactiveText;
            }
        }

        public void translationEN()
        {
            // DEBUT TRADUCTION

            //---Boutons
            //boutons activer
            string btnActiveText = "Enable";
            string btnDesactiveText = "Disable";

            //boutons whitelist
            btnWhitelistActive.Text = "Enable Whitelist";
            btnWhitelistDesactive.Text = "Disable Whitelist";

            //boutons systemes
            btnUpdateServer.Text = "Update server";
            btnStartServer.Text = "Start server";

            //boutons paramètres
            btnRam.Text = "Edit RAM";

            //cracks
            btnCloseToCrack.Text = "Close to Cracks";
            btnOpenToCrack.Text = "Open to Cracks";

            //Maps
            btnWorldCreation.Text = "Maps management";
            btnWorldSelection.Text = "Switch active map";

            //Distances
            btnViewDistance.Text = "View Distance";
            btnSimulationDistance.Text = "Simulation Distance";
            btnSpawnProtec.Text = "Spawn protec.";

            //Nombre de slots
            btnSlotAmount.Text = "Update";

            //MOTD
            btnMOTD.Text = "change MOTD";

            //---Groupes
            gbSystem.Text = "System";
            gbSettings.Text = "Settings";
            gbCracks.Text = "Crack";
            gbWhitelist.Text = "Whitelist";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "CommandBlock";
            gbHardcore.Text = "Hardcore";
            gbSlot.Text = "Slot amount";
            gbMaps.Text = "Maps management";
            gbDistances.Text = "Distances";
            gbMOTD.Text = "MOTD";

            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = "File";
            //Items
            quitterToolStripMenuItem.Text = "Quit";
            rechargerToolStripMenuItem.Text = "Reload";

            //-Langue
            //Head
            langueToolStripMenuItem.Text = "Language";
            //Items
            françaisToolStripMenuItem.Text = "French";
            anglaisToolStripMenuItem.Text = "English";
            allemandToolStripMenuItem.Text = "German";
            espagnolToolStripMenuItem.Text = "Spanish";

            //-Infos
            //Head
            infosToolStripMenuItem.Text = "Infos";
            //Items
            versionToolStripMenuItem.Text = "Version";
            changelogToolStripMenuItem.Text = "Changelog";
            reposToolStripMenuItem.Text = "Repository";
            créateursToolStripMenuItem.Text = "Creators";


            foreach (Button myBtn in GetButtonsTags("active"))
            {
                myBtn.Text = btnActiveText;
            }
            foreach (Button myBtn in GetButtonsTags("desactive"))
            {
                myBtn.Text = btnDesactiveText;
            }
        }

        private void rechargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvWorldSelection.Items.Clear();
            ServerManager_Load(sender, e);
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version Beta b0.1.0");
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MythMega/mcservcare/commits/master");
        }

        private void reposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MythMega/mcservcare/");

        }

        private void créateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creator creator = new Creator();
            creator.ShowDialog();
        }

        private void btnCreateBackup_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in lvWorldSelection.SelectedItems)
            {
            string worldName = selectedItem.Text; // Nom du monde

            // Créer un nom de fichier pour la sauvegarde
            string backupName = $"{worldName}-backup-{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.zip";

            // Chemin du dossier à sauvegarder
            string worldFolderPath = Path.Combine(Application.StartupPath, worldName);

            // Chemin complet du fichier de sauvegarde
            string backupFilePath = Path.Combine(Application.StartupPath, backupName);

            // Créer une archive ZIP du dossier du monde
            ZipFile.CreateFromDirectory(worldFolderPath, backupFilePath);

            // Dossier de sauvegarde principal
            string backupDirectory = Path.Combine(Application.StartupPath, "backup");

            // Sous-dossier portant le nom du monde
            string worldBackupDirectory = Path.Combine(backupDirectory, worldName);

            // Créer le dossier de sauvegarde principal s'il n'existe pas
            Directory.CreateDirectory(backupDirectory);

            // Créer le sous-dossier portant le nom du monde s'il n'existe pas
            Directory.CreateDirectory(worldBackupDirectory);

            // Déplacer le fichier de sauvegarde vers le sous-dossier approprié
            string destinationFilePath = Path.Combine(worldBackupDirectory, backupName);
            File.Move(backupFilePath, destinationFilePath);

            // Afficher un message de succès
            MessageBox.Show($"Sauvegarde créée : {destinationFilePath}");
        }
    }
    }
}
