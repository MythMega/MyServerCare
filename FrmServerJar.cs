using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCServCare
{
    public partial class FrmServerJar : Form
    {
        public FrmServerJar()
        {
            InitializeComponent();
        }


        public void redirectToDownload(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Text)
            {
                case "Vanilla":
                    Process.Start("https://serverjars.com/more/vanilla/vanilla");
                    break;
                case "Paper":
                    Process.Start("https://papermc.io/downloads/paper");
                    break;
                case "Vanilla Snapshot":
                    Process.Start("https://serverjars.com/more/vanilla/snapshot");
                    break;
                case "Spigot":
                    Process.Start("https://getbukkit.org/download/spigot");
                    break;
                case "Forge":
                    Process.Start("https://serverjars.com/more/modded/forge");
                    break;
                case "Purpur":
                    Process.Start("https://serverjars.com/more/servers/purpur");
                    break;
                case "Fabric":
                    Process.Start("https://serverjars.com/more/modded/fabric");
                    break;
                case "Sponge":
                    Process.Start("https://serverjars.com/more/servers/sponge");
                    break;
                case "Mohist":
                    Process.Start("https://serverjars.com/more/modded/mohist");
                    break;
                case "PocketMine":
                    Process.Start("https://serverjars.com/more/bedrock/pocketmine");
                    break;
            }
            this.Close();
        }

        public void setTextAndColor(Color background, string v)
        {
            this.BackColor = background;
            label1.Text = v;
        }
    }
}
