namespace Batteriest
{
    partial class FormSettings
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
            this.labelG3 = new System.Windows.Forms.Label();
            this.labelG8 = new System.Windows.Forms.Label();
            this.textRCVoltage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedFilePath = new RoundedRectangleButton.RoundedRectangleButton();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.labelC5 = new System.Windows.Forms.Label();
            this.roundedRecoveryData = new RoundedRectangleButton.RoundedRectangleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRCVoltage = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelRCRestTime = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textRCRestTime = new System.Windows.Forms.TextBox();
            this.labelRCCap = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textRCHighS = new System.Windows.Forms.TextBox();
            this.labelATMaxVoltage = new System.Windows.Forms.Label();
            this.labelATMinVoltage = new System.Windows.Forms.Label();
            this.labelATCycle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textATMaxVoltage = new System.Windows.Forms.TextBox();
            this.textATMinVoltage = new System.Windows.Forms.TextBox();
            this.textATCycle = new System.Windows.Forms.TextBox();
            this.labelMaxVoltage = new System.Windows.Forms.Label();
            this.labelSMinVoltage = new System.Windows.Forms.Label();
            this.labelSMaxTemp = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textSMaxVoltage = new System.Windows.Forms.TextBox();
            this.textSMinVoltage = new System.Windows.Forms.TextBox();
            this.textSMaxTemp = new System.Windows.Forms.TextBox();
            this.roundedSaveData = new RoundedRectangleButton.RoundedRectangleButton();
            this.textRCLowS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textHASample = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelG3
            // 
            this.labelG3.AutoSize = true;
            this.labelG3.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.labelG3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labelG3.Location = new System.Drawing.Point(36, 183);
            this.labelG3.Name = "labelG3";
            this.labelG3.Size = new System.Drawing.Size(215, 27);
            this.labelG3.TabIndex = 2;
            this.labelG3.Text = "Aging Test Settings";
            // 
            // labelG8
            // 
            this.labelG8.AutoSize = true;
            this.labelG8.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.labelG8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labelG8.Location = new System.Drawing.Point(380, 39);
            this.labelG8.Name = "labelG8";
            this.labelG8.Size = new System.Drawing.Size(228, 27);
            this.labelG8.TabIndex = 2;
            this.labelG8.Text = "Test Secure Settings";
            // 
            // textRCVoltage
            // 
            this.textRCVoltage.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textRCVoltage.Location = new System.Drawing.Point(237, 61);
            this.textRCVoltage.Name = "textRCVoltage";
            this.textRCVoltage.Size = new System.Drawing.Size(56, 25);
            this.textRCVoltage.TabIndex = 3;
            this.textRCVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Float);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(380, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Saving Settings";
            // 
            // roundedFilePath
            // 
            this.roundedFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedFilePath.FlatAppearance.BorderSize = 0;
            this.roundedFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedFilePath.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.roundedFilePath.ForeColor = System.Drawing.Color.White;
            this.roundedFilePath.Location = new System.Drawing.Point(577, 287);
            this.roundedFilePath.Name = "roundedFilePath";
            this.roundedFilePath.Size = new System.Drawing.Size(97, 25);
            this.roundedFilePath.TabIndex = 4;
            this.roundedFilePath.Text = "Browse...";
            this.roundedFilePath.UseVisualStyleBackColor = false;
            this.roundedFilePath.Click += new System.EventHandler(this.RoundedExcel_Click);
            // 
            // textFilePath
            // 
            this.textFilePath.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textFilePath.Location = new System.Drawing.Point(421, 248);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(253, 25);
            this.textFilePath.TabIndex = 3;
            // 
            // labelC5
            // 
            this.labelC5.AutoSize = true;
            this.labelC5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelC5.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.labelC5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelC5.Location = new System.Drawing.Point(432, 359);
            this.labelC5.Name = "labelC5";
            this.labelC5.Size = new System.Drawing.Size(0, 21);
            this.labelC5.TabIndex = 2;
            // 
            // roundedRecoveryData
            // 
            this.roundedRecoveryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.roundedRecoveryData.FlatAppearance.BorderSize = 0;
            this.roundedRecoveryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedRecoveryData.Image = global::Batteriest.Properties.Resources.BTA___Restore;
            this.roundedRecoveryData.Location = new System.Drawing.Point(592, 355);
            this.roundedRecoveryData.Name = "roundedRecoveryData";
            this.roundedRecoveryData.Size = new System.Drawing.Size(82, 25);
            this.roundedRecoveryData.TabIndex = 1;
            this.roundedRecoveryData.UseVisualStyleBackColor = false;
            this.roundedRecoveryData.Click += new System.EventHandler(this.RoundedResetData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(215, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(36, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Pulse-Discharge Test";
            // 
            // labelRCVoltage
            // 
            this.labelRCVoltage.AutoSize = true;
            this.labelRCVoltage.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelRCVoltage.ForeColor = System.Drawing.Color.White;
            this.labelRCVoltage.Location = new System.Drawing.Point(62, 66);
            this.labelRCVoltage.Name = "labelRCVoltage";
            this.labelRCVoltage.Size = new System.Drawing.Size(142, 20);
            this.labelRCVoltage.TabIndex = 2;
            this.labelRCVoltage.Text = "Charge-End Voltage";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(301, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "V";
            // 
            // labelRCRestTime
            // 
            this.labelRCRestTime.AutoSize = true;
            this.labelRCRestTime.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelRCRestTime.ForeColor = System.Drawing.Color.White;
            this.labelRCRestTime.Location = new System.Drawing.Point(62, 101);
            this.labelRCRestTime.Name = "labelRCRestTime";
            this.labelRCRestTime.Size = new System.Drawing.Size(126, 20);
            this.labelRCRestTime.TabIndex = 2;
            this.labelRCRestTime.Text = "Battery Rest Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(301, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "s";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(215, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = ":";
            // 
            // textRCRestTime
            // 
            this.textRCRestTime.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textRCRestTime.Location = new System.Drawing.Point(237, 96);
            this.textRCRestTime.Name = "textRCRestTime";
            this.textRCRestTime.Size = new System.Drawing.Size(56, 25);
            this.textRCRestTime.TabIndex = 3;
            this.textRCRestTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Integer);
            // 
            // labelRCCap
            // 
            this.labelRCCap.AutoSize = true;
            this.labelRCCap.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelRCCap.ForeColor = System.Drawing.Color.White;
            this.labelRCCap.Location = new System.Drawing.Point(62, 135);
            this.labelRCCap.Name = "labelRCCap";
            this.labelRCCap.Size = new System.Drawing.Size(140, 20);
            this.labelRCCap.TabIndex = 2;
            this.labelRCCap.Text = "Sample Times (H/L)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(361, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "s";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(215, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 25);
            this.label19.TabIndex = 2;
            this.label19.Text = ":";
            // 
            // textRCHighS
            // 
            this.textRCHighS.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textRCHighS.Location = new System.Drawing.Point(237, 130);
            this.textRCHighS.Name = "textRCHighS";
            this.textRCHighS.Size = new System.Drawing.Size(56, 25);
            this.textRCHighS.TabIndex = 3;
            this.textRCHighS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Integer);
            // 
            // labelATMaxVoltage
            // 
            this.labelATMaxVoltage.AutoSize = true;
            this.labelATMaxVoltage.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelATMaxVoltage.ForeColor = System.Drawing.Color.White;
            this.labelATMaxVoltage.Location = new System.Drawing.Point(62, 218);
            this.labelATMaxVoltage.Name = "labelATMaxVoltage";
            this.labelATMaxVoltage.Size = new System.Drawing.Size(95, 20);
            this.labelATMaxVoltage.TabIndex = 2;
            this.labelATMaxVoltage.Text = "Max. Voltage";
            // 
            // labelATMinVoltage
            // 
            this.labelATMinVoltage.AutoSize = true;
            this.labelATMinVoltage.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelATMinVoltage.ForeColor = System.Drawing.Color.White;
            this.labelATMinVoltage.Location = new System.Drawing.Point(62, 253);
            this.labelATMinVoltage.Name = "labelATMinVoltage";
            this.labelATMinVoltage.Size = new System.Drawing.Size(92, 20);
            this.labelATMinVoltage.TabIndex = 2;
            this.labelATMinVoltage.Text = "Min. Voltage";
            // 
            // labelATCycle
            // 
            this.labelATCycle.AutoSize = true;
            this.labelATCycle.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelATCycle.ForeColor = System.Drawing.Color.White;
            this.labelATCycle.Location = new System.Drawing.Point(62, 287);
            this.labelATCycle.Name = "labelATCycle";
            this.labelATCycle.Size = new System.Drawing.Size(99, 20);
            this.labelATCycle.TabIndex = 2;
            this.labelATCycle.Text = "Desired Cycle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(301, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(301, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "V";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(215, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 25);
            this.label20.TabIndex = 2;
            this.label20.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(215, 248);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 25);
            this.label21.TabIndex = 2;
            this.label21.Text = ":";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(215, 282);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 25);
            this.label22.TabIndex = 2;
            this.label22.Text = ":";
            // 
            // textATMaxVoltage
            // 
            this.textATMaxVoltage.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textATMaxVoltage.Location = new System.Drawing.Point(237, 213);
            this.textATMaxVoltage.Name = "textATMaxVoltage";
            this.textATMaxVoltage.Size = new System.Drawing.Size(56, 25);
            this.textATMaxVoltage.TabIndex = 3;
            this.textATMaxVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Float);
            // 
            // textATMinVoltage
            // 
            this.textATMinVoltage.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textATMinVoltage.Location = new System.Drawing.Point(237, 248);
            this.textATMinVoltage.Name = "textATMinVoltage";
            this.textATMinVoltage.Size = new System.Drawing.Size(56, 25);
            this.textATMinVoltage.TabIndex = 3;
            this.textATMinVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Float);
            // 
            // textATCycle
            // 
            this.textATCycle.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textATCycle.Location = new System.Drawing.Point(237, 282);
            this.textATCycle.Name = "textATCycle";
            this.textATCycle.Size = new System.Drawing.Size(56, 25);
            this.textATCycle.TabIndex = 3;
            this.textATCycle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Integer);
            // 
            // labelMaxVoltage
            // 
            this.labelMaxVoltage.AutoSize = true;
            this.labelMaxVoltage.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelMaxVoltage.ForeColor = System.Drawing.Color.White;
            this.labelMaxVoltage.Location = new System.Drawing.Point(417, 74);
            this.labelMaxVoltage.Name = "labelMaxVoltage";
            this.labelMaxVoltage.Size = new System.Drawing.Size(95, 20);
            this.labelMaxVoltage.TabIndex = 2;
            this.labelMaxVoltage.Text = "Max. Voltage";
            // 
            // labelSMinVoltage
            // 
            this.labelSMinVoltage.AutoSize = true;
            this.labelSMinVoltage.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelSMinVoltage.ForeColor = System.Drawing.Color.White;
            this.labelSMinVoltage.Location = new System.Drawing.Point(417, 109);
            this.labelSMinVoltage.Name = "labelSMinVoltage";
            this.labelSMinVoltage.Size = new System.Drawing.Size(92, 20);
            this.labelSMinVoltage.TabIndex = 2;
            this.labelSMinVoltage.Text = "Min. Voltage";
            // 
            // labelSMaxTemp
            // 
            this.labelSMaxTemp.AutoSize = true;
            this.labelSMaxTemp.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.labelSMaxTemp.ForeColor = System.Drawing.Color.White;
            this.labelSMaxTemp.Location = new System.Drawing.Point(417, 143);
            this.labelSMaxTemp.Name = "labelSMaxTemp";
            this.labelSMaxTemp.Size = new System.Drawing.Size(127, 20);
            this.labelSMaxTemp.TabIndex = 2;
            this.labelSMaxTemp.Text = "Max. Temperature";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(656, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 20);
            this.label24.TabIndex = 2;
            this.label24.Text = "V";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(656, 109);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 20);
            this.label25.TabIndex = 2;
            this.label25.Text = "V";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(656, 143);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 20);
            this.label26.TabIndex = 2;
            this.label26.Text = "°C";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(570, 69);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 25);
            this.label27.TabIndex = 2;
            this.label27.Text = ":";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(570, 104);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 25);
            this.label28.TabIndex = 2;
            this.label28.Text = ":";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(570, 138);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 25);
            this.label29.TabIndex = 2;
            this.label29.Text = ":";
            // 
            // textSMaxVoltage
            // 
            this.textSMaxVoltage.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textSMaxVoltage.Location = new System.Drawing.Point(592, 69);
            this.textSMaxVoltage.Name = "textSMaxVoltage";
            this.textSMaxVoltage.Size = new System.Drawing.Size(56, 25);
            this.textSMaxVoltage.TabIndex = 3;
            this.textSMaxVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Float);
            // 
            // textSMinVoltage
            // 
            this.textSMinVoltage.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textSMinVoltage.Location = new System.Drawing.Point(592, 104);
            this.textSMinVoltage.Name = "textSMinVoltage";
            this.textSMinVoltage.Size = new System.Drawing.Size(56, 25);
            this.textSMinVoltage.TabIndex = 3;
            this.textSMinVoltage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Float);
            // 
            // textSMaxTemp
            // 
            this.textSMaxTemp.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textSMaxTemp.Location = new System.Drawing.Point(592, 138);
            this.textSMaxTemp.Name = "textSMaxTemp";
            this.textSMaxTemp.Size = new System.Drawing.Size(56, 25);
            this.textSMaxTemp.TabIndex = 3;
            this.textSMaxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Integer);
            // 
            // roundedSaveData
            // 
            this.roundedSaveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.roundedSaveData.FlatAppearance.BorderSize = 0;
            this.roundedSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedSaveData.Image = global::Batteriest.Properties.Resources.BTA___Save;
            this.roundedSaveData.Location = new System.Drawing.Point(504, 355);
            this.roundedSaveData.Name = "roundedSaveData";
            this.roundedSaveData.Size = new System.Drawing.Size(82, 25);
            this.roundedSaveData.TabIndex = 1;
            this.roundedSaveData.UseVisualStyleBackColor = false;
            this.roundedSaveData.Click += new System.EventHandler(this.RoundedSaveData_Click);
            // 
            // textRCLowS
            // 
            this.textRCLowS.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textRCLowS.Location = new System.Drawing.Point(299, 130);
            this.textRCLowS.Name = "textRCLowS";
            this.textRCLowS.Size = new System.Drawing.Size(56, 25);
            this.textRCLowS.TabIndex = 3;
            this.textRCLowS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Integer);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(36, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Harmonic Analysis Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample Times";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(301, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(215, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = ":";
            // 
            // textHASample
            // 
            this.textHASample.Font = new System.Drawing.Font("Nirmala UI", 10F);
            this.textHASample.Location = new System.Drawing.Point(237, 352);
            this.textHASample.Name = "textHASample";
            this.textHASample.Size = new System.Drawing.Size(56, 25);
            this.textHASample.TabIndex = 3;
            this.textHASample.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextGeneral_KeyPress_Integer);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(417, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Folder Location";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 14F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(570, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = ":";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(734, 416);
            this.Controls.Add(this.roundedFilePath);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.textATCycle);
            this.Controls.Add(this.textSMaxTemp);
            this.Controls.Add(this.textHASample);
            this.Controls.Add(this.textRCLowS);
            this.Controls.Add(this.textRCHighS);
            this.Controls.Add(this.textATMinVoltage);
            this.Controls.Add(this.textSMinVoltage);
            this.Controls.Add(this.textRCRestTime);
            this.Controls.Add(this.textATMaxVoltage);
            this.Controls.Add(this.textSMaxVoltage);
            this.Controls.Add(this.textRCVoltage);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelATCycle);
            this.Controls.Add(this.labelATMinVoltage);
            this.Controls.Add(this.labelSMaxTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRCCap);
            this.Controls.Add(this.labelSMinVoltage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelATMaxVoltage);
            this.Controls.Add(this.labelMaxVoltage);
            this.Controls.Add(this.labelRCRestTime);
            this.Controls.Add(this.labelRCVoltage);
            this.Controls.Add(this.labelC5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelG8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelG3);
            this.Controls.Add(this.roundedRecoveryData);
            this.Controls.Add(this.roundedSaveData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelG3;
        private System.Windows.Forms.Label labelG8;
        private System.Windows.Forms.TextBox textRCVoltage;
        private System.Windows.Forms.Label label1;
        private RoundedRectangleButton.RoundedRectangleButton roundedFilePath;
        private System.Windows.Forms.TextBox textFilePath;
        private RoundedRectangleButton.RoundedRectangleButton roundedSaveData;
        private RoundedRectangleButton.RoundedRectangleButton roundedRecoveryData;
        private System.Windows.Forms.Label labelC5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRCVoltage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelRCRestTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textRCRestTime;
        private System.Windows.Forms.Label labelRCCap;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textRCHighS;
        private System.Windows.Forms.Label labelATMaxVoltage;
        private System.Windows.Forms.Label labelATMinVoltage;
        private System.Windows.Forms.Label labelATCycle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textATMaxVoltage;
        private System.Windows.Forms.TextBox textATMinVoltage;
        private System.Windows.Forms.TextBox textATCycle;
        private System.Windows.Forms.Label labelMaxVoltage;
        private System.Windows.Forms.Label labelSMinVoltage;
        private System.Windows.Forms.Label labelSMaxTemp;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textSMaxVoltage;
        private System.Windows.Forms.TextBox textSMinVoltage;
        private System.Windows.Forms.TextBox textSMaxTemp;
        private System.Windows.Forms.TextBox textRCLowS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textHASample;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}