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
using PS3Lib;
using LogIn_Theme_Dll_By_xVenoxi;
using System.Net;

namespace ToolAW
{
    public partial class Tool_AW : Form
    {
        private static PS3API PS3 = new PS3API();
        string VersionActuelle = "1.4";
        public Tool_AW()
        {
            InitializeComponent();
        }
        public class Stats
        {
            public static UInt32
                EntryStats = 0x2AB9BE8,
                AWPrestige = EntryStats + 0x0D,
                AWLevel = EntryStats + 0xA9,
                AWScore = EntryStats + 0xE6,
                AWKills = EntryStats + 0xBD,
                AWDeaths = EntryStats + 0x95,
                AWAccuracy = EntryStats + 0x51,
                AWWins = EntryStats + 0x112,
                AWLosses = EntryStats + 0xC5,
                AWGamePlayed = EntryStats + 0xAD,
                AWTimePlayed = EntryStats + 0x102,
                AWUnlockAll = EntryStats + 0x5834,
                AWClassName = EntryStats + 0x4DE9,
                AWClasse1 = AWClassName,
                AWClasse2 = AWClasse1 + 0x80,
                AWClasse3 = AWClasse2 + 0x80,
                AWClasse4 = AWClasse3 + 0x80,
                AWClasse5 = AWClasse4 + 0x80,
                AWClasse6 = AWClasse5 + 0x80,
                AWClasse7 = AWClasse6 + 0x80,
                AWClasse8 = AWClasse7 + 0x80,
                AWClasse9 = AWClasse8 + 0x80,
                AWClasse10 = AWClasse9 + 0x80,
                AWName = 0x2A53268;
        }

        //pour déplacer la form en cliquant dessus
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void CheckUpdates()
        {
            WebClient MAJ = new WebClient();
            string DernireVersion = MAJ.DownloadString("http://oasixftw.fr/tools/AW/version.txt");

            if (VersionActuelle == DernireVersion)
            {
                
            }
            else
            {
                TabAW.Enabled = false;
                DownloadUpdate DownloadUpdate = new DownloadUpdate();
                DownloadUpdate.Show();
            }
        }

        private void Tool_AW_Load(object sender, EventArgs e)
        {
            CheckUpdates();

            PubLauncher PubLauncher = new PubLauncher();
            PubLauncher.Show();

            RadioCCAPI.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous trouverez sur mon site web (lien dans l'onglet EBOOT de ce tool) un EBOOT anti-ban pour Advanced Warfare. /nVisit my website (oasixftw.fr/eboot.html) and download the EBOOT Antiban for AW.", "Vous voulez un anti-ban ?", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                labelConnect.ForeColor = System.Drawing.Color.Green;
                this.labelConnect.Text = "Connected";
                progressBar1.Value = 50;
            }
            else
            {
                MessageBox.Show("Impossible de se connecter. \nFailed to connect.", "Erreur.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                labelConnect.ForeColor = System.Drawing.Color.Green;
                this.labelConnect.Text = "Connected and Attached";
                progressBar1.Value = 100;

                //name
                this.textBox24.Text = PS3.Extension.ReadString(Stats.AWName);
                Classe1.Text = "^1" + (textBox24.Text);
                Classe2.Text = "^2" + (textBox24.Text);
                Classe3.Text = "^3" + (textBox24.Text);
                Classe4.Text = "^4" + (textBox24.Text);
                Classe5.Text = "^5" + (textBox24.Text);
                Classe6.Text = "^6" + (textBox24.Text);
                Classe7.Text = "^7" + (textBox24.Text);
                Classe8.Text = "^1" + (textBox24.Text);
                Classe9.Text = "^2" + (textBox24.Text);
                Classe10.Text = "^3" + (textBox24.Text);
            }
            else
            {
                MessageBox.Show("Aucun jeux trouvé. (Ou alors vous n'avez pas encore connecté la console) \nNo Game process found ! (Or not connected)", "Erreur.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioCCAPI_CheckedChanged(object sender)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void logInRadioButton2_CheckedChanged(object sender)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("skype:oasixftw?add");
            }
            catch { }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/OasixLobbyy");
            }
            catch { }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://realitygaming.fr/members/rmk-oasix.150116/");
            }
            catch { }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://twitter.com/OasixFTW");
            }
            catch { }
        }

