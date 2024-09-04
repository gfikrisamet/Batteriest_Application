namespace Batteriest
{
    partial class FormPulseDischarge
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedPDStopButton = new RoundedRectangleButton.RoundedRectangleButton();
            this.roundedPDStartButton = new RoundedRectangleButton.RoundedRectangleButton();
            this.pictureStage1 = new System.Windows.Forms.PictureBox();
            this.pictureStage2 = new System.Windows.Forms.PictureBox();
            this.pictureStage3 = new System.Windows.Forms.PictureBox();
            this.pictureStage4 = new System.Windows.Forms.PictureBox();
            this.labelRC_CStart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRC_CVoltage = new System.Windows.Forms.Label();
            this.labelRC_CCurrent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelRC_Second = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStage4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(74, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Charge The Battery Until Its Voltage Reaches 4.1 V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(74, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rest The Battery";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(74, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Measure Voltage of the Battery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(74, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Measure Voltage and Current of the Battery When 1C Discharging";
            // 
            // roundedPDStopButton
            // 
            this.roundedPDStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedPDStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedPDStopButton.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedPDStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedPDStopButton.Image = global::Batteriest.Properties.Resources.BTA___Stop;
            this.roundedPDStopButton.Location = new System.Drawing.Point(574, 360);
            this.roundedPDStopButton.Name = "roundedPDStopButton";
            this.roundedPDStopButton.Size = new System.Drawing.Size(100, 27);
            this.roundedPDStopButton.TabIndex = 1;
            this.roundedPDStopButton.UseVisualStyleBackColor = false;
            this.roundedPDStopButton.Click += new System.EventHandler(this.RoundedPDStopButton_Click);
            // 
            // roundedPDStartButton
            // 
            this.roundedPDStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedPDStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedPDStartButton.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedPDStartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedPDStartButton.Image = global::Batteriest.Properties.Resources.BTA___Start;
            this.roundedPDStartButton.Location = new System.Drawing.Point(450, 360);
            this.roundedPDStartButton.Name = "roundedPDStartButton";
            this.roundedPDStartButton.Size = new System.Drawing.Size(100, 27);
            this.roundedPDStartButton.TabIndex = 1;
            this.roundedPDStartButton.UseVisualStyleBackColor = false;
            this.roundedPDStartButton.Click += new System.EventHandler(this.RoundedPDStartButton_Click);
            // 
            // pictureStage1
            // 
            this.pictureStage1.BackColor = System.Drawing.Color.White;
            this.pictureStage1.Location = new System.Drawing.Point(649, 48);
            this.pictureStage1.Name = "pictureStage1";
            this.pictureStage1.Size = new System.Drawing.Size(25, 25);
            this.pictureStage1.TabIndex = 2;
            this.pictureStage1.TabStop = false;
            this.pictureStage1.BackColorChanged += new System.EventHandler(this.PictureStage1_BackColorChanged);
            // 
            // pictureStage2
            // 
            this.pictureStage2.BackColor = System.Drawing.Color.White;
            this.pictureStage2.Location = new System.Drawing.Point(649, 139);
            this.pictureStage2.Name = "pictureStage2";
            this.pictureStage2.Size = new System.Drawing.Size(25, 25);
            this.pictureStage2.TabIndex = 2;
            this.pictureStage2.TabStop = false;
            this.pictureStage2.BackColorChanged += new System.EventHandler(this.PictureStage2_BackColorChanged);
            // 
            // pictureStage3
            // 
            this.pictureStage3.BackColor = System.Drawing.Color.White;
            this.pictureStage3.Location = new System.Drawing.Point(649, 221);
            this.pictureStage3.Name = "pictureStage3";
            this.pictureStage3.Size = new System.Drawing.Size(25, 25);
            this.pictureStage3.TabIndex = 2;
            this.pictureStage3.TabStop = false;
            this.pictureStage3.BackColorChanged += new System.EventHandler(this.PictureStage3_BackColorChanged);
            // 
            // pictureStage4
            // 
            this.pictureStage4.BackColor = System.Drawing.Color.White;
            this.pictureStage4.Location = new System.Drawing.Point(649, 291);
            this.pictureStage4.Name = "pictureStage4";
            this.pictureStage4.Size = new System.Drawing.Size(25, 25);
            this.pictureStage4.TabIndex = 2;
            this.pictureStage4.TabStop = false;
            this.pictureStage4.BackColorChanged += new System.EventHandler(this.PictureStage4_BackColorChanged);
            // 
            // labelRC_CStart
            // 
            this.labelRC_CStart.AutoSize = true;
            this.labelRC_CStart.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.labelRC_CStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.labelRC_CStart.Location = new System.Drawing.Point(427, 78);
            this.labelRC_CStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRC_CStart.Name = "labelRC_CStart";
            this.labelRC_CStart.Size = new System.Drawing.Size(0, 17);
            this.labelRC_CStart.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label5.Location = new System.Drawing.Point(74, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Voltage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(251, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current:";
            // 
            // labelRC_CVoltage
            // 
            this.labelRC_CVoltage.AutoSize = true;
            this.labelRC_CVoltage.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.labelRC_CVoltage.ForeColor = System.Drawing.Color.White;
            this.labelRC_CVoltage.Location = new System.Drawing.Point(147, 78);
            this.labelRC_CVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRC_CVoltage.Name = "labelRC_CVoltage";
            this.labelRC_CVoltage.Size = new System.Drawing.Size(12, 17);
            this.labelRC_CVoltage.TabIndex = 0;
            this.labelRC_CVoltage.Text = "-";
            this.labelRC_CVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRC_CCurrent
            // 
            this.labelRC_CCurrent.AutoSize = true;
            this.labelRC_CCurrent.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.labelRC_CCurrent.ForeColor = System.Drawing.Color.White;
            this.labelRC_CCurrent.Location = new System.Drawing.Point(324, 78);
            this.labelRC_CCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRC_CCurrent.Name = "labelRC_CCurrent";
            this.labelRC_CCurrent.Size = new System.Drawing.Size(12, 17);
            this.labelRC_CCurrent.TabIndex = 0;
            this.labelRC_CCurrent.Text = "-";
            this.labelRC_CCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(196, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(376, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label7.Location = new System.Drawing.Point(74, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Time :";
            // 
            // labelRC_Second
            // 
            this.labelRC_Second.AutoSize = true;
            this.labelRC_Second.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.labelRC_Second.ForeColor = System.Drawing.Color.White;
            this.labelRC_Second.Location = new System.Drawing.Point(133, 169);
            this.labelRC_Second.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRC_Second.Name = "labelRC_Second";
            this.labelRC_Second.Size = new System.Drawing.Size(12, 17);
            this.labelRC_Second.TabIndex = 0;
            this.labelRC_Second.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label8.Location = new System.Drawing.Point(40, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "STAGE 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label11.Location = new System.Drawing.Point(40, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "STAGE 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label12.Location = new System.Drawing.Point(40, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "STAGE 3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label13.Location = new System.Drawing.Point(40, 267);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 27);
            this.label13.TabIndex = 0;
            this.label13.Text = "STAGE 4";
            // 
            // FormPulseDischarge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(734, 416);
            this.Controls.Add(this.pictureStage4);
            this.Controls.Add(this.pictureStage3);
            this.Controls.Add(this.pictureStage2);
            this.Controls.Add(this.pictureStage1);
            this.Controls.Add(this.roundedPDStartButton);
            this.Controls.Add(this.roundedPDStopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelRC_CCurrent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelRC_CVoltage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelRC_Second);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelRC_CStart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPulseDischarge";
            this.Text = "FormRCEstimate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureStage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStage4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label labelRC_CVoltage;
        public System.Windows.Forms.Label labelRC_CCurrent;
        public System.Windows.Forms.Label labelRC_CStart;
        public System.Windows.Forms.PictureBox pictureStage1;
        public System.Windows.Forms.PictureBox pictureStage2;
        public System.Windows.Forms.PictureBox pictureStage3;
        public System.Windows.Forms.PictureBox pictureStage4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labelRC_Second;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public RoundedRectangleButton.RoundedRectangleButton roundedPDStopButton;
        public RoundedRectangleButton.RoundedRectangleButton roundedPDStartButton;
    }
}