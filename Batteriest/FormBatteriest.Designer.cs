namespace Batteriest
{
    partial class Batteriest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batteriest));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.labelApp = new System.Windows.Forms.Label();
            this.panelApp = new System.Windows.Forms.Panel();
            this.roundedHideButton = new RoundedRectangleButton.RoundedRectangleButton();
            this.roundedCloseButton = new RoundedRectangleButton.RoundedRectangleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedHideApp = new RoundedRectangleButton.RoundedRectangleButton();
            this.raundedCloseApp = new RoundedRectangleButton.RoundedRectangleButton();
            this.labelForm = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelSplitter = new System.Windows.Forms.Panel();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboSerialBox = new System.Windows.Forms.ComboBox();
            this.roundedDisconnectSerial = new RoundedRectangleButton.RoundedRectangleButton();
            this.roundedConnectSerial = new RoundedRectangleButton.RoundedRectangleButton();
            this.pictureApp = new System.Windows.Forms.PictureBox();
            this.buttonRCEstimate = new System.Windows.Forms.Button();
            this.buttonAgingTest = new System.Windows.Forms.Button();
            this.buttonHarmonic = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAboutUs = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.panelNavigation);
            this.panelMenu.Controls.Add(this.buttonRCEstimate);
            this.panelMenu.Controls.Add(this.buttonAgingTest);
            this.panelMenu.Controls.Add(this.buttonHarmonic);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonAboutUs);
            this.panelMenu.Controls.Add(this.labelApp);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(192, 540);
            this.panelMenu.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNavigation.Location = new System.Drawing.Point(0, 236);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(5, 304);
            this.panelNavigation.TabIndex = 2;
            // 
            // labelApp
            // 
            this.labelApp.AutoSize = true;
            this.labelApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelApp.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labelApp.Location = new System.Drawing.Point(22, 178);
            this.labelApp.Name = "labelApp";
            this.labelApp.Size = new System.Drawing.Size(152, 36);
            this.labelApp.TabIndex = 3;
            this.labelApp.Text = "Batteriest";
            this.labelApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelApp
            // 
            this.panelApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelApp.BackColor = System.Drawing.Color.Black;
            this.panelApp.Controls.Add(this.roundedHideButton);
            this.panelApp.Controls.Add(this.roundedCloseButton);
            this.panelApp.Controls.Add(this.label1);
            this.panelApp.Location = new System.Drawing.Point(0, 0);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(960, 27);
            this.panelApp.TabIndex = 3;
            this.panelApp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelApp_MouseDown);
            this.panelApp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelApp_MouseMove);
            this.panelApp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelApp_MouseUp);
            // 
            // roundedHideButton
            // 
            this.roundedHideButton.FlatAppearance.BorderSize = 0;
            this.roundedHideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedHideButton.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedHideButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.roundedHideButton.Location = new System.Drawing.Point(906, 0);
            this.roundedHideButton.Name = "roundedHideButton";
            this.roundedHideButton.Size = new System.Drawing.Size(27, 27);
            this.roundedHideButton.TabIndex = 0;
            this.roundedHideButton.Text = "_";
            this.roundedHideButton.UseVisualStyleBackColor = true;
            this.roundedHideButton.Click += new System.EventHandler(this.RoundedHideApp_Click);
            // 
            // roundedCloseButton
            // 
            this.roundedCloseButton.FlatAppearance.BorderSize = 0;
            this.roundedCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedCloseButton.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedCloseButton.ForeColor = System.Drawing.Color.Red;
            this.roundedCloseButton.Location = new System.Drawing.Point(933, 0);
            this.roundedCloseButton.Name = "roundedCloseButton";
            this.roundedCloseButton.Size = new System.Drawing.Size(27, 27);
            this.roundedCloseButton.TabIndex = 0;
            this.roundedCloseButton.Text = "x";
            this.roundedCloseButton.UseVisualStyleBackColor = true;
            this.roundedCloseButton.Click += new System.EventHandler(this.RoundedCloseApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Batteriest";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedHideApp
            // 
            this.roundedHideApp.BackColor = System.Drawing.Color.Black;
            this.roundedHideApp.FlatAppearance.BorderSize = 0;
            this.roundedHideApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedHideApp.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.roundedHideApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedHideApp.Location = new System.Drawing.Point(900, 0);
            this.roundedHideApp.Name = "roundedHideApp";
            this.roundedHideApp.Size = new System.Drawing.Size(27, 27);
            this.roundedHideApp.TabIndex = 0;
            this.roundedHideApp.Text = "_";
            this.roundedHideApp.UseVisualStyleBackColor = false;
            this.roundedHideApp.Click += new System.EventHandler(this.RoundedHideApp_Click);
            // 
            // raundedCloseApp
            // 
            this.raundedCloseApp.BackColor = System.Drawing.Color.Black;
            this.raundedCloseApp.FlatAppearance.BorderSize = 0;
            this.raundedCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raundedCloseApp.Font = new System.Drawing.Font("Britannic Bold", 11F);
            this.raundedCloseApp.ForeColor = System.Drawing.Color.Red;
            this.raundedCloseApp.Location = new System.Drawing.Point(933, 0);
            this.raundedCloseApp.Name = "raundedCloseApp";
            this.raundedCloseApp.Size = new System.Drawing.Size(27, 27);
            this.raundedCloseApp.TabIndex = 0;
            this.raundedCloseApp.Text = "x";
            this.raundedCloseApp.UseVisualStyleBackColor = false;
            this.raundedCloseApp.Click += new System.EventHandler(this.RoundedCloseApp_Click);
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelForm.Font = new System.Drawing.Font("Britannic Bold", 36F);
            this.labelForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labelForm.Location = new System.Drawing.Point(209, 44);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(209, 53);
            this.labelForm.TabIndex = 3;
            this.labelForm.Text = "About Us";
            this.labelForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(209, 113);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(734, 416);
            this.panelMain.TabIndex = 4;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // panelSplitter
            // 
            this.panelSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelSplitter.Location = new System.Drawing.Point(215, 102);
            this.panelSplitter.Name = "panelSplitter";
            this.panelSplitter.Size = new System.Drawing.Size(728, 5);
            this.panelSplitter.TabIndex = 5;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelPort.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.labelPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labelPort.Location = new System.Drawing.Point(713, 67);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(66, 25);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Port :";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboSerialBox
            // 
            this.comboSerialBox.AllowDrop = true;
            this.comboSerialBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.comboSerialBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSerialBox.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.comboSerialBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.comboSerialBox.FormattingEnabled = true;
            this.comboSerialBox.Location = new System.Drawing.Point(785, 60);
            this.comboSerialBox.Name = "comboSerialBox";
            this.comboSerialBox.Size = new System.Drawing.Size(93, 31);
            this.comboSerialBox.TabIndex = 0;
            this.comboSerialBox.DropDown += new System.EventHandler(this.ComboSerialBox_DropDown);
            // 
            // roundedDisconnectSerial
            // 
            this.roundedDisconnectSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.roundedDisconnectSerial.FlatAppearance.BorderSize = 0;
            this.roundedDisconnectSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedDisconnectSerial.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedDisconnectSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.roundedDisconnectSerial.Image = global::Batteriest.Properties.Resources.BTA___Close;
            this.roundedDisconnectSerial.Location = new System.Drawing.Point(917, 64);
            this.roundedDisconnectSerial.Name = "roundedDisconnectSerial";
            this.roundedDisconnectSerial.Size = new System.Drawing.Size(27, 27);
            this.roundedDisconnectSerial.TabIndex = 0;
            this.roundedDisconnectSerial.UseVisualStyleBackColor = false;
            this.roundedDisconnectSerial.Click += new System.EventHandler(this.RoundedDisconnectSerial_Click);
            // 
            // roundedConnectSerial
            // 
            this.roundedConnectSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.roundedConnectSerial.FlatAppearance.BorderSize = 0;
            this.roundedConnectSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedConnectSerial.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedConnectSerial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.roundedConnectSerial.Image = global::Batteriest.Properties.Resources.BTA___Mark;
            this.roundedConnectSerial.Location = new System.Drawing.Point(884, 65);
            this.roundedConnectSerial.Name = "roundedConnectSerial";
            this.roundedConnectSerial.Size = new System.Drawing.Size(27, 27);
            this.roundedConnectSerial.TabIndex = 0;
            this.roundedConnectSerial.UseVisualStyleBackColor = false;
            this.roundedConnectSerial.Click += new System.EventHandler(this.RoundedConnectSerial_Click);
            // 
            // pictureApp
            // 
            this.pictureApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pictureApp.Image = global::Batteriest.Properties.Resources.BTA___Icon;
            this.pictureApp.Location = new System.Drawing.Point(47, 43);
            this.pictureApp.Name = "pictureApp";
            this.pictureApp.Size = new System.Drawing.Size(100, 120);
            this.pictureApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureApp.TabIndex = 1;
            this.pictureApp.TabStop = false;
            // 
            // buttonRCEstimate
            // 
            this.buttonRCEstimate.FlatAppearance.BorderSize = 0;
            this.buttonRCEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRCEstimate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRCEstimate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonRCEstimate.Image = global::Batteriest.Properties.Resources.BTA___RCE;
            this.buttonRCEstimate.Location = new System.Drawing.Point(0, 236);
            this.buttonRCEstimate.Name = "buttonRCEstimate";
            this.buttonRCEstimate.Size = new System.Drawing.Size(192, 45);
            this.buttonRCEstimate.TabIndex = 0;
            this.buttonRCEstimate.Text = "Pulse-Discharge Test";
            this.buttonRCEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRCEstimate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRCEstimate.UseVisualStyleBackColor = true;
            this.buttonRCEstimate.Click += new System.EventHandler(this.ButtonRCEstimate_Click);
            // 
            // buttonAgingTest
            // 
            this.buttonAgingTest.FlatAppearance.BorderSize = 0;
            this.buttonAgingTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgingTest.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgingTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonAgingTest.Image = global::Batteriest.Properties.Resources.BTA___AT;
            this.buttonAgingTest.Location = new System.Drawing.Point(0, 281);
            this.buttonAgingTest.Name = "buttonAgingTest";
            this.buttonAgingTest.Size = new System.Drawing.Size(192, 45);
            this.buttonAgingTest.TabIndex = 0;
            this.buttonAgingTest.Text = " Aging Test";
            this.buttonAgingTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgingTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAgingTest.UseVisualStyleBackColor = true;
            this.buttonAgingTest.Click += new System.EventHandler(this.ButtonAgingTest_Click);
            // 
            // buttonHarmonic
            // 
            this.buttonHarmonic.FlatAppearance.BorderSize = 0;
            this.buttonHarmonic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHarmonic.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHarmonic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonHarmonic.Image = global::Batteriest.Properties.Resources.BTA___HA;
            this.buttonHarmonic.Location = new System.Drawing.Point(0, 326);
            this.buttonHarmonic.Name = "buttonHarmonic";
            this.buttonHarmonic.Size = new System.Drawing.Size(192, 45);
            this.buttonHarmonic.TabIndex = 0;
            this.buttonHarmonic.Text = " Harmonic Analysis";
            this.buttonHarmonic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHarmonic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHarmonic.UseVisualStyleBackColor = true;
            this.buttonHarmonic.Click += new System.EventHandler(this.ButtonHarmonic_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonSettings.Image = global::Batteriest.Properties.Resources.BTA___Settings;
            this.buttonSettings.Location = new System.Drawing.Point(0, 450);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(195, 45);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = " Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonAboutUs
            // 
            this.buttonAboutUs.FlatAppearance.BorderSize = 0;
            this.buttonAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutUs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.buttonAboutUs.Image = global::Batteriest.Properties.Resources.BTA___Info;
            this.buttonAboutUs.Location = new System.Drawing.Point(0, 495);
            this.buttonAboutUs.Name = "buttonAboutUs";
            this.buttonAboutUs.Size = new System.Drawing.Size(192, 45);
            this.buttonAboutUs.TabIndex = 0;
            this.buttonAboutUs.Text = " About Us";
            this.buttonAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAboutUs.UseVisualStyleBackColor = true;
            this.buttonAboutUs.Click += new System.EventHandler(this.ButtonAboutUs_Click);
            // 
            // Batteriest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.roundedDisconnectSerial);
            this.Controls.Add(this.roundedConnectSerial);
            this.Controls.Add(this.comboSerialBox);
            this.Controls.Add(this.panelSplitter);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.pictureApp);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Batteriest";
            this.Text = "FormBatteriest";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelApp.ResumeLayout(false);
            this.panelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureApp;
        public System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Label labelApp;
        private System.Windows.Forms.Panel panelApp;
        private RoundedRectangleButton.RoundedRectangleButton roundedHideApp;
        private RoundedRectangleButton.RoundedRectangleButton raundedCloseApp;
        public System.Windows.Forms.Label labelForm;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panelSplitter;
        public System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Label labelPort;
        public System.Windows.Forms.ComboBox comboSerialBox;
        private System.Windows.Forms.Label label1;
        private RoundedRectangleButton.RoundedRectangleButton roundedHideButton;
        private RoundedRectangleButton.RoundedRectangleButton roundedCloseButton;
        public System.Windows.Forms.Button buttonHarmonic;
        public System.Windows.Forms.Button buttonSettings;
        public System.Windows.Forms.Button buttonAboutUs;
        public System.Windows.Forms.Button buttonAgingTest;
        public System.Windows.Forms.Button buttonRCEstimate;
        public RoundedRectangleButton.RoundedRectangleButton roundedConnectSerial;
        public RoundedRectangleButton.RoundedRectangleButton roundedDisconnectSerial;
    }
}

