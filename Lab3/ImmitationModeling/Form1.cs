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
            createDots();
            DrawMap();
        }

        const int cellSize = 5;
        const int cellAmountX = 240;
        const int cellAmountY = 120;
        int rule;
        int circle = 0;
        Dictionary<string, char> rulesBook = new Dictionary<string, char>();

        List<List<int>> dotsX = new List<List<int>>();
        List<List<int>> dotsY = new List<List<int>>();
        List<List<char>> dotsStatus = new List<List<char>>();
        List<List<char>> dotsStatus_tmp = new List<List<char>>();

        private void addRandomDots()
        {
            var rand = new Random();
            for (int i = 0; i < dotsStatus.Count; i++)
            {
                if (rand.Next(1, 101) <= 50)
                {
                    dotsStatus[i][0] = '1';
                }
                else
                {
                    dotsStatus[i][0] = '0';
                }
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                rulesBook.Clear();
            }
            else
            {
                timer1.Start();
                rule = (int)edRule.Value;
                string binary = Convert.ToString(rule, 2);
                string key;
                while (binary.Length < 8)
                {
                    binary = "0" + binary;
                }
                Console.WriteLine(binary);
                string binary_copy = binary;

                for (int i = binary_copy.Length - 1; i >= 0; i--)
                {
                    key = Convert.ToString(i, 2);
                    while (key.Length < 3)
                    {
                        key = "0" + key;
                    }
                    rulesBook.Add(key, binary_copy[binary_copy.Length - 1 - i]);
                }
                rulesBook.ToList().ForEach(x => Console.WriteLine(x.Key + "  " + x.Value));
            }
        }

        private void renewDots()
        {
            circle = 0;
            dotsX = new List<List<int>>();
            dotsY = new List<List<int>>();
            dotsStatus = new List<List<char>>();
            dotsStatus_tmp = new List<List<char>>();
            createDots();
            rulesBook.Clear();
        }

        private void createDots()
        {
            
            for (int i = 0; i < cellAmountX; i++)
            {
                List<int> tmpX = new List<int>();
                List<int> tmpY = new List<int>();
                List<char> tmpStatus = new List<char>();
                for (int k = 0; k < cellAmountY; k++)
                {
                    tmpX.Add(i * cellSize);
                    tmpY.Add(k * cellSize);
                    tmpStatus.Add('0');
                }
                dotsX.Add(tmpX);
                dotsY.Add(tmpY);
                dotsStatus.Add(tmpStatus);
            }
        }

        private void DrawMap()
        {
            
            Bitmap bmp = new Bitmap(1200, 600);
            Graphics graphic = Graphics.FromImage(bmp);
            Pen pencil = new Pen(Color.Black, Width = 1);

            this.Size = new Size(1216, 719);

            for (int i = 0; i < bmp.Width; i++)
            {
                if (i % cellSize == 0)
                { 
                    graphic.DrawLine(pencil, i, 0, i, bmp.Height);
                }
            }
            
            for (int i = 0; i < bmp.Height; i++)
            {

                if (i % cellSize == 0)
                {
                    graphic.DrawLine(pencil, 0, i, bmp.Width, i);
                }
            }
            
            graphic.DrawLine(pencil, bmp.Width, 0, bmp.Width, bmp.Height);
            graphic.DrawLine(pencil, 0, bmp.Height, bmp.Width, bmp.Height);
            
            pictureBox.Image = bmp;
        }

        private void recalculatePoints()
        {
            circle++;
            edIteration.Text = circle.ToString();
            List<char> tmp_dotsLine = new List<char>();

            //важно для первого прохода
            int y_line = (circle % cellAmountY) - 1;
            if (y_line < 0) y_line = 0;

            if (circle > cellAmountY - 1)
            {
                
                if (circle == cellAmountY)
                {
                    for (int i = 0; i < cellAmountX; i++)
                    {
                        if (dotsStatus[i][0] == '0')
                        {
                            tmp_dotsLine.Add('0');
                        }
                        else
                        {
                            tmp_dotsLine.Add('1');
                        }
                    }
                    dotsStatus_tmp.Insert(0, tmp_dotsLine.GetRange(0, cellAmountX));
                    tmp_dotsLine.Clear();

                }
                //первая
                tmp_dotsLine.Add(rulesBook[("" + dotsStatus[cellAmountX - 1][cellAmountY - 1] + dotsStatus[0][cellAmountY - 1] + dotsStatus[1][cellAmountY - 1])]);

                for (int i = 1; i < cellAmountX - 1; i++)
                {
                    tmp_dotsLine.Add( rulesBook[("" + dotsStatus[i - 1][cellAmountY - 1] + dotsStatus[i][cellAmountY - 1] + dotsStatus[i + 1][cellAmountY - 1])] );
                }

                //последняя
                tmp_dotsLine.Add(rulesBook[("" + dotsStatus[cellAmountX - 2][cellAmountY - 1] + dotsStatus[cellAmountX - 1][cellAmountY - 1] + dotsStatus[0][cellAmountY - 1])]);

                dotsStatus_tmp.Add(tmp_dotsLine);
                dotsStatus_tmp = dotsStatus_tmp.GetRange(1, cellAmountY);

                for (int y = 0; y < cellAmountY; y++)
                {
                    for (int x = 0; x < cellAmountX; x++)
                    {
                        dotsStatus[x][y] = dotsStatus_tmp[y][x];
                    }
                }
            }
            else
            {
                tmp_dotsLine.Add(rulesBook[("" + dotsStatus[cellAmountX - 1][y_line] + dotsStatus[0][y_line] + dotsStatus[1][y_line])]);

                for (int i = 1; i < cellAmountX - 1; i++)
                {
                    tmp_dotsLine.Add(rulesBook[("" + dotsStatus[i - 1][y_line] + dotsStatus[i][y_line] + dotsStatus[i + 1][y_line])]);
                }

                tmp_dotsLine.Add(rulesBook[("" + dotsStatus[cellAmountX - 2][y_line] + dotsStatus[cellAmountX - 1][y_line] + dotsStatus[0][y_line])]);

                dotsStatus_tmp.Add(tmp_dotsLine);

                for (int y = 0; y < circle; y++)
                {
                    for (int x = 0; x < cellAmountX; x++)
                    {
                        dotsStatus[x][y + 1] = dotsStatus_tmp[y][x];
                    }
                }
            }
        }

        private void redrawPoints()
        {
            Bitmap bmp = (Bitmap)pictureBox.Image;
            Graphics graphic = Graphics.FromImage(bmp);
            for (int i = 0; i < cellAmountX; i++)
            {
                for (int k = 0; k < cellAmountY; k++)
                {
                    if (dotsStatus[i][k] == '1')
                    {
                        Brush GroundBrush = new SolidBrush(Color.Green);
                        graphic.FillRectangle(GroundBrush, dotsX[i][k] + 1, dotsY[i][k] + 1, cellSize - 1, cellSize - 1);
                    }
                    else
                    {
                        Brush GroundBrush = new SolidBrush(Color.White);
                        graphic.FillRectangle(GroundBrush, dotsX[i][k] + 1, dotsY[i][k] + 1, cellSize - 1, cellSize - 1);
                    }

                }
            }
            pictureBox.Image = bmp;
        }


        private void btClean_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                edIteration.Text = "0";
                renewDots();
                DrawMap();
            }
            else
            {
                edIteration.Text = "0";
                renewDots();
                DrawMap();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            recalculatePoints();
            redrawPoints();
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                edIteration.Text = "0";
                renewDots();
                addRandomDots();
                DrawMap();
                redrawPoints();
            }
            else
            {
                edIteration.Text = "0";
                renewDots();
                addRandomDots();
                DrawMap();
                redrawPoints();
            }
        }
    }
}
