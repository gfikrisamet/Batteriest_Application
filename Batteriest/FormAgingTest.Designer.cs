namespace Batteriest
{
    partial class FormAgingTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roundedCharge = new RoundedRectangleButton.RoundedRectangleButton();
            this.roundedIdle = new RoundedRectangleButton.RoundedRectangleButton();
            this.roundedDischarge = new RoundedRectangleButton.RoundedRectangleButton();
            this.labelTemp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelCycle = new System.Windows.Forms.Label();
            this.labelVoltage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roundedCycleStop = new RoundedRectangleButton.RoundedRectangleButton();
            this.roundedCycleStart = new RoundedRectangleButton.RoundedRectangleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voltage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label2.Location = new System.Drawing.Point(40, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(40, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label4.Location = new System.Drawing.Point(40, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cycle";
            // 
            // roundedCharge
            // 
            this.roundedCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedCharge.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedCharge.Location = new System.Drawing.Point(531, 79);
            this.roundedCharge.Name = "roundedCharge";
            this.roundedCharge.Size = new System.Drawing.Size(90, 30);
            this.roundedCharge.TabIndex = 2;
            this.roundedCharge.Text = "Charge";
            this.roundedCharge.UseVisualStyleBackColor = false;
            this.roundedCharge.Click += new System.EventHandler(this.RoundedCharge_Click);
            // 
            // roundedIdle
            // 
            this.roundedIdle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedIdle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedIdle.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedIdle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedIdle.Location = new System.Drawing.Point(531, 179);
            this.roundedIdle.Name = "roundedIdle";
            this.roundedIdle.Size = new System.Drawing.Size(90, 30);
            this.roundedIdle.TabIndex = 2;
            this.roundedIdle.Text = "Idle";
            this.roundedIdle.UseVisualStyleBackColor = false;
            this.roundedIdle.Click += new System.EventHandler(this.RoundedIdle_Click);
            // 
            // roundedDischarge
            // 
            this.roundedDischarge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedDischarge.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedDischarge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedDischarge.Location = new System.Drawing.Point(531, 129);
            this.roundedDischarge.Name = "roundedDischarge";
            this.roundedDischarge.Size = new System.Drawing.Size(90, 30);
            this.roundedDischarge.TabIndex = 2;
            this.roundedDischarge.Text = "Discharge";
            this.roundedDischarge.UseVisualStyleBackColor = false;
            this.roundedDischarge.Click += new System.EventHandler(this.RoundedDischarge_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.White;
            this.labelTemp.Location = new System.Drawing.Point(246, 214);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(135, 45);
            this.labelTemp.TabIndex = 3;
            this.labelTemp.Text = "-";
            this.labelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTemp.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label6.Location = new System.Drawing.Point(481, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Test Control";
            // 
            // labelCurrent
            // 
            this.labelCurrent.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrent.ForeColor = System.Drawing.Color.White;
            this.labelCurrent.Location = new System.Drawing.Point(246, 144);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(135, 45);
            this.labelCurrent.TabIndex = 3;
            this.labelCurrent.Text = "-";
            this.labelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCurrent.UseCompatibleTextRendering = true;
            // 
            // labelCycle
            // 
            this.labelCycle.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCycle.ForeColor = System.Drawing.Color.White;
            this.labelCycle.Location = new System.Drawing.Point(246, 284);
            this.labelCycle.Name = "labelCycle";
            this.labelCycle.Size = new System.Drawing.Size(135, 45);
            this.labelCycle.TabIndex = 3;
            this.labelCycle.Text = "-";
            this.labelCycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCycle.UseCompatibleTextRendering = true;
            // 
            // labelVoltage
            // 
            this.labelVoltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.labelVoltage.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelVoltage.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltage.ForeColor = System.Drawing.Color.White;
            this.labelVoltage.Location = new System.Drawing.Point(246, 74);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(135, 45);
            this.labelVoltage.TabIndex = 3;
            this.labelVoltage.Text = "-";
            this.labelVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVoltage.UseCompatibleTextRendering = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.label10.Location = new System.Drawing.Point(475, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 36);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cycle Control";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(390, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Volt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(390, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ampere";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(390, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "°C";
            // 
            // roundedCycleStop
            // 
            this.roundedCycleStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedCycleStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedCycleStop.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedCycleStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedCycleStop.Image = global::Batteriest.Properties.Resources.BTA___Stop;
            this.roundedCycleStop.Location = new System.Drawing.Point(531, 341);
            this.roundedCycleStop.Name = "roundedCycleStop";
            this.roundedCycleStop.Size = new System.Drawing.Size(90, 30);
            this.roundedCycleStop.TabIndex = 2;
            this.roundedCycleStop.UseVisualStyleBackColor = false;
            this.roundedCycleStop.Click += new System.EventHandler(this.RoundedCycleStop_Click);
            // 
            // roundedCycleStart
            // 
            this.roundedCycleStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.roundedCycleStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedCycleStart.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.roundedCycleStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.roundedCycleStart.Image = global::Batteriest.Properties.Resources.BTA___Start;
            this.roundedCycleStart.Location = new System.Drawing.Point(531, 291);
            this.roundedCycleStart.Name = "roundedCycleStart";
            this.roundedCycleStart.Size = new System.Drawing.Size(90, 30);
            this.roundedCycleStart.TabIndex = 2;
            this.roundedCycleStart.UseVisualStyleBackColor = false;
            this.roundedCycleStart.Click += new System.EventHandler(this.RoundedCycleStart_Click);
            // 
            // FormAgingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(734, 416);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelVoltage);
            this.Controls.Add(this.labelCycle);
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.roundedDischarge);
            this.Controls.Add(this.roundedCycleStop);
            this.Controls.Add(this.roundedCycleStart);
            this.Controls.Add(this.roundedIdle);
            this.Controls.Add(this.roundedCharge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgingTest";
            this.Text = "FormStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label labelVoltage;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label labelTemp;
        public System.Windows.Forms.Label labelCurrent;
        public System.Windows.Forms.Label labelCycle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public RoundedRectangleButton.RoundedRectangleButton roundedCycleStart;
        public RoundedRectangleButton.RoundedRectangleButton roundedCycleStop;
        public RoundedRectangleButton.RoundedRectangleButton roundedCharge;
        public RoundedRectangleButton.RoundedRectangleButton roundedIdle;
        public RoundedRectangleButton.RoundedRectangleButton roundedDischarge;
    }
}