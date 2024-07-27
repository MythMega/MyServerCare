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
using System.Windows.Forms.VisualStyles;

namespace MCServCare
{
    public partial class WorldEditor : Form
    {
        string worldname = string.Empty;
        private Color background = Color.FromArgb(255, 36, 36, 44);
        private Color deeperBackground = Color.FromArgb(255, 27, 27, 33);
        private Color orangeTextColor = Color.Orange;
        public WorldEditor(string text)
        {
            InitializeComponent();
            worldname = text;
            loadData();
            theme();

            lblDPCustom.Text = Traduction.TranslateByCode("WorldEditor.Custom");
            lblDPSystem.Text = Traduction.TranslateByCode("WorldEditor.System");
            lblNewDataPack.Text = Traduction.TranslateByCode("WorldEditor.GenerateNewDatapack");
            lblWorldNameChange.Text = Traduction.TranslateByCode("Common.WorldName");
            btnSave.Text = Traduction.TranslateByCode("Common.Save");

        }

        private void theme()
        {
            this.BackColor = background;
            gbDatapack.BackColor = background;
            gbDatapack.ForeColor = orangeTextColor;

            lblWorldName.ForeColor = orangeTextColor;
            lblDPCustom.ForeColor = orangeTextColor;
            lblDPSystem.ForeColor = orangeTextColor;
            lblNewDataPack.ForeColor = orangeTextColor;
            lblWorldNameChange.ForeColor = orangeTextColor;

            lvCoreDatapack.BackColor = deeperBackground;
            lvCustomDatapack.BackColor = deeperBackground;
            lvMapDatapack.BackColor = deeperBackground;

            lvCoreDatapack.ForeColor = Color.White;
            lvCustomDatapack.ForeColor = Color.White;
            lvMapDatapack.ForeColor = Color.White;

            txbDatapackNew.BackColor = deeperBackground;
            txbWorldNameEdit.BackColor = deeperBackground;

            txbDatapackNew.ForeColor = Color.White;
            txbWorldNameEdit.ForeColor = Color.White;
        }

        private void loadData()
        {
            //load liste of world preset
            List<string> coreDatapackList = getDatapackItems(Path.Combine(Application.StartupPath, ".sc", "datapack"));
            List<string> customDatapackList = getDatapackItems(Path.Combine(Application.StartupPath, ".data", "datapackdb"));
            List<string> worldDatapackList = getDatapackItems(Path.Combine(Application.StartupPath, worldname, "datapacks"));

            lvCoreDatapack.Items.Clear();
            lvCustomDatapack.Items.Clear();
            lvMapDatapack.Items.Clear();
            coreDatapackList.ForEach(coreDatapack => { lvCoreDatapack.Items.Add(coreDatapack); });
            customDatapackList.ForEach(customDatapack => { lvCustomDatapack.Items.Add(customDatapack); });
            worldDatapackList.ForEach(worldDatapack => { lvMapDatapack.Items.Add(worldDatapack); });

            lblWorldName.Text = worldname;

            txbWorldNameEdit.Text = worldname;

        }

        /// <summary>
        /// retourne les chemins tous les fichiers zip OU les dossiers présents dans l'argument 'path'
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private List<string> getDatapackItems(string path)
        {
            List<string> result = new List<string>();

            // Vérifiez si le chemin existe
            if (Directory.Exists(path))
            {
                // Obtenez tous les fichiers zip
                string[] zipFiles = Directory.GetFiles(path, "*.zip", SearchOption.TopDirectoryOnly);
                foreach (string f in zipFiles)
                {
                    result.Add(Path.GetFileName(f));
                }

                // Obtenez tous les dossiers
                string[] directories = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                foreach (string f in directories)
                {
                    result.Add(Path.GetFileName(f));
                }
            }

            return result;
        }

        private void addDatapack(string source)
        {
            List<string> filePaths = new List<string>();
            switch(source)
            {
                case "core":
                    foreach(ListViewItem dtpck in lvCoreDatapack.SelectedItems)
                    {
                        filePaths.Add(Path.Combine(Application.StartupPath, ".sc", "datapack", dtpck.Text));
                    }
                    break;

                case "custom":
                    foreach (ListViewItem dtpck in lvCustomDatapack.SelectedItems)
                    {
                        filePaths.Add(Path.Combine(Application.StartupPath, ".data", "datapackdb", dtpck.Text));
                    }
                    break;

            }

            filePaths.ForEach(file => copyDatapack(file));
            loadData();
        }

        private void copyDatapack(string f)
        {
            string destinationPath = Path.Combine(Application.StartupPath, worldname, "datapacks");
            try
            {
                File.Copy(f, Path.Combine(destinationPath, Path.GetFileName(f)));
            }
            catch
            {
                CopyDirectory(f, destinationPath);
            }
        }

        private void btnAddDP_Click(object sender, EventArgs e)
        {
            addDatapack(((Button)sender).Tag.ToString());
        }

        private void btnDeleteDatapack_Click(object sender, EventArgs e)
        {
            List<string> filePaths = new List<string>();
            foreach (ListViewItem dtpck in lvMapDatapack.SelectedItems)
            {
                filePaths.Add(Path.Combine(Application.StartupPath, worldname, "datapacks", dtpck.Text));
            }
            filePaths.ForEach(file => DeleteDatapack(file));
            loadData();
        }

        private void DeleteDatapack(string f)
        {
            try { File.Delete(f); } catch { Directory.Delete(f, true); }
        }