        private void logInButton16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pour débloquer les armes elites, vous devez mettre le compte prestige 30, lancer une partie puis la quitter. Les armes seront alors débloquées, vous n'aurez plus qu'à remettre le compte à l'ancien prestige ! (Les armes et autres équipements du prestige 30 resteront débloqués). Il n'y a aucun risque de bannisement/reset, à condition de remettre l'ancien prestige dès que les armes sont débloquées. /nTo unlock elites weapons, do this : Go to prestige 30, play 1 minute and go back to menu. Go to the old prestige !", "Débloquer les armes elites / Unlock elites weapons", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void logInButton2_Click(object sender, EventArgs e)
        {
            if (checkPRESTIGE.Checked)
            {
                byte[] bytes = BitConverter.GetBytes((int)this.logInNumericPRESTIGE.Value);
                PS3.SetMemory((uint)Stats.AWPrestige, bytes); //Prestige
            }

            if (checkWINS.Checked)
            {
                byte[] buffer289 = BitConverter.GetBytes((int)this.logInNumericWINS.Value);
                PS3.SetMemory((uint)Stats.AWWins, buffer289); //Wins
            }
            if (checkLOSSES.Checked)
            {
                byte[] buffer3 = BitConverter.GetBytes((int)this.logInNumericLOSSES.Value);
                PS3.SetMemory((uint)Stats.AWLosses, buffer3); //Losses
            }
            if (checkKILLS.Checked)
            {
                byte[] buffer4 = BitConverter.GetBytes((int)this.logInNumericKILLS.Value);
                PS3.SetMemory((uint)Stats.AWKills, buffer4); //Kills
            }
            if (checkDEATHS.Checked)
            {
                byte[] buffer5 = BitConverter.GetBytes((int)this.logInNumericDEATHS.Value);
                PS3.SetMemory((uint)Stats.AWDeaths, buffer5); //Deaths
            }
            if (checkSCORE.Checked)
            {
                byte[] buffer6 = BitConverter.GetBytes((int)this.logInNumericSCORE.Value);
                PS3.SetMemory((uint)Stats.AWScore, buffer6); //Score
            }
            if (checkGP.Checked)
            {
                byte[] buffer7 = BitConverter.GetBytes((int)this.logInNumericGAMESPLAYED.Value);
                PS3.SetMemory((uint)Stats.AWGamePlayed, buffer7); //Games Played  
            }
            if (checkACC.Checked)
            {
                byte[] buffer8 = BitConverter.GetBytes((int)this.logInNumericACCURACY.Value);
                PS3.SetMemory((uint)Stats.AWAccuracy, buffer8); //Accuracy
            }

            //time played
            if (checkTIME.Checked)
            {
                decimal numday = 86400;
                decimal numhour = 3600;
                decimal numminute = 60;
                decimal numtotal = this.numDAY.Value * numday + this.numHOURS.Value * numhour + this.numMINUTES.Value * numminute;
                byte[] bytes36 = BitConverter.GetBytes(Convert.ToInt32(numtotal.ToString()));
                PS3.SetMemory(Stats.AWTimePlayed, bytes36);
            }

            if (logInCheckBoxLVL50.Checked)
            {
                PS3.SetMemory((uint)Stats.AWLevel, new byte[] { 0x1a, 0x4e, 0xd4, 3 });
            }
        }

        private void logInCheckBoxLVL50_CheckedChanged(object sender)
        {
            PS3.SetMemory((uint)Stats.AWLevel, new byte[] { 0x1a, 0x4e, 0xd4, 3 });
        }

        private void logInCheckBoxUNALL_CheckedChanged(object sender)
        {
            byte[] buffer = new byte[0x1770];
            for (int i = 0; i < 0x1770; i++)
            {
                buffer[i] = 0xfe;
            }
            PS3.SetMemory(Stats.AWUnlockAll, buffer);
        }

        private void logInButton3_Click(object sender, EventArgs e)
        {
            logInNumericSCORE.Value = 3240000; //Score
            this.labelSPM.Text = "90";
            logInNumericWINS.Value = 7000; //Wins    
            logInNumericLOSSES.Value = 20000; //Losses
            this.labelRatioWL.Text = "0,35";
            logInNumericKILLS.Value = 30000; //Kills
            logInNumericDEATHS.Value = 100000; //Deaths
            this.labelRatioKD.Text = "0,30";

            numDAY.Value = 25; //Time Played : days
            numHOURS.Value = 0; //Time Played : hours
            numMINUTES.Value = 0; //Time Played : minutes

            checkSCORE.Checked = true;
            checkWINS.Checked = true;
            checkLOSSES.Checked = true;
            checkKILLS.Checked = true;
            checkDEATHS.Checked = true;
            checkTIME.Checked = true;
            checkGP.Checked = true;

            logInNumericGAMESPLAYED.Value = logInNumericWINS.Value + logInNumericLOSSES.Value;
        }

