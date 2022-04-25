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
        const int probsAmount = 5;
        int numberOfTrails;
        double value, sum, mathExp, empMathExp, D, empD, average, variance, chi_squared;
        double[] probs = new double[probsAmount];
        double[] emp_probs = new double[probsAmount];

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        int[] freq = new int[probsAmount];

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
            freq[0] = 0;
            freq[1] = 0;
            freq[2] = 0;
            freq[3] = 0;
            freq[4] = 0;
            chart1.Series[0].Points.Clear();
            edRes1.Text = "null";
            edRes2.Text = "null";
            edRes3.Text = "null";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            freq[0] = 0;
            freq[1] = 0;
            freq[2] = 0;
            freq[3] = 0;
            freq[4] = 0;
            chart1.Series[0].Points.Clear();
            edRes1.Text = "null";
            edRes2.Text = "null";
            edRes3.Text = "null";

            probs[0] = (double)edProb1.Value;
            probs[1] = (double)edProb2.Value;
            probs[2] = (double)edProb3.Value;
            probs[3] = (double)edProb4.Value;


            if ( (probs[0] + probs[1] + probs[2] + probs[3]) > 1.00)
            {
                MessageBox.Show(
                    "Sum of probabilities can't be greater than one",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            probs[4] = 1.00 - probs[0] - probs[1] - probs[2] - probs[3];

            /*
            if ( (prob1 + prob2 + prob3 + prob4 + prob5) != 1.00 )
            {
                MessageBox.Show(
                    "Sum of probabilities must equals one",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            */

            numberOfTrails = (int)edNumberOfTrials.Value;

            
            for (int i = 0; i < numberOfTrails; i++)
            {
                value = random.NextDouble();
                sum = 0.00;
                for (int k = 0; k < probsAmount; k++)
                { 
                    if (sum <= value && value < sum + probs[k] )
                    {
                        //Console.WriteLine(i.ToString() + " SUM: " + sum.ToString() + " ;VALUE: " + value.ToString() + " ;NEXT_SUM: " + (sum + probs[k]).ToString() + " ;k: " + k.ToString()) ;
                        freq[k]++;
                    }
                    sum += probs[k];
                }
            }

            emp_probs[0] = (double)freq[0] / numberOfTrails;
            emp_probs[1] = (double)freq[1] / numberOfTrails;
            emp_probs[2] = (double)freq[2] / numberOfTrails;
            emp_probs[3] = (double)freq[3] / numberOfTrails;
            emp_probs[4] = (double)freq[4] / numberOfTrails;

            mathExp = 0;
            empMathExp = 0;
            //math exp
            for (int i = 0; i < probsAmount; i++)
            {
                mathExp += (i+1) * probs[i];
                empMathExp += (i+1)* emp_probs[i];
            }
            average = Math.Abs(mathExp / empMathExp - 1) * 100;

            D = 0;
            empD = 0;
            //dispersion
            for (int i = 0; i < probsAmount; i++)
            {
                D += probs[i] * (i + 1 - mathExp) * (i + 1 - mathExp);
                empD += emp_probs[i] * (i + 1 - empMathExp) * (i + 1 - empMathExp);
            }
            if (empD == 0)
            {
                variance = 0;
            }
            else
            {
                variance = Math.Abs(D / empD - 1) * 100;
            }

            chi_squared = 0;
            for (int i = 0; i < probsAmount; i++)
            {
                if (probs[i] != 0)
                {
                    chi_squared += (freq[i] * freq[i]) / (numberOfTrails * probs[i]);
                }
            }

            chi_squared -= numberOfTrails;

            Console.WriteLine(" chi: " + chi_squared.ToString() );

            edRes1.Text = $"{empMathExp} (error = {Math.Round(average, 2)}%)";
            edRes2.Text = $"{empD} (error = {Math.Round(variance, 2)}%)";
            edRes3.Text = $"{Math.Round(chi_squared, 2)} > 9.488 is ";
            if (chi_squared > 9.488)
            {
                edVerdict.Text = "true";
                edVerdict.ForeColor = Color.Red;
            }
            else
            {
                edVerdict.Text = "false";
                edVerdict.ForeColor = Color.Green;
            }
            

            chart1.Series[0].Points.AddXY(1, emp_probs[0]);
            chart1.Series[0].Points.AddXY(2, emp_probs[1]);
            chart1.Series[0].Points.AddXY(3, emp_probs[2]);
            chart1.Series[0].Points.AddXY(4, emp_probs[3]);
            chart1.Series[0].Points.AddXY(5, emp_probs[4]);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
