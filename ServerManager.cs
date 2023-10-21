using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            

            this.BackColor = background;
            lvWorldSelection.BackColor = deeperBackground;
            numRam.BackColor = deeperBackground;
            numSlotAmount.BackColor = deeperBackground;
            numViewDistance.BackColor = deeperBackground;
            numSimulationDistance.BackColor = deeperBackground;
            numSpawnProtecDistance.BackColor = deeperBackground;
            txbMOTD.BackColor = deeperBackground;
            comboGamemode.BackColor = deeperBackground;

            lblNotif.ForeColor = orangeTextColor;
            lblNotif.Visible = false;
        }

        private void ServerManager_Load(object sender, EventArgs e)
        {

            // Vérifier si le dossier ".sc" existe
            string scFolderPath = Path.Combine(Application.StartupPath, ".sc");
            if (!Directory.Exists(scFolderPath))
            {
                Directory.CreateDirectory(scFolderPath);
                getServerCareFiles();
                //btnUpdateSC_Click(sender, EventArgs.Empty);
            }


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
            foreach (string worldName in getWorldList())
            {
                lvWorldSelection.Items.Add(new ListViewItem($"{worldName}"));
                string c = GetProperty("level-name");
                if (worldName == c)
                    lblCurrWorld.Text = worldName;
            }

            numRam.Value = GetMemoryAllocationFromStartBat();
            numSlotAmount.Value = int.Parse(GetProperty("max-players"));
            numViewDistance.Value = int.Parse(GetProperty("view-distance"));
            numSimulationDistance.Value = int.Parse(GetProperty("simulation-distance"));
            numSpawnProtecDistance.Value = int.Parse(GetProperty("spawn-protection"));
            txbMOTD.Text = GetProperty("motd");

            btnPVPActive.Tag = GetProperty("pvp");
            btnWhitelist.Tag = GetProperty("white-list");
            btnEndOff.Tag = "dis";
            btnHardcoreActive.Tag = GetProperty("hardcore");
            btnNetherOff.Tag = GetProperty("allow-nether");
            btnOpenToCrack.Tag = GetProperty("online-mode");
            btnCommandBlockActive.Tag = GetProperty("enable-command-block");

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

            if (GetProfileValue("langue") == null)
                SetProfileValue("langue", "EN");
            makeTranslation(GetProfileValue("langue"));
            
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
            string zipFilePath = "https://jmdbymyth.000webhostapp.com/prj/mcservcare/.sc.zip";
            string targetFolderPath = Path.Combine(Application.StartupPath, ".sc");

            using (WebClient webClient = new WebClient())
            {
                // Télécharger le fichier ZIP depuis l'URL spécifiée
                webClient.DownloadFile(zipFilePath, "temp.zip");

                // Extraire le contenu du fichier ZIP vers le dossier cible
                ZipFile.ExtractToDirectory("temp.zip", targetFolderPath);

                // Supprimer le fichier ZIP temporaire
                File.Delete("temp.zip");
            }
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
            sendNotif(Updated + groupBox1.Text + " : " + myb.Text + ".");
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
            string pre = "java -Xmx";
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

        public void makeTranslation(string languageCode)
        {
            FULL_APP_LANGUAGE = languageCode;
            switch (languageCode)
            {
                case "FR":
                    translationFR();
                    SetProfileValue("langue", "FR");
                    break;
                case "EN":
                    translationEN();
                    SetProfileValue("langue", "EN");
                    break;
                case "DE":
                    translationDE();
                    SetProfileValue("langue", "DE");
                    break;
                case "ES":
                    translationES();
                    SetProfileValue("langue", "ES");
                    break;
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
            //label
            lblViewDistance.Text = "Vue (chunk)";

            //---Boutons

            //boutons systemes
            btnDownloadServJar.Text = "Télécharger serveur";
            btnUpdateServer.Text = "Mettre à jour Serveur";
            btnStartServer.Text = "Démarrer Serveur";

            //boutons paramètres
            lblRam.Text = "Changer RAM";

            //Maps
            btnWorldCreation.Text = "Gestion des mondes";
            btnWorldSelection.Text = "Changer de monde";


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

            //Specials items label
            labelDownloadJar = "Télécharger l'un des serveur parmis les types suivants et renommez 'server.jar' .";
            motdChanged = "Le MOTD a bien été mis a jour.";
            Updated = "MODIFIÉ - ";
            noWorld = "Erreur, aucun monde selectionné";

        }

        public void translationEN()
        {
            // DEBUT TRADUCTION

            //label
            lblViewDistance.Text = "View (chunk)";

            //---Boutons

            //boutons systemes
            btnDownloadServJar.Text = "Download Server";
            btnUpdateServer.Text = "Update server";
            btnStartServer.Text = "Start server";

            //boutons paramètres
            lblRam.Text = "Edit RAM";

            //Maps
            btnWorldCreation.Text = "Maps management";
            btnWorldSelection.Text = "Switch active map";

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

            //Specials items label
            labelDownloadJar = "Download jar from theses type, and rename it 'server.jar' .";
            motdChanged = "MOTD has been updated.";
            Updated = "UPDATED - ";
            noWorld = "Error, no world selectionned";
        }

        public void translationDE()
        {
            // DEBUT TRADUCTION

            //label
            lblViewDistance.Text = "Ansicht (Chunks)";

            //---Boutons

            //boutons systemes
            btnDownloadServJar.Text = "Server herunterladen";
            btnUpdateServer.Text = "Server aktualisieren";
            btnStartServer.Text = "Server starten";

            //boutons paramètres
            lblRam.Text = "RAM bearbeiten";

            //Maps
            btnWorldCreation.Text = "Kartenverwaltung";
            btnWorldSelection.Text = "Aktive Karte wechseln";

            //MOTD
            btnMOTD.Text = "MOTD ändern";

            //---Groupes
            gbSystem.Text = "System";
            gbSettings.Text = "Einstellungen";
            gbCracks.Text = "Crack";
            gbWhitelist.Text = "Whitelist";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "Befehlsblock";
            gbHardcore.Text = "Hardcore";
            gbMaps.Text = "Kartenverwaltung";
            gbDistances.Text = "Entfernungen";
            gbMOTD.Text = "MOTD";

            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = "Datei";
            //Items
            quitterToolStripMenuItem.Text = "Beenden";
            rechargerToolStripMenuItem.Text = "Neu laden";

            //-Langue
            //Head
            langueToolStripMenuItem.Text = "Sprache";
            //Items
            françaisToolStripMenuItem.Text = "Französisch";
            anglaisToolStripMenuItem.Text = "Englisch";
            allemandToolStripMenuItem.Text = "Deutsch";
            espagnolToolStripMenuItem.Text = "Spanisch";

            //-Infos
            //Head
            infosToolStripMenuItem.Text = "Informationen";
            //Items
            versionToolStripMenuItem.Text = "Version";
            changelogToolStripMenuItem.Text = "Änderungsprotokoll";
            reposToolStripMenuItem.Text = "Repository";
            créateursToolStripMenuItem.Text = "Schöpfer";

            //Specials items label
            labelDownloadJar = "Laden Sie ein Jar von diesen Typen herunter und benennen Sie es in 'server.jar' um.";
            motdChanged = "MOTD wurde aktualisiert.";
            Updated = "AKTUALISIERT - ";
            noWorld = "Fehler, keine Welt ausgewählt";
        }

        public void translationES()
        {
            // DEBUT TRADUCTION

            //label
            lblViewDistance.Text = "Vista (Chunks)";

            //---Boutons

            //boutons systemes
            btnDownloadServJar.Text = "Descargar servidor";
            btnUpdateServer.Text = "Actualizar servidor";
            btnStartServer.Text = "Iniciar servidor";

            //boutons paramètres
            lblRam.Text = "Editar RAM";

            //Maps
            btnWorldCreation.Text = "Gestión de mapas";
            btnWorldSelection.Text = "Cambiar mapa activo";

            //MOTD
            btnMOTD.Text = "Cambiar MOTD";

            //---Groupes
            gbSystem.Text = "Sistema";
            gbSettings.Text = "Configuración";
            gbCracks.Text = "Crack";
            gbWhitelist.Text = "Lista blanca";
            gbPvp.Text = "PvP";
            gbCommandBlock.Text = "Bloque de comandos";
            gbHardcore.Text = "Modo hardcore";
            gbMaps.Text = "Gestión de mapas";
            gbDistances.Text = "Distancias";
            gbMOTD.Text = "MOTD";

            //---Menu

            //-Fichier
            //Head
            fichierToolStripMenuItem.Text = "Archivo";
            //Items
            quitterToolStripMenuItem.Text = "Salir";
            rechargerToolStripMenuItem.Text = "Recargar";

            //-Langue
            //Head
            langueToolStripMenuItem.Text = "Idioma";
            //Items
            françaisToolStripMenuItem.Text = "Francés";
            anglaisToolStripMenuItem.Text = "Inglés";
            allemandToolStripMenuItem.Text = "Alemán";
            espagnolToolStripMenuItem.Text = "Español";

            //-Infos
            //Head
            infosToolStripMenuItem.Text = "Información";
            //Items
            versionToolStripMenuItem.Text = "Versión";
            changelogToolStripMenuItem.Text = "Registro de cambios";
            reposToolStripMenuItem.Text = "Repositorio";
            créateursToolStripMenuItem.Text = "Creadores";

            //Specials items label
            labelDownloadJar = "Descargue un archivo Jar de estos tipos y cambie su nombre a 'server.jar'.";
            motdChanged = "El MOTD ha sido actualizado.";
            Updated = "ACTUALIZADO - ";
            noWorld = "Error, no se ha seleccionado ningún mundo";
        }


        private void rechargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvWorldSelection.Items.Clear();
            ServerManager_Load(sender, e);
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.0 - pre01\nBuild : 2");
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
                    btn.BackColor = Color.Green;
                    btn.Text = "ON";
                }
                if (btn.Tag.ToString() == "false")
                {
                    btn.BackColor = Color.Red;
                    btn.Text = "OFF";
                }
                if (btn.Tag.ToString() == "dis")
                {
                    btn.Enabled = false;
                    btn.BackColor = Color.Orange;
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
            lvWorldSelection.Items.Clear();
            ServerManager_Load(sender, e);
        }
    }
}
