using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImmitationModeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numberOfTrails, freq1 = 0, freq2 = 0, freq3 = 0, freq4 = 0, freq5 = 0;
        double prob1, prob2, prob3, prob4, prob5, value, res1, res2, res3, res4, res5;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        Random random = new Random();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btClean_Click(object sender, EventArgs e)
        {
            freq1 = 0;
            freq2 = 0;
            freq3 = 0;
            freq4 = 0;
            freq5 = 0;
            chart1.Series[0].Points.Clear();
            edRes1.Text = "null";
            edRes2.Text = "null";
            edRes3.Text = "null";
            edRes4.Text = "null";
            edRes5.Text = "null";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            freq1 = 0;
            freq2 = 0;
            freq3 = 0;
            freq4 = 0;
            freq5 = 0;
            chart1.Series[0].Points.Clear();
            edRes1.Text = "null";
            edRes2.Text = "null";
            edRes3.Text = "null";
            edRes4.Text = "null";
            edRes5.Text = "null";

            prob1 = (double)edProb1.Value;
            prob2 = (double)edProb2.Value;
            prob3 = (double)edProb3.Value;
            prob4 = (double)edProb4.Value;
            prob5 = (double)edProb5.Value;

            if (prob1 == 0) prob1 = random.NextDouble();
            if (prob2 == 0) prob2 = random.NextDouble();
            if (prob3 == 0) prob3 = random.NextDouble();
            if (prob4 == 0) prob4 = random.NextDouble();
            if (prob5 == 0) prob5 = random.NextDouble();

            numberOfTrails = (int)edNumberOfTrials.Value;

            
            for (int i = 0; i < numberOfTrails; i++)
            {
                value = random.NextDouble();
                if (value <= prob1) freq1++;
                if (value <= prob2) freq2++;
                if (value <= prob3) freq3++;
                if (value <= prob4) freq4++;
                if (value <= prob5) freq5++;
            }

            res1 = (double)freq1 / numberOfTrails;
            res2 = (double)freq2 / numberOfTrails;
            res3 = (double)freq3 / numberOfTrails;
            res4 = (double)freq4 / numberOfTrails;
            res5 = (double)freq5 / numberOfTrails;

            edRes1.Text = Math.Round(res1, 2).ToString();
            edRes2.Text = Math.Round(res2, 2).ToString();
            edRes3.Text = Math.Round(res3, 2).ToString();
            edRes4.Text = Math.Round(res4, 2).ToString();
            edRes5.Text = Math.Round(res5, 2).ToString();

            Console.WriteLine((res1).ToString());

            chart1.Series[0].Points.AddXY(1, res1 );
            chart1.Series[0].Points.AddXY(2, res2 );
            chart1.Series[0].Points.AddXY(3, res3 );
            chart1.Series[0].Points.AddXY(4, res4 );
            chart1.Series[0].Points.AddXY(5, res5 );

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