        public static void CopyDirectory(string sourceDirectory, string targetDirectory)
        {
            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(Path.Combine(targetDirectory, diSource.Name));

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copier chaque fichier dans le nouveau chemin
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copier chaque sous-dossier en utilisant la récursion
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txbWorldNameEdit.Text.Length < 1)
            {
                MessageBox.Show("Error empy name");
                return;
            }
            string sourcePath = Path.Combine(Application.StartupPath, worldname);
            string destPath = Path.Combine(Application.StartupPath, txbWorldNameEdit.Text);

            if (!Directory.Exists(sourcePath))
            {
                MessageBox.Show(Traduction.TranslateByCode("Error.DirNotExist"));
            }
            else if (Directory.Exists(destPath))
            {
                MessageBox.Show(Traduction.TranslateByCode("Error.DirAlreadyExist"));
            }
            else
            {
                try
                {
                    Directory.Move(sourcePath, destPath);
                    worldname = txbWorldNameEdit.Text;
                    MessageBox.Show(Traduction.TranslateByCode("Common.Success"));
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{Traduction.TranslateByCode("Error.RenameError")}\n" + ex.Message);
                }
            }
        }

        private void txbWorldNameEdit_TextChanged(object sender, EventArgs e)
        {
            // Créer une expression régulière qui correspond à tout ce qui n'est pas une lettre, un nombre, un espace, un point ou un underscore
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9 ._-]");

            // Utiliser l'expression régulière pour remplacer les caractères non désirés par une chaîne vide
            txbWorldNameEdit.Text = regex.Replace(txbWorldNameEdit.Text, "");

            // Supprimer les espaces en première et dernière position
            txbWorldNameEdit.Text = txbWorldNameEdit.Text.Trim();

            // Positionner le curseur à la fin du texte
            txbWorldNameEdit.SelectionStart = txbWorldNameEdit.Text.Length;
        }

        private void txbDatapackNew_TextChanged(object sender, EventArgs e)
        {
            // Créer une expression régulière qui correspond à tout ce qui n'est pas une lettre, un nombre, un espace, un point ou un underscore
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^a-z0-9_]");

            // Utiliser l'expression régulière pour remplacer les caractères non désirés par une chaîne vide
            txbDatapackNew.Text = regex.Replace(txbDatapackNew.Text, "");

            // Positionner le curseur à la fin du texte
            txbDatapackNew.SelectionStart = txbDatapackNew.Text.Length;
        }

        private void GenerateDtapack(object sender, EventArgs e)
        {
            if (txbDatapackNew.Text.Length < 1)
            {
                MessageBox.Show(Traduction.TranslateByCode("WorldEditor.ErrorEmptyName"));
            }
            string datapackFolder = Path.Combine(Application.StartupPath, worldname, "datapacks", txbDatapackNew.Text);
            try
            {
                Directory.CreateDirectory(datapackFolder);
            }
            catch {
                MessageBox.Show(Traduction.TranslateByCode("Error.DirAlreadyExist", datapackFolder));
                return;
            }

            Directory.CreateDirectory(Path.Combine(datapackFolder, "data"));
            string mcmeta = $@"{{
  ""pack"": {{
    ""pack_format"": 41,
    ""description"": ""{Traduction.TranslateByCode("WorldEditor.DatapackGeneratedDesc")}""
  }}
}}";
            File.WriteAllText(Path.Combine(datapackFolder, "pack.mcmeta"), mcmeta);

            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text));


            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "dimension"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "dimension_type"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "tags"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "loot_tables"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "loot_tables", "entities"));
            
            
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "tags", "functions"));
            string loadjson = $@"{{
 ""values"": [
 ""{txbDatapackNew.Text}:load""
 ]
}}";
            string tickjson = $@"{{
 ""values"": [
 ""{txbDatapackNew.Text}:loop""
 ]
}}";
            File.WriteAllText(Path.Combine(datapackFolder, "data", "minecraft", "tags", "functions", "load.json"), loadjson);
            File.WriteAllText(Path.Combine(datapackFolder, "data", "minecraft", "tags", "functions", "tick.json"), tickjson);


            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "biome"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "configured_carver"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "configured_feature"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "density_function"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "flat_level_generator_preset"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "noise"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "noise_settings"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "placed_feature"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "processor_list"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "structure"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "structure_set"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "template_pool"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", "minecraft", "worldgen", "world_preset"));


            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "block_predicate"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "dimension"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "functions"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "advancements"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "recipes"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "loot_tables"));

            File.WriteAllText(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "functions", "load.mcfunction"), $"# {Traduction.TranslateByCode("WorldEditor.DatapackCommentLoad")}");
            File.WriteAllText(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "functions", "loop.mcfunction"), $"# {Traduction.TranslateByCode("WorldEditor.DatapackCommentTick")}");


            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen"));

            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "biome"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "biome_source"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "chunk_generator"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "configured_carver"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "configured_feature"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "density_function"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "flat_level_generator_preset"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "noise"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "noise_settings"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "placed_feature"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "placement_modifier"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "processor_list"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "structure"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "structure_set"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "template_pool"));
            Directory.CreateDirectory(Path.Combine(datapackFolder, "data", txbDatapackNew.Text, "worldgen", "world_preset"));

            MessageBox.Show(Traduction.TranslateByCode("Common.Success"));
            loadData();
        }
    }
}
