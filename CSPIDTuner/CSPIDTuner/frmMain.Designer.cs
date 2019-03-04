namespace CSPIDTuner
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pidChart = new LiveCharts.WinForms.CartesianChart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdClearIAccum = new System.Windows.Forms.Button();
            this.cmdApply = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.numSetpoint = new System.Windows.Forms.NumericUpDown();
            this.numMaxIAccum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numIZone = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numRamp = new System.Windows.Forms.NumericUpDown();
            this.txtIAccum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAverageDev = new System.Windows.Forms.TextBox();
            this.numVel = new System.Windows.Forms.NumericUpDown();
            this.txtDeviation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtActualVal = new System.Windows.Forms.TextBox();
            this.numAccel = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSysName = new System.Windows.Forms.TextBox();
            this.txtDesiredVal = new System.Windows.Forms.TextBox();
            this.numkF = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numkD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numkI = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numkP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIAccum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numkF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numkD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numkI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numkP)).BeginInit();
            this.SuspendLayout();
            // 
            // pidChart
            // 
            this.pidChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pidChart.Location = new System.Drawing.Point(373, 12);
            this.pidChart.Name = "pidChart";
            this.pidChart.Size = new System.Drawing.Size(2085, 1178);
            this.pidChart.TabIndex = 0;
            this.pidChart.Text = "pidChart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdConnect);
            this.groupBox1.Controls.Add(this.cmdClearIAccum);
            this.groupBox1.Controls.Add(this.cmdApply);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numSetpoint);
            this.groupBox1.Controls.Add(this.numMaxIAccum);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numIZone);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numRamp);
            this.groupBox1.Controls.Add(this.txtIAccum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAverageDev);
            this.groupBox1.Controls.Add(this.numVel);
            this.groupBox1.Controls.Add(this.txtDeviation);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtActualVal);
            this.groupBox1.Controls.Add(this.numAccel);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSysName);
            this.groupBox1.Controls.Add(this.txtDesiredVal);
            this.groupBox1.Controls.Add(this.numkF);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numkD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numkI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numkP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 1202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gain Tuning";
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(11, 1131);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(318, 59);
            this.cmdConnect.TabIndex = 18;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdClearIAccum
            // 
            this.cmdClearIAccum.Location = new System.Drawing.Point(11, 823);
            this.cmdClearIAccum.Name = "cmdClearIAccum";
            this.cmdClearIAccum.Size = new System.Drawing.Size(318, 59);
            this.cmdClearIAccum.TabIndex = 17;
            this.cmdClearIAccum.Text = "Clear I Accumulator";
            this.cmdClearIAccum.UseVisualStyleBackColor = true;
            this.cmdClearIAccum.Click += new System.EventHandler(this.cmdClearIAccum_Click);
            // 
            // cmdApply
            // 
            this.cmdApply.Location = new System.Drawing.Point(11, 439);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(318, 59);
            this.cmdApply.TabIndex = 10;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = true;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 755);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "I Accumulator:";
            // 
            // numSetpoint
            // 
            this.numSetpoint.DecimalPlaces = 6;
            this.numSetpoint.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSetpoint.Location = new System.Drawing.Point(173, 376);
            this.numSetpoint.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numSetpoint.Minimum = new decimal(new int[] {
            276447232,
            23283,
            0,
            -2147483648});
            this.numSetpoint.Name = "numSetpoint";
            this.numSetpoint.Size = new System.Drawing.Size(156, 31);
            this.numSetpoint.TabIndex = 9;
            this.numSetpoint.ValueChanged += new System.EventHandler(this.numSetpoint_ValueChanged);
            // 
            // numMaxIAccum
            // 
            this.numMaxIAccum.DecimalPlaces = 6;
            this.numMaxIAccum.Location = new System.Drawing.Point(173, 339);
            this.numMaxIAccum.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numMaxIAccum.Name = "numMaxIAccum";
            this.numMaxIAccum.Size = new System.Drawing.Size(156, 31);
            this.numMaxIAccum.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 718);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Average Dev:";
            // 
            // numIZone
            // 
            this.numIZone.DecimalPlaces = 6;
            this.numIZone.Location = new System.Drawing.Point(173, 302);
            this.numIZone.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numIZone.Name = "numIZone";
            this.numIZone.Size = new System.Drawing.Size(156, 31);
            this.numIZone.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Setpoint:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 681);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "Deviation:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Max I Accum:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 644);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Actual Value:";
            // 
            // numRamp
            // 
            this.numRamp.DecimalPlaces = 6;
            this.numRamp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRamp.Location = new System.Drawing.Point(173, 265);
            this.numRamp.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numRamp.Name = "numRamp";
            this.numRamp.Size = new System.Drawing.Size(156, 31);
            this.numRamp.TabIndex = 6;
            // 
            // txtIAccum
            // 
            this.txtIAccum.Location = new System.Drawing.Point(163, 752);
            this.txtIAccum.Name = "txtIAccum";
            this.txtIAccum.ReadOnly = true;
            this.txtIAccum.Size = new System.Drawing.Size(166, 31);
            this.txtIAccum.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "I Zone:";
            // 
            // txtAverageDev
            // 
            this.txtAverageDev.Location = new System.Drawing.Point(163, 715);
            this.txtAverageDev.Name = "txtAverageDev";
            this.txtAverageDev.ReadOnly = true;
            this.txtAverageDev.Size = new System.Drawing.Size(166, 31);
            this.txtAverageDev.TabIndex = 15;
            // 
            // numVel
            // 
            this.numVel.DecimalPlaces = 6;
            this.numVel.Location = new System.Drawing.Point(173, 228);
            this.numVel.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numVel.Name = "numVel";
            this.numVel.Size = new System.Drawing.Size(156, 31);
            this.numVel.TabIndex = 5;
            // 
            // txtDeviation
            // 
            this.txtDeviation.Location = new System.Drawing.Point(163, 678);
            this.txtDeviation.Name = "txtDeviation";
            this.txtDeviation.ReadOnly = true;
            this.txtDeviation.Size = new System.Drawing.Size(166, 31);
            this.txtDeviation.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ramp Rate:";
            // 
            // txtActualVal
            // 
            this.txtActualVal.Location = new System.Drawing.Point(163, 641);
            this.txtActualVal.Name = "txtActualVal";
            this.txtActualVal.ReadOnly = true;
            this.txtActualVal.Size = new System.Drawing.Size(166, 31);
            this.txtActualVal.TabIndex = 13;
            // 
            // numAccel
            // 
            this.numAccel.DecimalPlaces = 6;
            this.numAccel.Location = new System.Drawing.Point(173, 191);
            this.numAccel.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numAccel.Name = "numAccel";
            this.numAccel.Size = new System.Drawing.Size(156, 31);
            this.numAccel.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 570);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "System Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Desired Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cruise Velocity:";
            // 
            // txtSysName
            // 
            this.txtSysName.Location = new System.Drawing.Point(163, 567);
            this.txtSysName.Name = "txtSysName";
            this.txtSysName.ReadOnly = true;
            this.txtSysName.Size = new System.Drawing.Size(166, 31);
            this.txtSysName.TabIndex = 11;
            // 
            // txtDesiredVal
            // 
            this.txtDesiredVal.Location = new System.Drawing.Point(163, 604);
            this.txtDesiredVal.Name = "txtDesiredVal";
            this.txtDesiredVal.ReadOnly = true;
            this.txtDesiredVal.Size = new System.Drawing.Size(166, 31);
            this.txtDesiredVal.TabIndex = 12;
            // 
            // numkF
            // 
            this.numkF.DecimalPlaces = 6;
            this.numkF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numkF.Location = new System.Drawing.Point(173, 154);
            this.numkF.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numkF.Name = "numkF";
            this.numkF.Size = new System.Drawing.Size(156, 31);
            this.numkF.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Acceleration:";
            // 
            // numkD
            // 
            this.numkD.DecimalPlaces = 6;
            this.numkD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numkD.Location = new System.Drawing.Point(173, 117);
            this.numkD.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numkD.Name = "numkD";
            this.numkD.Size = new System.Drawing.Size(156, 31);
            this.numkD.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "F Gain:";
            // 
            // numkI
            // 
            this.numkI.DecimalPlaces = 6;
            this.numkI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numkI.Location = new System.Drawing.Point(173, 80);
            this.numkI.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numkI.Name = "numkI";
            this.numkI.Size = new System.Drawing.Size(156, 31);
            this.numkI.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "D Gain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "I Gain:";
            // 
            // numkP
            // 
            this.numkP.DecimalPlaces = 6;
            this.numkP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numkP.Location = new System.Drawing.Point(173, 43);
            this.numkP.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numkP.Name = "numkP";
            this.numkP.Size = new System.Drawing.Size(156, 31);
            this.numkP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "P Gain:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2458, 1202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pidChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PID Tuner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxIAccum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAccel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numkF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numkD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numkI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numkP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart pidChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numkP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numkI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numkD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaxIAccum;
        private System.Windows.Forms.NumericUpDown numIZone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numRamp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numVel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numAccel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numkF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesiredVal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAverageDev;
        private System.Windows.Forms.TextBox txtDeviation;
        private System.Windows.Forms.TextBox txtActualVal;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIAccum;
        private System.Windows.Forms.Button cmdClearIAccum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSysName;
        private System.Windows.Forms.NumericUpDown numSetpoint;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button cmdConnect;
    }
}

