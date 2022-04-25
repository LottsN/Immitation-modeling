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

        //начальные значения хранилищ
        private int POF = 10000; // популяция рыбы
        private int NOS = 100; // количество магазинов для рыбалки

        //параметры
        private int DT = 1; // шаг по времени
        private double[] SC = new double[] { 0.1, 0.1, 0.25, 0.4, 0.7, 0.8, 0.65, 0.6, 0.4, 0.2, 0.1, 0.1 };  // сезонный коэффициент рождаемости
        private double[] CR = new double[] { 0.35, 0.38, 0.4, 0.6, 0.85, 0.89, 0.74, 0.64, 0.59, 0.46, 0.37, 0.36 }; // сезонный коэффициент улова
        private const double BR = 0.58; // доля рождаемости
        private const double DR = 0.65; // доля смертности
        private const int ISBA = 10; // количество открывшихся филиалов международного магазина рыболовных товаров
        private const int DELP = 2;  // степень запаздывания популярности
        private const int DELD = 10; // степень запаздывания загрязнения водовемов 
        private const int DELO = 10; // степень запаздывания открытия магазинов
        private int ALWP = 20; // средний уровень загрязнения водоемов


        // переменные
        private double _afc, // средний улов
                       _wpl, // уровень загрязнения водоемов
                       _fbr, // темп рождаемости рыбы
                       _fdr, // темп смертности рыбы
                       _fpl, // уровень популярности рыбалки
                       _nfas, // количество проданных рыболовных принадлежностей
                       _dfa, // спрос на рыболовные принадлежности
                       _pos; // темп открытия магазинов





        private Random rnd = new Random();

        //графики
        //populationChart
        //numberOfStoresChart
        //averageCatchChart


        bool hadRun = false;

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (!hadRun)
                {
                    POF = (int)edFishPopultionNumber.Value;
                    _fbr = (double)edFishBirthRate.Value;
                    _fdr = (double)edDeathRate.Value;
                    ALWP = (int)edAverageWaterPolutionLevel.Value;
                    //очистка графиков
                    populationChart.Series[0].Points.Clear();
                    populationChart.ChartAreas[0].AxisX.Minimum = 0;
                    numberOfStoresChart.Series[0].Points.Clear();
                    numberOfStoresChart.ChartAreas[0].AxisX.Minimum = 0;
                    averageCatchChart.Series[0].Points.Clear();
                    averageCatchChart.ChartAreas[0].AxisX.Minimum = 0;

                    populationChart.Series[0].Points.AddXY(0, POF);
                    numberOfStoresChart.Series[0].Points.AddXY(0, NOS);
                    averageCatchChart.Series[0].Points.AddXY(0, _afc);

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
            DT = 1;

            populationChart.Series[0].Points.Clear();
            numberOfStoresChart.Series[0].Points.Clear();
            averageCatchChart.Series[0].Points.Clear();

            hadRun = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            _nfas = 100 * NOS;
            _afc = POF * CR[DT % 12] / _nfas;
            _fpl = 100 + _afc / (100 * DELP);
            _wpl = ALWP + _fpl / DELD;
            _fbr = (POF * (BR * SC[DT % 12]));
            _fdr = (POF * (DR * _wpl / 100));

            _dfa = 0.7 * _fpl;
            _pos = 0.4 * _dfa / DELO;
            POF += Convert.ToInt32(_fbr - _fdr);
            NOS += Convert.ToInt32(_pos) - rnd.Next(5, 13);
            if (rnd.Next(0, 100) < 50) NOS += ISBA;

            populationChart.Series[0].Points.AddXY(DT, POF);
            numberOfStoresChart.Series[0].Points.AddXY(DT, NOS);
            averageCatchChart.Series[0].Points.AddXY(DT, _afc);

            DT++;
        }
    }
}
