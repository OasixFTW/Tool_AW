using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ToolAW
{
    public partial class PubLauncher : Form
    {
        public PubLauncher()
        {
            InitializeComponent();
        }

        private void PubLauncher_Load(object sender, EventArgs e)
        {
            buttonFR.Checked = true;
        }

        private void buttonCONNECT_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://tool.oasixftw.fr");
            }
            catch { }
        }

        private void buttonEN_CheckedChanged(object sender, EventArgs e)
        {
            labelTITRE.Text = "   Need a Launcher All COD ?";
            labelDESCRIPTION.Text = "My launcher All COD contain a tool for all Call Of Duty ! \nWith my launcher you can cheat on all COD, \njust with one tool ! \nClick on the button ''Get the launcher'' to discover screenshots.";
            buttonLIEN.Text = "Get the launcher";
            labelPASOBLIG.Text = "You are not forced to buy my launcher to use this tool.";
        }

        private void buttonFR_CheckedChanged(object sender, EventArgs e)
        {
            labelTITRE.Text = "Besoin d'un Launcher All COD ?";
            labelDESCRIPTION.Text = "Mon launcher All COD comprend un tool pour chaque Call Of Duty ! \nVous pourrez donc faire des lobbys et tricher sur tous les COD, \navec un seul gros tool ! \nJe vous invite à cliquez sur le bouton ci dessous afin de \ndécouvrir des captures d'écrans du launcher.";
            buttonLIEN.Text = "Obtenir le launcher";
            labelPASOBLIG.Text = "L'achat du launcher n'est pas obligatoire, vous pouvez utiliser ce tool \nsans acheter le launcher.";
        }
    }
}
/*
Besoin d'un Launcher All COD ?
 L'achat du launcher n'est pas obligatoire, vous pouvez utiliser ce tool
sans acheter le launcher.
 * 
 * 
Mon launcher All COD comprend un tool pour chaque Call Of Duty !
Vous pourrez donc faire des lobbys et tricher sur tous les COD, 
avec un seul gros tool ! 

Je vous invite à cliquez sur le bouton ci dessous afin de
découvrir des captures d'écrans du launcher.
*/