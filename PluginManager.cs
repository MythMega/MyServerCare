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
    public partial class PluginManager : Form
    {
        public bool charged = false;

        private Color background = Color.FromArgb(255, 36, 36, 44);
        private Color deeperBackground = Color.FromArgb(255, 27, 27, 33);
        private Color orangeTextColor = Color.Orange;

        public PluginManager()
        {
            InitializeComponent();
            lvPluginList.BackColor = deeperBackground;
            lvPluginList.ForeColor = orangeTextColor;
            this.BackColor = background;
            this.ForeColor = orangeTextColor;
            btnClose.BackColor = background;
            btnSelectAll.BackColor = background;
            btnUnselectAll.BackColor = background;
            btnClose.ForeColor = orangeTextColor;
            btnSelectAll.ForeColor = orangeTextColor;
            btnUnselectAll.ForeColor = orangeTextColor;

            btnSelectAll.Text = Traduction.TranslateByCode("Common.SelectAll");
            btnUnselectAll.Text = Traduction.TranslateByCode("Common.UnselectAll");
            btnClose.Text = Traduction.TranslateByCode("Common.Close");
        }

        private void load(object sender, EventArgs e)
        {
            lvPluginList.Items.Clear();
            charged = false; 
            // Obtenez le répertoire de l'application
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Spécifiez le chemin du dossier des plugins
            string pluginsDirectory = Path.Combine(appDirectory, "plugins");

            // Assurez-vous que le répertoire existe
            if (Directory.Exists(pluginsDirectory))
            {
                // Obtenez tous les fichiers dans le répertoire des plugins
                string[] files = Directory.GetFiles(pluginsDirectory);

                // Parcourez chaque fichier
                foreach (string file in files)
                {
                    // Obtenez l'extension du fichier
                    string extension = Path.GetExtension(file);

                    // Créez un nouvel élément de liste avec le nom du fichier
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));

                    // Vérifiez l'extension du fichier
                    if (extension == ".jar")
                    {
                        // Si c'est un fichier .jar, cochez la case
                        item.Checked = true;
                    }
                    else if (extension == ".disabled")
                    {
                        // Si c'est un fichier .disabled, ne cochez pas la case
                        item.Checked = false;
                    }
                    else
                    {
                        // Ignorez les autres fichiers
                        continue;
                    }

                    // Ajoutez l'élément à la liste
                    lvPluginList.Items.Add(item);
                }
            }
            charged = true;
        }

        private void lvPluginList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if(charged)
            {
                // Obtenez le répertoire de l'application
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Spécifiez le chemin du dossier des plugins
            string pluginsDirectory = Path.Combine(appDirectory, "plugins");

            // Obtenez le nom du fichier
            string fileName = e.Item.Text;

            // Obtenez le chemin complet du fichier
            string filePath = Path.Combine(pluginsDirectory, fileName);

            // Vérifiez si l'élément est coché
            if (e.Item.Checked)
            {
                // Si l'élément est coché, changez l'extension en .jar
                string newFilePath = Path.ChangeExtension(filePath, ".jar");

                // Renommez le fichier
                if (File.Exists(filePath))
                {
                    File.Move(filePath, newFilePath);
                }
            }
            else
            {
                // Si l'élément n'est pas coché, changez l'extension en .disabled
                string newFilePath = Path.ChangeExtension(filePath, ".disabled");

                // Renommez le fichier
                if (File.Exists(filePath))
                {
                    File.Move(filePath, newFilePath);
                }
            }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPluginList.Items)
            {
                item.Checked = true;
            }
            load(null, null);
        }
        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPluginList.Items)
            {
                item.Checked = false;
            }
            load(null, null);
        }
    }
}
