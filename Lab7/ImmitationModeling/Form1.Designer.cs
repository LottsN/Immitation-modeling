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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.populationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edAverageWaterPolutionLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.edDeathRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btClean = new System.Windows.Forms.Button();
            this.edFishBirthRate = new System.Windows.Forms.NumericUpDown();
            this.btCalculate = new System.Windows.Forms.Button();
            this.edFishPopultionNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numberOfStoresChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averageCatchChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.populationChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edAverageWaterPolutionLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDeathRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFishBirthRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFishPopultionNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStoresChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageCatchChart)).BeginInit();
            this.SuspendLayout();
            // 
            // populationChart
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.populationChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.populationChart.Legends.Add(legend1);
            this.populationChart.Location = new System.Drawing.Point(7, 129);
            this.populationChart.Name = "populationChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.EmptyPointStyle.Name = "ser";
            series1.LabelFormat = "0.00";
            series1.Legend = "Legend1";
            series1.Name = "Fish popultion";
            series1.YValuesPerPoint = 4;
            this.populationChart.Series.Add(series1);
            this.populationChart.Size = new System.Drawing.Size(436, 366);
            this.populationChart.TabIndex = 0;
            this.populationChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edAverageWaterPolutionLevel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.edDeathRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btClean);
            this.panel1.Controls.Add(this.edFishBirthRate);
            this.panel1.Controls.Add(this.btCalculate);
            this.panel1.Controls.Add(this.edFishPopultionNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 123);
            this.panel1.TabIndex = 1;
            // 
            // edAverageWaterPolutionLevel
            // 
            this.edAverageWaterPolutionLevel.Location = new System.Drawing.Point(165, 82);
            this.edAverageWaterPolutionLevel.Name = "edAverageWaterPolutionLevel";
            this.edAverageWaterPolutionLevel.Size = new System.Drawing.Size(120, 20);
            this.edAverageWaterPolutionLevel.TabIndex = 17;
            this.edAverageWaterPolutionLevel.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Water polution level(%):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edDeathRate
            // 
            this.edDeathRate.DecimalPlaces = 2;
            this.edDeathRate.Location = new System.Drawing.Point(368, 84);
            this.edDeathRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edDeathRate.Name = "edDeathRate";
            this.edDeathRate.Size = new System.Drawing.Size(120, 20);
            this.edDeathRate.TabIndex = 15;
            this.edDeathRate.Value = new decimal(new int[] {
            65,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Death Rate:";
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(954, 45);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(324, 53);
            this.btClean.TabIndex = 13;
            this.btClean.Text = "Clean";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // edFishBirthRate
            // 
            this.edFishBirthRate.DecimalPlaces = 2;
            this.edFishBirthRate.Location = new System.Drawing.Point(368, 45);
            this.edFishBirthRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edFishBirthRate.Name = "edFishBirthRate";
            this.edFishBirthRate.Size = new System.Drawing.Size(120, 20);
            this.edFishBirthRate.TabIndex = 12;
            this.edFishBirthRate.Value = new decimal(new int[] {
            58,
            0,
            0,
            131072});
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(568, 45);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(336, 53);
            this.btCalculate.TabIndex = 8;
            this.btCalculate.Text = "Start/Stop";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // edFishPopultionNumber
            // 
            this.edFishPopultionNumber.Location = new System.Drawing.Point(165, 44);
            this.edFishPopultionNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edFishPopultionNumber.Name = "edFishPopultionNumber";
            this.edFishPopultionNumber.Size = new System.Drawing.Size(120, 20);
            this.edFishPopultionNumber.TabIndex = 7;
            this.edFishPopultionNumber.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Initial Parameters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fish popultion:";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numberOfStoresChart
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.numberOfStoresChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.numberOfStoresChart.Legends.Add(legend2);
            this.numberOfStoresChart.Location = new System.Drawing.Point(449, 129);
            this.numberOfStoresChart.Name = "numberOfStoresChart";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.EmptyPointStyle.Name = "ser";
            series2.LabelFormat = "0.00";
            series2.Legend = "Legend1";
            series2.Name = "Number of stores";
            series2.YValuesPerPoint = 4;
            this.numberOfStoresChart.Series.Add(series2);
            this.numberOfStoresChart.Size = new System.Drawing.Size(436, 366);
            this.numberOfStoresChart.TabIndex = 4;
            this.numberOfStoresChart.Text = "chart1";
            // 
            // averageCatchChart
            // 
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.averageCatchChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.averageCatchChart.Legends.Add(legend3);
            this.averageCatchChart.Location = new System.Drawing.Point(891, 129);
            this.averageCatchChart.Name = "averageCatchChart";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.LimeGreen;
            series3.EmptyPointStyle.Name = "ser";
            series3.LabelFormat = "0.00";
            series3.Legend = "Legend1";
            series3.Name = "Average catch";
            series3.YValuesPerPoint = 4;
            this.averageCatchChart.Series.Add(series3);
            this.averageCatchChart.Size = new System.Drawing.Size(436, 366);
            this.averageCatchChart.TabIndex = 5;
            this.averageCatchChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 507);
            this.Controls.Add(this.averageCatchChart);
            this.Controls.Add(this.numberOfStoresChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.populationChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.populationChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edAverageWaterPolutionLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDeathRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFishBirthRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFishPopultionNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStoresChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.averageCatchChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart populationChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edFishPopultionNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.NumericUpDown edFishBirthRate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.NumericUpDown edDeathRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edAverageWaterPolutionLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart numberOfStoresChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart averageCatchChart;
    }
}

