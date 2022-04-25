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

        const double g = 9.81;
        const double C = 0.15;
        const double r = 1.29;
        double dt = 0.1;
        double x, y0, y, v, a, t, m,S, vx, vy, vx_old, vy_old, max_height, distance, end_speed;

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btClean_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                chart1.Series[3].Points.Clear();
                chart1.Series[4].Points.Clear();
                chart1.Series[5].Points.Clear();
            }
        }

        int seriesNumber = 0;

        double sina, cosa, beta, k;

        private void btStart_Click(object sender, EventArgs e)
        {
                y0 = (double)edHeight.Value;
                a = (double)edAngle.Value;
                v = (double)edSpeed.Value; 
                m = (double)edWeight.Value;
                S = (double)edSquare.Value;
                dt = (double)edTimestep.Value;
                max_height = 0;
                distance = 0;
                end_speed = 0;

                sina = Math.Sin(a * Math.PI / 180);
                cosa = Math.Cos(a * Math.PI / 180);
                vx = v * cosa;
                vy = v * sina;

                beta = 0.5 * C * S * r;
                k = beta / m;

                t = 0;
                x = 0;
                y = y0;

                chart1.Series[ seriesNumber % 6 ].Points.AddXY(x, y);

                timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vx_old = vx;
            vy_old = vy;

            t = t + dt;

            double sqr = Math.Sqrt(vx * vx + vy * vy);
            vx = vx_old - k * vx_old * sqr * dt;
            vy = vy - (g + k * vy_old * sqr) * dt;

            if (y > max_height) max_height = y;
            distance = x;
            end_speed = sqr;
            //Console.WriteLine(chart1.Series[seriesNumber % 6].Points[chart1.Series[seriesNumber % 6].Points.Count - 1]);

            x = x + vx * dt;
            y = y + vy * dt;


            chart1.Series[seriesNumber % 6].Points.AddXY(x, y);

            if (y <= 0)
            {
                timer1.Stop();
                edTimestepOutput.Text = Math.Round(dt, 4).ToString();
                edDistanceOutput.Text = Math.Round(distance, 4).ToString();
                edMaxHeightOutput.Text = Math.Round(max_height, 4).ToString();
                edSpeedAtTheEndPointOutput.Text = Math.Round(end_speed, 4).ToString();
                seriesNumber++;
            }
        }
    }
}