        private void logInButton5_Click(object sender, EventArgs e)
        {
            logInNumericSCORE.Value = 12584736; //Score
            this.labelSPM.Text = "310";
            logInNumericWINS.Value = 4874; //Wins    
            logInNumericLOSSES.Value = 3019; //Losses
            this.labelRatioWL.Text = "1,60";
            logInNumericKILLS.Value = 116840; //Kills
            logInNumericDEATHS.Value = 76235; //Deaths
            this.labelRatioKD.Text = "1,53";
            logInNumericPRESTIGE.Value = 15; //Prestige

            numDAY.Value = 28; //Time Played : days
            numHOURS.Value = 4; //Time Played : hours
            numMINUTES.Value = 1; //Time Played : minutes

            logInCheckBoxLVL50.Checked = true; //Level 50

            logInNumericGAMESPLAYED.Value = logInNumericWINS.Value + logInNumericLOSSES.Value;

            checkSCORE.Checked = true;
            checkPRESTIGE.Checked = true;
            checkWINS.Checked = true;
            checkLOSSES.Checked = true;
            checkKILLS.Checked = true;
            checkDEATHS.Checked = true;
            checkTIME.Checked = true;
            checkGP.Checked = true;
        }

        private void logInButton6_Click(object sender, EventArgs e)
        {
            logInNumericSCORE.Value = 44046576; //Score
            this.labelSPM.Text = "1085";
            logInNumericWINS.Value = 17059; //Wins    
            logInNumericLOSSES.Value = 6038; //Losses
            this.labelRatioWL.Text = "2,83";
            logInNumericKILLS.Value = 408940; //Kills
            logInNumericDEATHS.Value = 152470; //Deaths
            this.labelRatioKD.Text = "2,68";
            logInNumericPRESTIGE.Value = 15; //Prestige

            numDAY.Value = 28; //Time Played : days
            numHOURS.Value = 4; //Time Played : hours
            numMINUTES.Value = 1; //Time Played : minutes

            logInCheckBoxLVL50.Checked = true; //Level 50

            logInNumericGAMESPLAYED.Value = logInNumericWINS.Value + logInNumericLOSSES.Value;

            checkSCORE.Checked = true;
            checkPRESTIGE.Checked = true;
            checkWINS.Checked = true;
            checkLOSSES.Checked = true;
            checkKILLS.Checked = true;
            checkDEATHS.Checked = true;
            checkTIME.Checked = true;
            checkGP.Checked = true;
        }

