﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace MCServCare
{
    public partial class ServerManager : Form
    {
        // modifier une valeur dans server.properties :
        // UpdateServerProperties("view-distance", ((int)numViewDistance.Value).ToString());

        private string FULL_APP_LANGUAGE = "EN";
        private string configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "JMD", "mcservercare", "config.cfg");
        private List<Button> btnOnOff = new List<Button>();
        private Color background = Color.FromArgb(255, 36, 36, 44);
        private Color deeperBackground = Color.FromArgb(255, 27, 27, 33);
        private Color orangeTextColor = Color.Orange;
        private string labelDownloadJar;
        private string motdChanged;
        private string Updated;
        private string noWorld;

        private WorldImporter worldImporter;

        public string APP_VERSION = "1.2.1b";
        public string APP_BUILD = "39";
        private static string repoOwner = "MythMega";
        private static string repoName = "MyServerCare";

        public string lastVersionUrl = $"https://github.com/MythMega/MyServerCare/releases/latest";

        public int versionLate = 0 ;

        public bool IS_LOADED = false;

        public ServerManager()
        {
            InitializeComponent();
            btnOnOff.Add(btnWhitelist);
            btnOnOff.Add(btnEndOff);
            btnOnOff.Add(btnHardcoreActive);
            btnOnOff.Add(btnNetherOff);
            btnOnOff.Add(btnOpenToCrack);
            btnOnOff.Add(btnPVPActive);
            btnOnOff.Add(btnCommandBlockActive);
            btnOnOff.Add(btnHideOnlinePlayer);

            

            this.BackColor = background;
            lvWorldSelection.BackColor = deeperBackground;
            numRam.BackColor = deeperBackground;
            numSlotAmount.BackColor = deeperBackground;
            numViewDistance.BackColor = deeperBackground;
            numSimulationDistance.BackColor = deeperBackground;
            numSpawnProtecDistance.BackColor = deeperBackground;
            numPort.BackColor = deeperBackground;
            txbMOTD.BackColor = deeperBackground;
            comboGamemode.BackColor = deeperBackground;
            cbJarSwitcher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJavaSwutcher.DropDownStyle = ComboBoxStyle.DropDownList;

            lblNotif.ForeColor = orangeTextColor;
            lblNotif.Visible = false;

            lvWorldSelection.AllowDrop = true;
        }

        private void ServerManager_Load(object sender, EventArgs e)
        {
            GC.Collect();

            string a = GetProfileValue("ServerJar");

            getServerCareFiles();

            try { checkVersion(); } catch { }

            // Vérifier si le fichier server.properties existe
            string serverPropertiesPath = Path.Combine(Application.StartupPath, "server.properties");
            if (!File.Exists(serverPropertiesPath))
            {
                createServerProperties();
            }

            // Vérifier si le fichier start.bat existe
            string startBatPath = Path.Combine(Application.StartupPath, "start.bat");
            if (!File.Exists(startBatPath))
            {
                createStartBat();
            }

            // Vérifier si le fichier eula.txt existe
            string eulaPath = Path.Combine(Application.StartupPath, "eula.txt");
            if (!File.Exists(eulaPath))
            {
                createEula();
            }

            // Vérifier si le fichier server.jar existe
            string serverJarPath = Path.Combine(Application.StartupPath, "server.jar");
            if (!File.Exists(eulaPath))
            {
                // a voir ce qu'on fait
            }
            lblCurrWorld.Text = "- X X X -";

            refreshComboWorldList();

            numRam.Value = GetMemoryAllocationFromStartBat();
            numSlotAmount.Value = int.Parse(GetProperty("max-players"));
            numViewDistance.Value = int.Parse(GetProperty("view-distance"));
            numSimulationDistance.Value = int.Parse(GetProperty("simulation-distance"));
            numSpawnProtecDistance.Value = int.Parse(GetProperty("spawn-protection"));
            numPort.Value = int.Parse(GetProperty("server-port"));
            txbMOTD.Text = GetProperty("motd");

            numViewDistance.Maximum = 32;
            numViewDistance.Minimum = 2;
            numSimulationDistance.Maximum = 32;
            numSimulationDistance.Minimum = 2;
            numSpawnProtecDistance.Minimum = 0;

            numSlotAmount.Minimum = 0;
            numRam.Minimum = 0;
            txbMOTD.MaxLength = 59;

            btnPVPActive.Tag = GetProperty("pvp");
            btnWhitelist.Tag = GetProperty("white-list");
            btnEndOff.Tag = "dis";
            btnHardcoreActive.Tag = GetProperty("hardcore");
            btnNetherOff.Tag = GetProperty("allow-nether");
            btnOpenToCrack.Tag = GetProperty("online-mode");
            btnCommandBlockActive.Tag = GetProperty("enable-command-block");
            btnHideOnlinePlayer.Tag = GetProperty("hide-online-players");

            string gm = GetProperty("gamemode");
            int selectedIndex = -1;
            for (int i = 0; i < comboGamemode.Items.Count; i++)
            {
                if (gm == comboGamemode.Items[i].ToString())
                {
                    selectedIndex = i;
                    break; // Sortir de la boucle dès que l'élément est trouvé
                }
            }
            comboGamemode.DropDownStyle = ComboBoxStyle.DropDownList;

            // Définir l'élément correspondant comme sélection par défaut
            if (selectedIndex != -1)
            {
                comboGamemode.SelectedIndex = selectedIndex;
            }
            updateOnOffStyles();

            VerifyFile();
            javaSelector();
            if (GetProfileValue("savedJavas") == null)
                SetProfileValue("savedJavas", "");

            loadJavajars();
            if (GetProfileValue("javaJar") == null)
                SetProfileValue("javaJar", "java");
            else
            {
                cbJavaSwutcher.SelectedIndex = cbJavaSwutcher.FindStringExact(GetProfileValue("javaJar"));
            }

            jarSelector();
            if (a == null || a == "")
                cbJarSwitcher.SelectedIndex = -1;
            else
            {
                
                cbJarSwitcher.SelectedIndex = cbJarSwitcher.FindStringExact(a);
                    }
            if (GetProfileValue("langue") == null)
                SetProfileValue("langue", "EN");
            makeTranslation(GetProfileValue("langue"));
            

            IS_LOADED = true;
        }

        private void refreshComboWorldList()
        {
            lvWorldSelection.Items.Clear();
            foreach (string worldName in getWorldList())
            {
                lvWorldSelection.Items.Add(new ListViewItem($"{worldName}"));
                string c = GetProperty("level-name");
                if (worldName == c)
                    lblCurrWorld.Text = "- " + worldName + " -";
            }
        }

        private async void checkVersion()
        {
            string latestVersion = await GetLatestVersionFromGitHub();
            if (IsNewVersionAvailable(APP_VERSION, latestVersion))
            {

                DialogResult dialogResult = MessageBox.Show($"New version available. You're {versionLate} late. Click Yes to download latest version of MCServerCare.", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    btnUpdateMCServerCare_Click(null, null);
                }
            }
            else
            {
                btnUpdateMCServerCare.Enabled = false;
                btnUpdateMCServerCare.FlatAppearance.BorderSize = 0;
            }

            

        }
        private static async Task<string> GetLatestVersionFromGitHub()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "C# App");
                string url = $"https://api.github.com/repos/{repoOwner}/{repoName}/releases/latest";
                string json = await client.GetStringAsync(url);
                JObject release = JObject.Parse(json);
                return release["tag_name"].ToString();
            }
        }

        private bool IsNewVersionAvailable(string currentVersion, string latestVersion)
        {
            int current = int.Parse(APP_BUILD);
            int latest = int.Parse(latestVersion);
            versionLate = latest - current;
            return latest > current;
        }

        private void VerifyFile()
        {

            if (!File.Exists(configFilePath))
            {
                // Le fichier n'existe pas, créons-le avec le contenu par défaut
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(configFilePath)); // Créer les répertoires si nécessaire
                    File.WriteAllText(configFilePath, String.Empty);
                    Console.WriteLine("Le fichier a été créé avec le contenu par défaut.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une erreur est survenue lors de la création du fichier : " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Le fichier existe déjà.");
            }
        }
        private void getServerCareFiles()
        {
            string targetFolderPath = Path.Combine(Application.StartupPath, ".sc");

            // Vérifier si le dossier '.sc' existe déjà
            if (Directory.Exists(targetFolderPath))
            {
                // Si c'est le cas, le supprimer
                Directory.Delete(targetFolderPath, true);
            }

            // Obtenir un flux pour la ressource intégrée
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("MCServCare.sc.zip"))
            {
                // Créer un fichier temporaire
                using (FileStream fileStream = new FileStream("temp.zip", FileMode.Create, FileAccess.Write))
                {
                    // Copier le contenu de la ressource intégrée dans le fichier temporaire
                    stream.CopyTo(fileStream);
                }
            }

            // Extraire le contenu du fichier ZIP vers le dossier cible
            ZipFile.ExtractToDirectory("temp.zip", targetFolderPath);

            // Supprimer le fichier ZIP temporaire
            File.Delete("temp.zip");
        }


        private void createServerProperties()
        {
            WriteInformationToFile("#Minecraft server properties\r\n#Mon Jul 10 23:12:52 CEST 2023\r\nenable-jmx-monitoring=false\r\nrcon.port=25575\r\nlevel-seed=\r\ngamemode=survival\r\nenable-command-block=false\r\nenable-query=false\r\ngenerator-settings={}\r\nenforce-secure-profile=true\r\nlevel-name=world\r\nmotd=A Minecraft Server\r\nquery.port=25565\r\npvp=true\r\ngenerate-structures=true\r\nmax-chained-neighbor-updates=1000000\r\ndifficulty=easy\r\nnetwork-compression-threshold=256\r\nmax-tick-time=60000\r\nrequire-resource-pack=false\r\nuse-native-transport=true\r\nmax-players=20\r\nonline-mode=true\r\nenable-status=true\r\nallow-flight=false\r\ninitial-disabled-packs=\r\nbroadcast-rcon-to-ops=true\r\nview-distance=10\r\nserver-ip=\r\nresource-pack-prompt=\r\nallow-nether=true\r\nserver-port=25565\r\nenable-rcon=false\r\nsync-chunk-writes=true\r\nop-permission-level=4\r\nprevent-proxy-connections=false\r\nhide-online-players=false\r\nresource-pack=\r\nentity-broadcast-range-percentage=100\r\nsimulation-distance=10\r\nrcon.password=\r\nplayer-idle-timeout=0\r\ndebug=false\r\nforce-gamemode=false\r\nrate-limit=0\r\nhardcore=false\r\nwhite-list=false\r\nbroadcast-console-to-ops=true\r\nspawn-npcs=true\r\nspawn-animals=true\r\nfunction-permission-level=2\r\ninitial-enabled-packs=vanilla\r\nlevel-type=minecraft\\:normal\r\ntext-filtering-config=\r\nspawn-monsters=true\r\nenforce-whitelist=false\r\nspawn-protection=16\r\nresource-pack-sha1=\r\nmax-world-size=29999984\r\n", "server.properties");
        }

        private void createStartBat()
        {
            WriteInformationToFile("java -Xmx2G -jar server.jar nogui", "start.bat");
        }

        private void createEula()
        {
            DialogResult dialogResult = MessageBox.Show("Accept Eula ?\r\nStart will abort if no\n\r\nAcceptez l'EULA ?\r\nLe démarrage sera interrompu en cas de refus.\n\r\nEULA akzeptieren?\r\nDer Start wird abgebrochen, wenn Nein.\n\r\n¿Acepta el EULA?\r\nEl inicio se abortará si no.", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Pas de soucis mon reuf");
                this.Close();
            }
            else
            {
                WriteInformationToFile("eula=true", "eula.txt");
                return;
            }
            
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
            frmWorldCreation.setColor(background, deeperBackground);
            frmWorldCreation.ShowDialog();
            frmWorldCreation.Close();
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

        public List<string> getJarList()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            List<string> jarFiles = new List<string>();

            //code
            try
            {
                // Obtenez tous les fichiers avec l'extension .jar dans le répertoire actuel
                string[] files = Directory.GetFiles(currentDirectory, "*.jar");

                // Ajoutez les noms de fichiers .jar à la liste (sans les chemins complets)
                foreach (string filePath in files)
                {
                    string fileName = Path.GetFileName(filePath);
                    jarFiles.Add(fileName);
                }
            }
            catch (Exception ex)
            {
                // Gérez les erreurs selon vos besoins (affichage, journalisation, etc.)
                Console.WriteLine($"Erreur lors de la récupération des fichiers .jar : {ex.Message}");
            }

            return jarFiles;
        }

        private void btnWhitelistActive_Click(object sender, EventArgs e)
        {
            Button myb = (Button)sender;
            if(myb.Tag.ToString() == "true")
            {
                UpdateServerProperties("white-list", "false");
                myb.Tag = "false";
            }
            else
            {
                UpdateServerProperties("white-list", "true");
                myb.Tag = "true";
            }
            updateOnOffStyles();
            sendNotif(Updated + gbWhitelist.Text + " : " + myb.Text + ".");
        }

        private void btnNetherOff_Click(object sender, EventArgs e)
        {
            Button myb = (Button)sender;
            if (myb.Tag.ToString() == "true")
            {
                UpdateServerProperties("allow-nether", "false");
                myb.Tag = "false";
            }
            else
            {
                UpdateServerProperties("allow-nether", "true");
                myb.Tag = "true";
            }
            updateOnOffStyles();
            sendNotif(Updated + gbNether.Text + " : " + myb.Text + ".");
        }

        private void btnOpenToCrack_Click(object sender, EventArgs e)
        {
            Button myb = (Button)sender;
            if (myb.Tag.ToString() == "true")
            {
                UpdateServerProperties("online-mode", "false");
                myb.Tag = "false";
            }
            else
            {
                UpdateServerProperties("online-mode", "true");
                myb.Tag = "true";
            }
            updateOnOffStyles();
            sendNotif(Updated + gbCracks.Text + " : " + myb.Text + ".");
        }


        private void btnPVPActive_Click(object sender, EventArgs e)
        {
            Button myb = (Button)sender;
            if (myb.Tag.ToString() == "true")
            {
                UpdateServerProperties("pvp", "false");
                myb.Tag = "false";
            }
            else
            {
                UpdateServerProperties("pvp", "true");
                myb.Tag = "true";
            }
            updateOnOffStyles();
            sendNotif(Updated + gbPvp.Text + " : " + myb.Text + ".");
        }


        private void btnCommandBlockActive_Click(object sender, EventArgs e)
        {
            Button myb = (Button)sender;
            if (myb.Tag.ToString() == "true")
            {
                UpdateServerProperties("enable-command-block", "false");
                myb.Tag = "false";
            }
            else
            {
                UpdateServerProperties("enable-command-block", "true");
                myb.Tag = "true";
            }
            updateOnOffStyles();
            sendNotif(Updated + gbCommandBlock.Text + " : " + myb.Text + ".");
        }

        private void btnHardcoreActive_Click(object sender, EventArgs e)
        {
            Button myb = (Button)sender;
            if (myb.Tag.ToString() == "true")
            {
                UpdateServerProperties("hardcore", "false");
                myb.Tag = "false";
            }
            else
            {
                UpdateServerProperties("hardcore", "true");
                myb.Tag = "true";
            }
            updateOnOffStyles();
            sendNotif(Updated + gbHardcore.Text + " : " + myb.Text + ".");
            
        }


        private void btnWorldSelection_Click(object sender, EventArgs e)
        {
            try
            {
                string activeWorld = lvWorldSelection.SelectedItems[0].Text;
                UpdateServerProperties("level-name", activeWorld);
                lblCurrWorld.Text = "- " + activeWorld + " -";
            }
            catch {
                MessageBox.Show(noWorld);
                lblCurrWorld.Text = "- X X X -";
            }
        }

        private void numRam_ValueChanged(object sender, EventArgs e)
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

            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(directoryPath, "start.bat");

            string javalink = File.ReadAllText(filePath).Split(' ')[0];

            string pre = javalink + " -Xmx";
            string post = "G -jar server.jar nogui";
            string newString = pre + numRam.Value.ToString() + post;

            WriteInformationToFile(newString, "start.bat");

            sendNotif(Updated + "Ram : " + numRam.Value.ToString() + "GB.");
        }

        private void numMaxPlayer_ValueChanged(object sender, EventArgs e)
        {
            UpdateServerProperties("max-players", ((int)numSlotAmount.Value).ToString());


            sendNotif(Updated + "Max Players : " + numSlotAmount.Value.ToString() + ".");
        }

        private void numViewDistance_ValueChanged(object sender, EventArgs e)
        {

            UpdateServerProperties("view-distance", ((int)numViewDistance.Value).ToString());


            sendNotif(Updated + "View distance : " + numViewDistance.Value.ToString() + ".");
        }

        private void numSimulationDistance_ValueChanged(object sender, EventArgs e)
        {

            UpdateServerProperties("simulation-distance", ((int)numSimulationDistance.Value).ToString());


            sendNotif(Updated + "Simulation distance : " + numSimulationDistance.Value.ToString() + ".");
        }

        private void numSpawnProtecDistance_ValueChanged(object sender, EventArgs e)
        {

            UpdateServerProperties("spawn-protection", ((int)numSpawnProtecDistance.Value).ToString());


            sendNotif(Updated + "Spawn protection : " + numSpawnProtecDistance.Value.ToString() + ".");
        }

        private void comboGamemode_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateServerProperties("gamemode", comboGamemode.SelectedItem.ToString());

            sendNotif(Updated + "Gamemode : " + comboGamemode.SelectedItem.ToString() + ".");
        }

        private void btnMOTD_Click(object sender, EventArgs e)
        {

            UpdateServerProperties("motd", txbMOTD.Text);

            sendNotif(motdChanged);
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            setJar();
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

        /// <summary>
        /// Get property inside server.properties
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
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
            return null;
        }


        private void rechargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvWorldSelection.Items.Clear();
            ServerManager_Load(sender, e);
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{APP_VERSION}\nBuild : {APP_BUILD}");
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MythMega/MyServerCare/wiki/Changelog");
        }

        private void reposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MythMega/MyServerCare/");
        }

        private void créateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MythMega/MyServerCare/wiki/Creators");
        }
        private void contributors(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MythMega/MyServerCare/wiki/Contributors");
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

        private void btnUpdateSC_Click(object sender, EventArgs e)
        {
            getServerCareFiles();
            // Obtenez le chemin du fichier .sc.zip inclus dans l'application
            string zipFileName = ".sc.zip";
            string zipFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), zipFileName);

            // Vérifiez si le fichier .sc.zip existe
            if (File.Exists(zipFilePath))
            {
                // Obtenez le chemin du répertoire de destination
                string destinationDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

                // Extrayez les fichiers du .sc.zip dans le répertoire de destination
                using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        string entryPath = Path.Combine(destinationDirectory, entry.FullName);
                        entry.ExtractToFile(entryPath, true);
                    }
                }
            }
            else
            {
                // Le fichier .sc.zip n'existe pas
                MessageBox.Show("Le fichier .sc.zip n'a pas été trouvé.");
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string workingDirectory = Application.StartupPath;

            Process process = new Process();
            process.StartInfo.FileName = "explorer.exe";
            process.StartInfo.Arguments = workingDirectory;
            process.Start();
        }

        private void sendNotif(string notifText)
        {
            lblNotif.Text = notifText;
            lblNotif.Visible = true;
            timerItem.Stop();
            timerItem.Start();
        }

        private void TimerItem_Tick(object sender, EventArgs e)
        {
            lblNotif.Visible = false;
            timerItem.Stop();
            lblNotif.Text = ""; // Réinitialisez le texte
        }
        private void updateOnOffStyles()
        {
            foreach (Button btn in btnOnOff)
            {
                if (btn.Tag.ToString() == "true")
                {
                    btn.BackColor = Color.FromArgb(68, 117, 68);
                    btn.Text = "ON";
                }
                if (btn.Tag.ToString() == "false")
                {
                    btn.BackColor = Color.FromArgb(117, 68, 68);
                    btn.Text = "OFF";
                }
                if (btn.Tag.ToString() == "dis")
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.FromArgb(157, 120, 68);
                    btn.ForeColor = Color.White;
                    btn.Text = "Not Available";
                }

            }
        }

        private void btnDownloadServJar_Click(object sender, EventArgs e)
        {
            FrmServerJar frmServerJar = new FrmServerJar();
            frmServerJar.setTextAndColor(background, labelDownloadJar);
            frmServerJar.ShowDialog();
            frmServerJar.Close();
        }

        public string GetProfileValue(string criterion)
        {
            string[] lines = File.ReadAllLines(configFilePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split('=');

                if (parts.Length == 2 && parts[0] == criterion)
                {
                    return parts[1];
                }
            }

            // Critère non trouvé, retourner une valeur par défaut ou une chaîne vide
            return null;
        }

        public void SetProfileValue(string criterion, string value)
        {
            string[] lines = File.ReadAllLines(configFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split('=');

                if (parts.Length == 2 && parts[0] == criterion)
                {
                    lines[i] = $"{criterion}={value}";
                    File.WriteAllLines(configFilePath, lines);
                    return;
                }
            }

            // Critère non trouvé, ajouter une nouvelle ligne avec le critère et la valeur
            string newLine = $"{criterion}={value}";
            File.AppendAllText(configFilePath, Environment.NewLine + newLine);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            refreshComboWorldList();
        }

        private void contributeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MythMega/MyServerCare/wiki/Contributors");
        }

        private void refreshJarSwitcher_Click(object sender, EventArgs e)
        {
            jarSelector();
        }

        private void jarSelector()
        {
            cbJarSwitcher.Items.Clear();
            foreach (string jar in getJarList())
            {
                cbJarSwitcher.Items.Add($"{jar}");
            }
        }


        private void setJar()
        {
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(directoryPath, "start.bat");
            string jar = cbJarSwitcher.Text;
            string newString = $"{cbJavaSwutcher.Text} -Xmx{numRam.Value.ToString()}G -jar {jar} nogui";
            SetProfileValue("ServerJar", cbJarSwitcher.Text);
            SetProfileValue("javaJar", cbJavaSwutcher.Text);
            
            WriteInformationToFile(newString, "start.bat");

        }

        private void cbJarSwitcher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(IS_LOADED == true)
                setJar();
            if(((ComboBox)sender).Tag.ToString() == "java")
                sendNotif(Updated + "Java : " + cbJavaSwutcher.Text + ".");
            if(((ComboBox)sender).Tag.ToString() == "server")
                sendNotif(Updated + "Server : " + cbJarSwitcher.Text + ".");
        }

        private void pbPlusjava_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Exe Files|*.exe";
            openFileDialog.Title = "Sélectionnez un fichier .exe";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string newFile = openFileDialog.FileName;
                cbJavaSwutcher.Items.Add(newFile);
                List<string> jars = new List<string>();
                foreach(string s in cbJavaSwutcher.Items)
                {
                    jars.Add(s);
                }
                SetProfileValue("savedJavas", String.Join(";", jars));
            }
        }
        private void javaSelector()
        {
            loadJavajars();
        }

        private void loadJavajars()
        {
            cbJavaSwutcher.Items.Clear();
            List<string> jars = new List<string> { };
            try
            {
                string a = GetProfileValue("savedJavas");
                string[] fiches = a.Split(';');
                jars.AddRange(fiches);
            }
            catch
            {

            }
            foreach (string jar in jars)
            {
                cbJavaSwutcher.Items.Add($"{jar}");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (worldImporter == null)
            {
                worldImporter = new WorldImporter(background, deeperBackground, orangeTextColor);
            }

            worldImporter.ShowDialog();

            if (worldImporter.isChanged)
            {
                lvWorldSelection.Items.Clear();
                ServerManager_Load(sender, e);
            }

            worldImporter.Dispose();
            worldImporter = null;
         }

        private void btnDeleteWorld_Click(object sender, EventArgs e)
        {
            List<string> selectedItemsStrings = new List<string>();
            foreach(ListViewItem item in lvWorldSelection.SelectedItems)
            {
                selectedItemsStrings.Add(item.Text);
            }
            string activeWorld = String.Join(", ", selectedItemsStrings);
            DialogResult dialogResult = MessageBox.Show($"Voulez-vous vraiment supprimer ce monde ({activeWorld}) ? C'est permanent.", "Êtes-vous sûr ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    foreach (ListViewItem selectedItem in lvWorldSelection.SelectedItems)
                    {

                        string path = Path.Combine(Directory.GetCurrentDirectory(), selectedItem.Text);
                        Directory.Delete(path, true);
                        lvWorldSelection.Items.Remove(selectedItem); // Supprime l'élément de la ListView

                    }
                    
                }
                catch
                {
                    MessageBox.Show(noWorld);
                }
                MessageBox.Show("Suppression réussie"); // Message de confirmation
            }
        }

        private void btnOpenWorldFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), lvWorldSelection.SelectedItems[0].Text);
                Process process = new Process();
                process.StartInfo.FileName = "explorer.exe";
                process.StartInfo.Arguments = path;
                process.Start();
            }
            catch
            {
                MessageBox.Show(noWorld);
            }
        }

        private void numPort_ValueChanged(object sender, EventArgs e)
        {
            UpdateServerProperties("server-port", ((int)numPort.Value).ToString());


            sendNotif(Updated + "Server port : " + numPort.Value.ToString() + ".");
        }

        private void roadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MythMega/MyServerCare/wiki/RoadMap");
        }

        private void lvWorldSelection_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                string targetPath = Path.Combine(targetDir, Path.GetFileName(file));
                File.Copy(file, targetPath);
            }

            foreach (var directory in Directory.GetDirectories(sourceDir))
            {
                string targetPath = Path.Combine(targetDir, Path.GetFileName(directory));
                CopyDirectory(directory, targetPath);
            }
        }

        private void lvWorldSelection_DragDrop(object sender, DragEventArgs e)
        {
            bool needReload = false;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (Directory.Exists(file))
                {
                    string levelDatPath = Path.Combine(file, "level.dat");
                    if (File.Exists(levelDatPath))
                    {
                        string destPath = Path.Combine(Application.StartupPath, Path.GetFileName(file));
                        CopyDirectory(file, destPath);
                        needReload = true;
                    }
                    else
                    {
                        MessageBox.Show($"L'élément nommé \"{file}\" n'est pas un monde Minecraft valide.");
                    }
                }
                else
                {
                    MessageBox.Show($"L'élément nommé \"{file}\" n'est pas un monde Minecraft valide.");
                }
            }
            if(needReload)
            {
                pictureBox1_Click(null, null);
            }
        }

        private void btnUpdateMCServerCare_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lastVersionUrl);
        
        }

        private void datapacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatapackDB ddb = new DatapackDB();
            ddb.ShowDialog();
            ddb.Close();
        }

        private void btnWorldOptions_Click(object sender, EventArgs e)
        {
            if(lvWorldSelection.SelectedItems.Count == 1)
            {
                WorldEditor we = new WorldEditor(lvWorldSelection.SelectedItems[0].Text);
                we.ShowDialog();
                we.Close();
            }
            else if(lvWorldSelection.SelectedItems.Count == 0)
            {
                MessageBox.Show(noWorld);
            }

        }

        private void getOtherJavaVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 
            JavaFinder jf = new JavaFinder();
            jf.ShowDialog();
        }

        private void howToInstallOtherJavaVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Traduction.TranslateByCode("Main.JAVA_HowToInstallJavaTutorial"));
        }

        private void removeJavaFromJavaSwitcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> elements = new List<string>();

            foreach(string lvi in cbJavaSwutcher.Items)
                elements.Add(lvi);

            RemoveJava rj = new RemoveJava(elements);

            rj.ShowDialog();

            // ajout des items

            foreach(string itemToAdd in rj.toAdd)
            {
                cbJavaSwutcher.Items.Add(itemToAdd);      
            }
            List<string> jars = new List<string>();

            // suppresion des items

            foreach (string itemToRem in rj.toDel)
                cbJavaSwutcher.Items.Remove(itemToRem);


            foreach (string s in cbJavaSwutcher.Items)
                jars.Add(s);
            SetProfileValue("savedJavas", String.Join(";", jars));
            rj.Close();

        }

        private void togglePluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PluginManager pluginManager = new PluginManager();
            pluginManager.ShowDialog();
            pluginManager.Close();
        }

        private void openPluginsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "plugins");
            Process process = new Process();
            process.StartInfo.FileName = "explorer.exe";
            process.StartInfo.Arguments = path;
            if(Directory.Exists(path))
            {
                process.Start();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("no plugin folder, create one ?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Directory.CreateDirectory(path);
                    process.Start();
                }
                else
                {
                    return;
                }

            }
        }

        private void pluginListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "plugins");

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Erreur : Le dossier n'existe pas.");
                return;
            }

            var files = Directory.GetFiles(path);
            var jarFiles = files.Where(file => file.EndsWith(".jar")).ToList();
            var disabledFiles = files.Where(file => file.EndsWith(".disabled")).ToList();

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("------\nON\n");
            jarFiles.ForEach(jarFile => stringBuilder.AppendLine(Path.GetFileNameWithoutExtension(jarFile)));
            stringBuilder.AppendLine("\n------\nOFF\n");
            disabledFiles.ForEach(disabledFile => stringBuilder.AppendLine(Path.GetFileNameWithoutExtension(disabledFile)));

            MessageBox.Show(stringBuilder.ToString());
        }

        private void btnHideOnlinePlayer_Click(object sender, EventArgs e)
        {
            Button myb = (Button)sender;
            if (myb.Tag.ToString() == "true")
            {
                UpdateServerProperties("hide-online-players", "false");
                myb.Tag = "false";
            }
            else
            {
                UpdateServerProperties("hide-online-players", "true");
                myb.Tag = "true";
            }
            updateOnOffStyles();
            sendNotif(Updated + gbHideOnline.Text + " : " + myb.Text + ".");
        }
    }
}
