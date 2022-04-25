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

        const double k = 0.20;
        double DollarPrice, EuroPrice;
        bool hadRun = false;
        double T = 0;
        Random rnd = new Random();

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (!hadRun)
                {
                    chart1.Series[0].Points.Clear();
                    chart1.Series[1].Points.Clear();
                    chart1.ChartAreas[0].AxisX.Minimum = 0;

                    DollarPrice = (double)edDollarPrice.Value;
                    EuroPrice = (double)edEuroPrice.Value;

                    chart1.Series[0].Points.AddXY(0, DollarPrice);
                    chart1.Series[1].Points.AddXY(0, EuroPrice);
                    hadRun = true;
                    timer1.Start();
                }
                else
                {

                    timer1.Start();
                }

            }
            else
            {
                timer1.Stop();
            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            T = 0;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            hadRun = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            T = T + 1;
            DollarPrice = DollarPrice * (1 + k * (rnd.NextDouble() - 0.5));
            EuroPrice = EuroPrice * (1 + k * (rnd.NextDouble() - 0.5));

            chart1.Series[0].Points.AddXY(T, DollarPrice);
            chart1.Series[1].Points.AddXY(T, EuroPrice);
            if (chart1.Series[0].Points.Count >= 30) 
            {
                chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points.Count - 30;
            }
        }
    }
}