        private void logInButton8_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(Stats.AWClasse1, Classe1.Text);
            PS3.Extension.WriteString(Stats.AWClasse2, Classe2.Text);
            PS3.Extension.WriteString(Stats.AWClasse3, Classe3.Text);
            PS3.Extension.WriteString(Stats.AWClasse4, Classe4.Text);
            PS3.Extension.WriteString(Stats.AWClasse5, Classe5.Text);
            PS3.Extension.WriteString(Stats.AWClasse6, Classe6.Text);
            PS3.Extension.WriteString(Stats.AWClasse7, Classe7.Text);
            PS3.Extension.WriteString(Stats.AWClasse8, Classe8.Text);
            PS3.Extension.WriteString(Stats.AWClasse9, Classe9.Text);
            PS3.Extension.WriteString(Stats.AWClasse10, Classe10.Text);
        }

        private void logInButton9_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(Stats.AWName, logInNormalTextBox1.Text);
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroToggle1.Checked)
            {
                byte[] ON = new byte[] { 0x2C, 0x03, 0x00, 0x01 };
                PS3.SetMemory(0x1AF110, ON);
            }
            else
            {
                byte[] OFF = new byte[] { 0x2C, 0x03, 0x00, 0x00 };
                PS3.SetMemory(0x1AF110, OFF);
            }
        }

        private void metroToggle2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroToggle2.Checked)
            {
                byte[] ON = new byte[] { 0x6B, 0x18, 0x00, 0x00 };
                PS3.SetMemory(0x1A6A98, ON);
            }
            else
            {
                byte[] OFF = new byte[] { 0x6B, 0x18, 0x00, 0x01 };
                PS3.SetMemory(0x1A6A98, OFF);
            }
        }

        private void metroToggle3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroToggle3.Checked)
            {
                byte[] ON = new byte[] { 0x2C, 0x12, 0x00, 0x01 };
                PS3.SetMemory(0x21B6B4, ON);
            }
            else
            {
                byte[] OFF = new byte[] { 0x2C, 0x12, 0x00, 0x00 };
                PS3.SetMemory(0x21B6B4, OFF);
            }
        }

        private void metroToggle4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroToggle4.Checked)
            {
                byte[] ON = new byte[] { 0x2C, 0x83, 0x00, 0x00 };
                PS3.SetMemory(0x187294, ON);
            }
            else
            {
                byte[] OFF = new byte[] { 0x2C, 0x83, 0x00, 0x02 };
                PS3.SetMemory(0x187294, OFF);
            }
        }

        private void metroToggle5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroToggle5.Checked)
            {
                byte[] ON = new byte[] { 0x60, 0x00, 0x00, 0x00 };
                PS3.SetMemory(0x228930, ON);
            }
            else
            {
                /*byte[] OFF = new byte[] { 0x4B, 0xF5, 0xE2, 0x01 };
                PS3.SetMemory(0x228930, OFF);*/
                MessageBox.Show("Il est impossible de désactiver ce mods une fois activé, sous peine de freez. \nIt's not possible to unable this cheat.", "Erreur.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroToggle6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroToggle6.Checked)
            {
                byte[] ON = new byte[] { 0x2C, 0x03, 0x00, 0x01 };
                PS3.SetMemory(0x60087C, ON);
            }
            else
            {
                byte[] OFF = new byte[] { 0x2C, 0x03, 0x00, 0x00 };
                PS3.SetMemory(0x60087C, OFF);
            }
        }

        private void metroToggle8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.metroToggle8.Checked)
            {
                byte[] ON = new byte[] { 0x38, 0xC0, 0x00, 0x09 };
                PS3.SetMemory(0x1DDBD0, ON);
            }
            else
            {
                byte[] OFF = new byte[] { 0x63, 0xE6, 0x00, 0x00 };
                PS3.SetMemory(0x1DDBD0, OFF);
            }
        }

        private void logInButton1_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0xE17CC6, textBoxCLANTAG.Text);
        }

        private void logInButton7_Click(object sender, EventArgs e)
        {
            Classe1.Text = "^1" + (textBox24.Text);
            Classe2.Text = "^2" + (textBox24.Text);
            Classe3.Text = "^3" + (textBox24.Text);
            Classe4.Text = "^4" + (textBox24.Text);
            Classe5.Text = "^5" + (textBox24.Text);
            Classe6.Text = "^6" + (textBox24.Text);
            Classe7.Text = "^7" + (textBox24.Text);
            Classe8.Text = "^1" + (textBox24.Text);
            Classe9.Text = "^2" + (textBox24.Text);
            Classe10.Text = "^3" + (textBox24.Text);
        }

        private void logInButton12_Click(object sender, EventArgs e)
        {
            //pre-set stats
            logInNumericSCOREFL.Value = 12584736; //Score
            logInNumericWINSFL.Value = 4874; //Wins    
            logInNumericLOSSESFL.Value = 3019; //Losses
            logInNumericKILLSFL.Value = 116840; //Kills
            logInNumericDEATHSFL.Value = 76235; //Deaths
            logInNumericPRESTIGEFL.Value = 15; //Prestige
            logInNumericGPFL.Value = logInNumericWINSFL.Value + logInNumericLOSSESFL.Value;

            logInNumericTIMEDAYFL.Value = 28; //Time Played : days
            logInNumericTIMEHFL.Value = 4; //Time Played : hours
            logInNumericTIMEMINFL.Value = 1; //Time Played : minutes


                byte[] bytes = BitConverter.GetBytes((int)this.logInNumericPRESTIGEFL.Value);
                PS3.SetMemory((uint)Stats.AWPrestige, bytes); //Prestige

                byte[] buffer289 = BitConverter.GetBytes((int)this.logInNumericWINSFL.Value);
                PS3.SetMemory((uint)Stats.AWWins, buffer289); //Wins

                byte[] buffer3 = BitConverter.GetBytes((int)this.logInNumericLOSSESFL.Value);
                PS3.SetMemory((uint)Stats.AWLosses, buffer3); //Losses

                byte[] buffer4 = BitConverter.GetBytes((int)this.logInNumericKILLSFL.Value);
                PS3.SetMemory((uint)Stats.AWKills, buffer4); //Kills

                byte[] buffer5 = BitConverter.GetBytes((int)this.logInNumericDEATHSFL.Value);
                PS3.SetMemory((uint)Stats.AWDeaths, buffer5); //Deaths

                byte[] buffer6 = BitConverter.GetBytes((int)this.logInNumericSCOREFL.Value);
                PS3.SetMemory((uint)Stats.AWScore, buffer6); //Score

                byte[] buffer7 = BitConverter.GetBytes((int)this.logInNumericGPFL.Value);
                PS3.SetMemory((uint)Stats.AWGamePlayed, buffer7); //Games Played  
            
                decimal numday = 86400;
                decimal numhour = 3600;
                decimal numminute = 60;
                decimal numtotal = this.logInNumericTIMEDAYFL.Value * numday + this.logInNumericTIMEHFL.Value * numhour + this.logInNumericTIMEMINFL.Value * numminute;
                byte[] bytes36 = BitConverter.GetBytes(Convert.ToInt32(numtotal.ToString()));
                PS3.SetMemory(Stats.AWTimePlayed, bytes36);
            

            
                PS3.SetMemory((uint)Stats.AWLevel, new byte[] { 0x1a, 0x4e, 0xd4, 3 }); //level

                //unlock all
                byte[] buffer = new byte[0x1770];
                for (int i = 0; i < 0x1770; i++)
                {
                    buffer[i] = 0xfe;
                }
                PS3.SetMemory(Stats.AWUnlockAll, buffer);

                //classes
                PS3.Extension.WriteString(Stats.AWClasse1, "^1" + Classe1.Text);
                PS3.Extension.WriteString(Stats.AWClasse2, "^2" + Classe2.Text);
                PS3.Extension.WriteString(Stats.AWClasse3, "^3" + Classe3.Text);
                PS3.Extension.WriteString(Stats.AWClasse4, "^4" + Classe4.Text);
                PS3.Extension.WriteString(Stats.AWClasse5, "^5" + Classe5.Text);
                PS3.Extension.WriteString(Stats.AWClasse6, "^6" + Classe6.Text);
                PS3.Extension.WriteString(Stats.AWClasse7, "^7" + Classe7.Text);
                PS3.Extension.WriteString(Stats.AWClasse8, "^8" + Classe8.Text);
                PS3.Extension.WriteString(Stats.AWClasse9, "^1" + Classe9.Text);
                PS3.Extension.WriteString(Stats.AWClasse10, "^2" + Classe10.Text);
        }

        private void logInButton11_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://oasixftw.fr/eboot.html");
            }
            catch { }
        }

        private void logInButton77_Click(object sender, EventArgs e)
        {
            /*Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();*/
        }

        private void logInButton4_Click(object sender, EventArgs e)
        {
            //Score
            byte[] buffer1 = new byte[16];
            PS3.GetMemory(Stats.AWScore, buffer1);
            this.logInNumericSCORE.Value = (long)BitConverter.ToInt32(buffer1, 0);

            //Prestige
            byte[] buffer2 = new byte[16];
            PS3.GetMemory(Stats.AWPrestige, buffer2);
            this.logInNumericPRESTIGE.Value = (long)BitConverter.ToInt32(buffer2, 0);

            //Wins
            byte[] buffer21 = new byte[16];
            PS3.GetMemory(Stats.AWWins, buffer21);
            this.logInNumericWINS.Value = (long)BitConverter.ToInt32(buffer21, 0);

            //Losses
            byte[] buffer22 = new byte[16];
            PS3.GetMemory(Stats.AWLosses, buffer22);
            this.logInNumericLOSSES.Value = (long)BitConverter.ToInt32(buffer22, 0);

            //Kills
            byte[] buffer23 = new byte[16];
            PS3.GetMemory(Stats.AWKills, buffer23);
            this.logInNumericKILLS.Value = (long)BitConverter.ToInt32(buffer23, 0);

            //Deaths
            byte[] buffer24 = new byte[16];
            PS3.GetMemory(Stats.AWDeaths, buffer24);
            this.logInNumericDEATHS.Value = (long)BitConverter.ToInt32(buffer24, 0);

            //GamesPlayed
            byte[] buffer25 = new byte[16];
            PS3.GetMemory(Stats.AWGamePlayed, buffer25);
            this.logInNumericGAMESPLAYED.Value = (long)BitConverter.ToInt32(buffer25, 0);

            //Accuracy
            byte[] buffer285 = new byte[16];
            PS3.GetMemory(Stats.AWAccuracy, buffer285);
            this.logInNumericACCURACY.Value = (long)BitConverter.ToInt32(buffer285, 0);


            //time played
            byte[] buffer13 = new byte[4];
            PS3.GetMemory(Stats.AWTimePlayed, buffer13);
            int num = BitConverter.ToInt32(buffer13, 0);
            int num2 = ((num / 60) / 60) / 0x18;
            int num3 = ((num / 60) / 60) % 0x18;
            int num4 = (num / 60) % 60;
            this.numDAY.Value = num2;
            this.numHOURS.Value = num3;
            this.numMINUTES.Value = num4;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PubLauncher PubLauncher = new PubLauncher();
            PubLauncher.Show();
        }
    }
}
