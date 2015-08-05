namespace ToolAW
{
    partial class PubLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PubLauncher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEN = new MetroFramework.Controls.MetroRadioButton();
            this.buttonFR = new MetroFramework.Controls.MetroRadioButton();
            this.labelTITRE = new System.Windows.Forms.Label();
            this.labelDESCRIPTION = new System.Windows.Forms.Label();
            this.labelPASOBLIG = new System.Windows.Forms.Label();
            this.buttonLIEN = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ToolAW.Properties.Resources.logocod;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEN
            // 
            this.buttonEN.AutoSize = true;
            this.buttonEN.CustomBackground = false;
            this.buttonEN.CustomForeColor = false;
            this.buttonEN.FontSize = MetroFramework.MetroLinkSize.Small;
            this.buttonEN.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.buttonEN.Location = new System.Drawing.Point(183, 304);
            this.buttonEN.Name = "buttonEN";
            this.buttonEN.Size = new System.Drawing.Size(61, 15);
            this.buttonEN.Style = MetroFramework.MetroColorStyle.Blue;
            this.buttonEN.StyleManager = null;
            this.buttonEN.TabIndex = 11;
            this.buttonEN.TabStop = true;
            this.buttonEN.Text = "English";
            this.buttonEN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonEN.UseStyleColors = false;
            this.buttonEN.UseVisualStyleBackColor = true;
            this.buttonEN.CheckedChanged += new System.EventHandler(this.buttonEN_CheckedChanged);
            // 
            // buttonFR
            // 
            this.buttonFR.AutoSize = true;
            this.buttonFR.CustomBackground = false;
            this.buttonFR.CustomForeColor = false;
            this.buttonFR.FontSize = MetroFramework.MetroLinkSize.Small;
            this.buttonFR.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.buttonFR.Location = new System.Drawing.Point(109, 304);
            this.buttonFR.Name = "buttonFR";
            this.buttonFR.Size = new System.Drawing.Size(66, 15);
            this.buttonFR.Style = MetroFramework.MetroColorStyle.Blue;
            this.buttonFR.StyleManager = null;
            this.buttonFR.TabIndex = 10;
            this.buttonFR.TabStop = true;
            this.buttonFR.Text = "Français";
            this.buttonFR.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonFR.UseStyleColors = false;
            this.buttonFR.UseVisualStyleBackColor = true;
            this.buttonFR.CheckedChanged += new System.EventHandler(this.buttonFR_CheckedChanged);
            // 
            // labelTITRE
            // 
            this.labelTITRE.AutoSize = true;
            this.labelTITRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTITRE.Location = new System.Drawing.Point(35, 82);
            this.labelTITRE.Name = "labelTITRE";
            this.labelTITRE.Size = new System.Drawing.Size(282, 24);
            this.labelTITRE.TabIndex = 12;
            this.labelTITRE.Text = "Besoin d\'un Launcher All COD ?";
            this.labelTITRE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDESCRIPTION
            // 
            this.labelDESCRIPTION.AutoSize = true;
            this.labelDESCRIPTION.Location = new System.Drawing.Point(14, 117);
            this.labelDESCRIPTION.Name = "labelDESCRIPTION";
            this.labelDESCRIPTION.Size = new System.Drawing.Size(325, 78);
            this.labelDESCRIPTION.TabIndex = 13;
            this.labelDESCRIPTION.Text = resources.GetString("labelDESCRIPTION.Text");
            this.labelDESCRIPTION.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPASOBLIG
            // 
            this.labelPASOBLIG.AutoSize = true;
            this.labelPASOBLIG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPASOBLIG.Location = new System.Drawing.Point(13, 263);
            this.labelPASOBLIG.Name = "labelPASOBLIG";
            this.labelPASOBLIG.Size = new System.Drawing.Size(331, 26);
            this.labelPASOBLIG.TabIndex = 14;
            this.labelPASOBLIG.Text = "L\'achat du launcher n\'est pas obligatoire, vous pouvez utiliser ce tool\r\nsans ach" +
    "eter le launcher.";
            // 
            // buttonLIEN
            // 
            this.buttonLIEN.Highlight = false;
            this.buttonLIEN.Location = new System.Drawing.Point(17, 215);
            this.buttonLIEN.Name = "buttonLIEN";
            this.buttonLIEN.Size = new System.Drawing.Size(322, 45);
            this.buttonLIEN.Style = MetroFramework.MetroColorStyle.Blue;
            this.buttonLIEN.StyleManager = null;
            this.buttonLIEN.TabIndex = 15;
            this.buttonLIEN.Text = "Obtenir le launcher";
            this.buttonLIEN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonLIEN.Click += new System.EventHandler(this.buttonCONNECT_Click);
            // 
            // PubLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(353, 327);
            this.Controls.Add(this.buttonLIEN);
            this.Controls.Add(this.labelPASOBLIG);
            this.Controls.Add(this.labelDESCRIPTION);
            this.Controls.Add(this.labelTITRE);
            this.Controls.Add(this.buttonEN);
            this.Controls.Add(this.buttonFR);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 366);
            this.MinimumSize = new System.Drawing.Size(369, 366);
            this.Name = "PubLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Besoin d\'un launcher all COD ?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PubLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroRadioButton buttonEN;
        private MetroFramework.Controls.MetroRadioButton buttonFR;
        private System.Windows.Forms.Label labelTITRE;
        private System.Windows.Forms.Label labelDESCRIPTION;
        private System.Windows.Forms.Label labelPASOBLIG;
        private MetroFramework.Controls.MetroButton buttonLIEN;
    }
}