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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edSpeedAtTheEndPointOutput = new System.Windows.Forms.Label();
            this.edMaxHeightOutput = new System.Windows.Forms.Label();
            this.edDistanceOutput = new System.Windows.Forms.Label();
            this.edTimestepOutput = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edTimestep = new System.Windows.Forms.NumericUpDown();
            this.edSquare = new System.Windows.Forms.NumericUpDown();
            this.edWeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btClean = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.edAngle = new System.Windows.Forms.NumericUpDown();
            this.edSpeed = new System.Windows.Forms.NumericUpDown();
            this.edHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTimestep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 3D;
            chartArea2.AxisX.Maximum = 30D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY.Maximum = 10D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 108);
            this.chart1.Name = "chart1";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series7.YValuesPerPoint = 4;
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series9.Legend = "Legend1";
            series9.Name = "Series3";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series10.Legend = "Legend1";
            series10.Name = "Series4";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series11.Legend = "Legend1";
            series11.Name = "Series5";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Color = System.Drawing.Color.Teal;
            series12.Legend = "Legend1";
            series12.Name = "Series6";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(905, 488);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edSpeedAtTheEndPointOutput);
            this.panel1.Controls.Add(this.edMaxHeightOutput);
            this.panel1.Controls.Add(this.edDistanceOutput);
            this.panel1.Controls.Add(this.edTimestepOutput);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.edTimestep);
            this.panel1.Controls.Add(this.edSquare);
            this.panel1.Controls.Add(this.edWeight);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btClean);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edAngle);
            this.panel1.Controls.Add(this.edSpeed);
            this.panel1.Controls.Add(this.edHeight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 111);
            this.panel1.TabIndex = 1;
            // 
            // edSpeedAtTheEndPointOutput
            // 
            this.edSpeedAtTheEndPointOutput.AutoSize = true;
            this.edSpeedAtTheEndPointOutput.Location = new System.Drawing.Point(789, 86);
            this.edSpeedAtTheEndPointOutput.Name = "edSpeedAtTheEndPointOutput";
            this.edSpeedAtTheEndPointOutput.Size = new System.Drawing.Size(23, 13);
            this.edSpeedAtTheEndPointOutput.TabIndex = 22;
            this.edSpeedAtTheEndPointOutput.Text = "null";
            // 
            // edMaxHeightOutput
            // 
            this.edMaxHeightOutput.AutoSize = true;
            this.edMaxHeightOutput.Location = new System.Drawing.Point(789, 66);
            this.edMaxHeightOutput.Name = "edMaxHeightOutput";
            this.edMaxHeightOutput.Size = new System.Drawing.Size(23, 13);
            this.edMaxHeightOutput.TabIndex = 21;
            this.edMaxHeightOutput.Text = "null";
            // 
            // edDistanceOutput
            // 
            this.edDistanceOutput.AutoSize = true;
            this.edDistanceOutput.Location = new System.Drawing.Point(789, 46);
            this.edDistanceOutput.Name = "edDistanceOutput";
            this.edDistanceOutput.Size = new System.Drawing.Size(23, 13);
            this.edDistanceOutput.TabIndex = 20;
            this.edDistanceOutput.Text = "null";
            // 
            // edTimestepOutput
            // 
            this.edTimestepOutput.AutoSize = true;
            this.edTimestepOutput.Location = new System.Drawing.Point(789, 26);
            this.edTimestepOutput.Name = "edTimestepOutput";
            this.edTimestepOutput.Size = new System.Drawing.Size(23, 13);
            this.edTimestepOutput.TabIndex = 19;
            this.edTimestepOutput.Text = "null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(628, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Speed at the end point:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(628, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Max Height:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Distance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Timestep:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(712, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Results:";
            // 
            // edTimestep
            // 
            this.edTimestep.DecimalPlaces = 3;
            this.edTimestep.Location = new System.Drawing.Point(293, 80);
            this.edTimestep.Name = "edTimestep";
            this.edTimestep.Size = new System.Drawing.Size(120, 20);
            this.edTimestep.TabIndex = 13;
            this.edTimestep.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // edSquare
            // 
            this.edSquare.DecimalPlaces = 2;
            this.edSquare.Location = new System.Drawing.Point(293, 53);
            this.edSquare.Name = "edSquare";
            this.edSquare.Size = new System.Drawing.Size(120, 20);
            this.edSquare.TabIndex = 12;
            this.edSquare.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // edWeight
            // 
            this.edWeight.DecimalPlaces = 1;
            this.edWeight.Location = new System.Drawing.Point(293, 24);
            this.edWeight.Name = "edWeight";
            this.edWeight.Size = new System.Drawing.Size(120, 20);
            this.edWeight.TabIndex = 11;
            this.edWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Timestep:";
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(445, 65);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(75, 37);
            this.btClean.TabIndex = 9;
            this.btClean.Text = "Отчистить";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(445, 24);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 35);
            this.btStart.TabIndex = 8;
            this.btStart.Text = "Пуск";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edAngle
            // 
            this.edAngle.Location = new System.Drawing.Point(81, 52);
            this.edAngle.Name = "edAngle";
            this.edAngle.Size = new System.Drawing.Size(120, 20);
            this.edAngle.TabIndex = 7;
            this.edAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // edSpeed
            // 
            this.edSpeed.Location = new System.Drawing.Point(81, 79);
            this.edSpeed.Name = "edSpeed";
            this.edSpeed.Size = new System.Drawing.Size(120, 20);
            this.edSpeed.TabIndex = 6;
            this.edSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // edHeight
            // 
            this.edHeight.Location = new System.Drawing.Point(81, 24);
            this.edHeight.Name = "edHeight";
            this.edHeight.Size = new System.Drawing.Size(120, 20);
            this.edHeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Square:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            ((System.ComponentModel.ISupportInitialize)(this.edTimestep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edAngle;
        private System.Windows.Forms.NumericUpDown edSpeed;
        private System.Windows.Forms.NumericUpDown edHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label edSpeedAtTheEndPointOutput;
        private System.Windows.Forms.Label edMaxHeightOutput;
        private System.Windows.Forms.Label edDistanceOutput;
        private System.Windows.Forms.Label edTimestepOutput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown edTimestep;
        private System.Windows.Forms.NumericUpDown edSquare;
        private System.Windows.Forms.NumericUpDown edWeight;
        private System.Windows.Forms.Timer timer1;
    }
}

