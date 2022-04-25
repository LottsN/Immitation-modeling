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

        const int cellSize = 10;
        const int cellAmountX = 120;
        const int cellAmountY = 60;
        int circle = 0;

        List<List<int>> dotsX = new List<List<int>>();
        List<List<int>> dotsY = new List<List<int>>();
        List<List<char>> dotsStatus = new List<List<char>>();
        List<List<char>> dotsStatus_tmp = new List<List<char>>();

        private void addRandomDots()
        {
            var rand = new Random();
            int randomValue = (int)edRandom.Value;

            for (int i = 0; i < randomValue; i++)
            {
                dotsStatus[rand.Next(0, cellAmountX)][rand.Next(0, cellAmountY)] = '1';
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
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

        private int calculateNeighbours(int x, int y)
        {
            
            int currentAliveNeighb = 0;

            //все внутренние точки +
            if (0 < x && x < cellAmountX - 1 && 0 < y && y < cellAmountY - 1)
            {
                if (dotsStatus[x - 1][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y + 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x][y + 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y + 1] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            //вверхняя левая +
            if (x == 0 && y == 0)
            {
                if (dotsStatus[x+1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x][y+1] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y + 1] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            //вверхняя правая + 
            if (x == cellAmountX - 1 && y == 0)
            {
                if (dotsStatus[x - 1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x][y + 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y + 1] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            //нижняя левая
            if (x == 0 && y == cellAmountY - 1)
            {
                if (dotsStatus[x][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y - 1] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            //нижняя правая
            if (x == cellAmountX - 1 && y == cellAmountY - 1)
            {
                if (dotsStatus[x][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y - 1] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            //рядом с левой границей
            if (x == 0)
            {
                if (dotsStatus[x][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y + 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x][y + 1] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            //рядом с верхней границей
            if (y == 0)
            {
                if (dotsStatus[x+1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y + 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x][y + 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y + 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            //рядом с правой границей
            if (x == cellAmountX - 1)
            {
                if (dotsStatus[x][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y + 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x][y + 1] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            //рядом с нижней границей
            if (y == cellAmountY - 1)
            {
                if (dotsStatus[x - 1][y] == '1') currentAliveNeighb++;
                if (dotsStatus[x - 1][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y - 1] == '1') currentAliveNeighb++;
                if (dotsStatus[x + 1][y] == '1') currentAliveNeighb++;
                return currentAliveNeighb;
            }

            return -1;
        }

        private char calculateCellState(int x, int y)
        {
            int aliveNeighbours = calculateNeighbours(x, y);

            if (aliveNeighbours == -1)
            {
                Console.WriteLine("ERROR IN CALCULATE CELL STATE");
                return '2';
            }
            //Console.WriteLine("STATE: " + dotsStatus[x][y] + "; NEIGHB: " + aliveNeighbours.ToString());
            if (aliveNeighbours < 2 && dotsStatus[x][y] == '1') return '0';
            if (aliveNeighbours == 2 && dotsStatus[x][y] == '1') return '1';
            if (aliveNeighbours == 3) return '1';
            if (aliveNeighbours > 3 && dotsStatus[x][y] == '1') return '0';

            return '2';
        }

        private void recalculatePoints()
        {
            circle++;
            edIteration.Text = circle.ToString();
            
            for (int y = 0; y < cellAmountY; y++)
            {
                for (int x = 0; x < cellAmountX; x++)
                {
                    dotsStatus[x][y] = calculateCellState(x, y);
                    //dotsStatus[x][y] = dotsStatus_tmp[y][x];
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
            addRandomDots();
            DrawMap();
            redrawPoints();
        }
    }
}
