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
            this.panel1 = new System.Windows.Forms.Panel();
            this.edIteration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edRandom = new System.Windows.Forms.NumericUpDown();
            this.btClean = new System.Windows.Forms.Button();
            this.btCalculate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edIteration);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btRandom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edRandom);
            this.panel1.Controls.Add(this.btClean);
            this.panel1.Controls.Add(this.btCalculate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 1;
            // 
            // edIteration
            // 
            this.edIteration.AutoSize = true;
            this.edIteration.Location = new System.Drawing.Point(189, 55);
            this.edIteration.Name = "edIteration";
            this.edIteration.Size = new System.Drawing.Size(13, 13);
            this.edIteration.TabIndex = 18;
            this.edIteration.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Iteration: ";
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(232, 15);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(315, 53);
            this.btRandom.TabIndex = 16;
            this.btRandom.Text = "Add dots";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Amount of dots:";
            // 
            // edRandom
            // 
            this.edRandom.Location = new System.Drawing.Point(142, 15);
            this.edRandom.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.edRandom.Name = "edRandom";
            this.edRandom.Size = new System.Drawing.Size(60, 20);
            this.edRandom.TabIndex = 14;
            this.edRandom.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(875, 15);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(315, 53);
            this.btClean.TabIndex = 13;
            this.btClean.Text = "Clean";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(554, 15);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(315, 53);
            this.btCalculate.TabIndex = 8;
            this.btCalculate.Text = "Start/Stop";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 80);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1200, 600);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edRandom;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label edIteration;
    }
}

