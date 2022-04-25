namespace ImmitationModeling
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edNumberOfTrials = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.edProb5 = new System.Windows.Forms.NumericUpDown();
            this.edProb4 = new System.Windows.Forms.NumericUpDown();
            this.edProb3 = new System.Windows.Forms.NumericUpDown();
            this.edProb2 = new System.Windows.Forms.NumericUpDown();
            this.edRes4 = new System.Windows.Forms.Label();
            this.edRes3 = new System.Windows.Forms.Label();
            this.edRes2 = new System.Windows.Forms.Label();
            this.edRes1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btClean = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.edProb1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.edRes5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edNumberOfTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Maximum = 6D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Interval = 0.05D;
            chartArea2.AxisY.Maximum = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chart1.Location = new System.Drawing.Point(0, 125);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(905, 471);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edRes5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.edNumberOfTrials);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.edProb5);
            this.panel1.Controls.Add(this.edProb4);
            this.panel1.Controls.Add(this.edProb3);
            this.panel1.Controls.Add(this.edProb2);
            this.panel1.Controls.Add(this.edRes4);
            this.panel1.Controls.Add(this.edRes3);
            this.panel1.Controls.Add(this.edRes2);
            this.panel1.Controls.Add(this.edRes1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btClean);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edProb1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 130);
            this.panel1.TabIndex = 1;
            // 
            // edNumberOfTrials
            // 
            this.edNumberOfTrials.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edNumberOfTrials.Location = new System.Drawing.Point(329, 85);
            this.edNumberOfTrials.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edNumberOfTrials.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edNumberOfTrials.Name = "edNumberOfTrials";
            this.edNumberOfTrials.Size = new System.Drawing.Size(92, 20);
            this.edNumberOfTrials.TabIndex = 28;
            this.edNumberOfTrials.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Number of trails:";
            // 
            // edProb5
            // 
            this.edProb5.DecimalPlaces = 2;
            this.edProb5.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edProb5.Location = new System.Drawing.Point(301, 59);
            this.edProb5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edProb5.Name = "edProb5";
            this.edProb5.Size = new System.Drawing.Size(120, 20);
            this.edProb5.TabIndex = 26;
            this.edProb5.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // edProb4
            // 
            this.edProb4.DecimalPlaces = 2;
            this.edProb4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edProb4.Location = new System.Drawing.Point(301, 32);
            this.edProb4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edProb4.Name = "edProb4";
            this.edProb4.Size = new System.Drawing.Size(120, 20);
            this.edProb4.TabIndex = 25;
            this.edProb4.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // edProb3
            // 
            this.edProb3.DecimalPlaces = 2;
            this.edProb3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edProb3.Location = new System.Drawing.Point(94, 87);
            this.edProb3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edProb3.Name = "edProb3";
            this.edProb3.Size = new System.Drawing.Size(120, 20);
            this.edProb3.TabIndex = 24;
            this.edProb3.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // edProb2
            // 
            this.edProb2.DecimalPlaces = 2;
            this.edProb2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edProb2.Location = new System.Drawing.Point(94, 61);
            this.edProb2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edProb2.Name = "edProb2";
            this.edProb2.Size = new System.Drawing.Size(120, 20);
            this.edProb2.TabIndex = 23;
            this.edProb2.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // edRes4
            // 
            this.edRes4.AutoSize = true;
            this.edRes4.Location = new System.Drawing.Point(789, 86);
            this.edRes4.Name = "edRes4";
            this.edRes4.Size = new System.Drawing.Size(23, 13);
            this.edRes4.TabIndex = 22;
            this.edRes4.Text = "null";
            // 
            // edRes3
            // 
            this.edRes3.AutoSize = true;
            this.edRes3.Location = new System.Drawing.Point(789, 66);
            this.edRes3.Name = "edRes3";
            this.edRes3.Size = new System.Drawing.Size(23, 13);
            this.edRes3.TabIndex = 21;
            this.edRes3.Text = "null";
            // 
            // edRes2
            // 
            this.edRes2.AutoSize = true;
            this.edRes2.Location = new System.Drawing.Point(789, 46);
            this.edRes2.Name = "edRes2";
            this.edRes2.Size = new System.Drawing.Size(23, 13);
            this.edRes2.TabIndex = 20;
            this.edRes2.Text = "null";
            // 
            // edRes1
            // 
            this.edRes1.AutoSize = true;
            this.edRes1.Location = new System.Drawing.Point(789, 26);
            this.edRes1.Name = "edRes1";
            this.edRes1.Size = new System.Drawing.Size(23, 13);
            this.edRes1.TabIndex = 19;
            this.edRes1.Text = "null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(628, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Freq. №4:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(628, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Freq. №3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Freq. №2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Freq. №1:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Frequencies:";
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(458, 73);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 37);
            this.btClean.TabIndex = 9;
            this.btClean.Text = "Отчистить";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(458, 32);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 35);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "Пуск";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edProb1
            // 
            this.edProb1.DecimalPlaces = 2;
            this.edProb1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.edProb1.Location = new System.Drawing.Point(94, 32);
            this.edProb1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edProb1.Name = "edProb1";
            this.edProb1.Size = new System.Drawing.Size(120, 20);
            this.edProb1.TabIndex = 5;
            this.edProb1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prob. №5:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prob. №4:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prob. №3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prob. №2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob. №1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(628, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Freq. №5:";
            // 
            // edRes5
            // 
            this.edRes5.AutoSize = true;
            this.edRes5.Location = new System.Drawing.Point(789, 109);
            this.edRes5.Name = "edRes5";
            this.edRes5.Size = new System.Drawing.Size(23, 13);
            this.edRes5.TabIndex = 30;
            this.edRes5.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edNumberOfTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edProb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edProb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Label edRes4;
        private System.Windows.Forms.Label edRes3;
        private System.Windows.Forms.Label edRes2;
        private System.Windows.Forms.Label edRes1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown edNumberOfTrials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edProb5;
        private System.Windows.Forms.NumericUpDown edProb4;
        private System.Windows.Forms.NumericUpDown edProb3;
        private System.Windows.Forms.NumericUpDown edProb2;
        private System.Windows.Forms.Label edRes5;
        private System.Windows.Forms.Label label12;
    }
}

