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
        int firstTeamGoalAmount, secondTeamGoalAmount, tourNumber = 1;
        double value, sum, mathExp, empMathExp, D, empD, average, variance, chi_squared;
        List<List<Team>> teamsHistory = new List<List<Team>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

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
            edResultsTable.ResetText();
            currentTourData.Rows.Clear();
            championshipData.Rows.Clear();
            teamsHistory.Clear();
            tourNumber = 1;
        }

        private int GetFactorial(int number)
        {
            int finalnum = 1;
            for (int i = number; i > 0; i--)
            {
                finalnum = finalnum * i;
            }
            return finalnum;
        }

        private void calculateProbs(Team team)
        {
            var sumOfProbs = 0.0;
            for (int k = 0; k < team.getProbsAmount() - 1; k++)
            {
                team.probs[k] = Math.Pow(team.lambda, k) / GetFactorial(k) * Math.Exp(-team.lambda);
                sumOfProbs += team.probs[k];
            }
            team.probs[team.probs.Length - 1] = 1 -  sumOfProbs;
            return;
        }

        private void calculatePoints(Team team)
        {
            team.Points = 3 * team.Wins.Count + 1 * team.Draws.Count + 0 * team.Losses.Count;
        }

        public List<Team> sortTeams(List<Team> teams)
        {
            for (int i = 0; i < teams.Count; i++)
                for (int j = i; j < teams.Count; j++)
                    if (teams[i].Points < teams[j].Points)
                    {
                        var tmp = teams[i];
                        teams[i] = teams[j];
                        teams[j] = tmp;
                    }
                    else if (teams[i].Points == teams[j].Points)
                    {
                        if (teams[i].Losses.Contains(teams[j].name))
                        {
                            var tmp = teams[i];
                            teams[i] = teams[j];
                            teams[j] = tmp;
                        }  
                    }
            return teams;
        }

        public void updateHistory(List<List<Team>> teamsHistory, int teamsCount)
        {
            championshipData.Rows.Clear();
            List<TeamsStatistic>  all_teams_statistics = new List<TeamsStatistic>();
            for (int i = 0; i < teamsCount; i++)
            {
                var name = teamsHistory[0][i].name;
                var wins = 0;
                var losses = 0;
                var draws = 0;
                var points = 0;
                for (int j = 0; j < teamsHistory.Count; j++)
                {
                    wins += teamsHistory[j][i].Wins.Count;
                    losses += teamsHistory[j][i].Losses.Count;
                    draws += teamsHistory[j][i].Draws.Count;
                    points += teamsHistory[j][i].Points;
                }
                var statistics = new TeamsStatistic(
                    name,
                    wins,
                    losses,
                    draws,
                    points
                );
                all_teams_statistics.Add(statistics);
            }

            for (int i = 0; i < all_teams_statistics.Count; i++)
                for (int j = i; j < all_teams_statistics.Count; j++)
                    if (all_teams_statistics[i].Points < all_teams_statistics[j].Points)
                    {
                        var tmp = all_teams_statistics[i];
                        all_teams_statistics[i] = all_teams_statistics[j];
                        all_teams_statistics[j] = tmp;
                    }

            for (int i = 0; i < teamsCount; i++)
            {
                Console.WriteLine($"team: {all_teams_statistics[i].Name}, points: {all_teams_statistics[i].Points}");
                championshipData.Rows.Add(i + 1, all_teams_statistics[i].Name, all_teams_statistics[i].Wins, all_teams_statistics[i].Losses, all_teams_statistics[i].Draws, all_teams_statistics[i].Points);
            }
            championshipData.Rows[0].DefaultCellStyle.ForeColor = Color.Gold;
            championshipData.Rows[1].DefaultCellStyle.ForeColor = Color.White;
            championshipData.Rows[2].DefaultCellStyle.ForeColor = Color.DarkOrange;
            championshipData.Rows[3].DefaultCellStyle.ForeColor = Color.LightGray;
            championshipData.Rows[4].DefaultCellStyle.ForeColor = Color.LightGray;
            championshipData.Rows[5].DefaultCellStyle.ForeColor = Color.LightGray;
            championshipData.Rows[6].DefaultCellStyle.ForeColor = Color.LightGray;
            championshipData.Rows[7].DefaultCellStyle.ForeColor = Color.LightGray;
            edChampRes.Text = $"after {tourNumber} tours";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            edResultsTable.ResetText();
            Font selectionFont = new Font("Console", 11);
            edResultsTable.SelectionFont = selectionFont;
            edResultsTable.SelectionAlignment = HorizontalAlignment.Center;
            currentTourData.Rows.Clear();

            List<Team> teams = new List<Team>();
            teams.Add(new Team(1, "Real Madrid", (double)edRealMadrid.Value));
            teams.Add(new Team(2, "Chelsea", (double)edChelsea.Value));
            teams.Add(new Team(3, "Barcelona", (double)edBarcelona.Value));
            teams.Add(new Team(4, "Bayern", (double)edBayern.Value));
            teams.Add(new Team(5, "Zenit", (double)edZenit.Value));
            teams.Add(new Team(6, "Spartak", (double)edSpartak.Value));
            teams.Add(new Team(7, "PSG", (double)edPSG.Value));
            teams.Add(new Team(8, "Juventus", (double)edJuventus.Value));

            for (int i = 0; i < teams.Count; i++)
            {
                calculateProbs(teams[i]);
            }

            List<KeyValuePair<Team, Team>> teamsPairs = new List<KeyValuePair<Team, Team>>(); // prepare final result

            for (int i = 0; i < teams.Count; i++)
                for (int j = i + 1; j < teams.Count; j++)
                    if (j < teams.Count)
                        teamsPairs.Add(new KeyValuePair<Team, Team>(teams[i], teams[j]));

            edResultsTable.AppendText($"###### TOUR №{tourNumber} ######");
            //next round
            foreach (var pair in teamsPairs)
            {
                value = random.NextDouble();
                sum = 0.00;
                for (int k = 0; k < pair.Key.getProbsAmount(); k++)
                {
                    if (sum <= value && value < sum + pair.Key.probs[k])
                    {
                        firstTeamGoalAmount = k;
                        break;
                    }
                    sum += pair.Key.probs[k];
                }

                value = random.NextDouble();
                sum = 0.00;
                for (int j = 0; j < pair.Value.getProbsAmount(); j++)
                {
                    if (sum <= value && value < sum + pair.Value.probs[j])
                    {
                        secondTeamGoalAmount = j;
                        break;
                    }
                    sum += pair.Value.probs[j];
                }

                //teams played with each other
                pair.Key.Matches.Add(pair.Value.name);
                pair.Value.Matches.Add(pair.Key.name);

                //add results
                if (firstTeamGoalAmount > secondTeamGoalAmount)
                {
                    pair.Key.Wins.Add(pair.Value.name);
                    pair.Value.Losses.Add(pair.Key.name);
                }
                else if (firstTeamGoalAmount == secondTeamGoalAmount)
                {
                    pair.Key.Draws.Add(pair.Value.name);
                    pair.Value.Draws.Add(pair.Key.name);
                }
                else if (firstTeamGoalAmount < secondTeamGoalAmount)
                {
                    pair.Key.Losses.Add(pair.Value.name);
                    pair.Value.Wins.Add(pair.Key.name);
                }
                edResultsTable.AppendText(Environment.NewLine + pair.Key.name + $" {firstTeamGoalAmount}:{secondTeamGoalAmount} " + pair.Value.name);
            }

            for (int i = 0; i < teams.Count; i++)
            {
                calculatePoints(teams[i]);
            }
            List<Team> copy = new List<Team>();
            for (int i = 0; i < teams.Count; i++)
            {
                copy.Add(teams[i]);
            }
            teamsHistory.Add(copy);
            teams = sortTeams(teams);

            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine($"{teams[i].name}: {teams[i].Points}");
            }

            edResultsTable.AppendText(Environment.NewLine + $"TOUR WINNER: {teams[0].name}");
            tourNumber++;

            for (int i = 0; i < teams.Count; i++)
            {
               currentTourData.Rows.Add(i + 1, teams[i].name, teams[i].Wins.Count, teams[i].Losses.Count, teams[i].Draws.Count, teams[i].Points);
            }
            edTourRes.Text = $"Results of {tourNumber}th tour";
            updateHistory(teamsHistory, teams.Count);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }

    public class TeamsStatistic
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int Points { get; set; }

        public TeamsStatistic(string Name, int Wins, int Losses, int Draws, int Points)
        {
            this.Name = Name;
            this.Wins = Wins;
            this.Losses = Losses;
            this.Draws = Draws;
            this.Points = Points;
        }
    }
public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public double lambda { get; set; }
        public const int probsAmount = 7;
        public double[] probs;
        public List<string> Matches;
        public List<string> Wins;
        public List<string> Losses;
        public List<string> Draws;
        public int Points { get; set; }

        public Team(int id, string name, double lambda)
        {
            this.id = id;
            this.name = name;
            this.lambda = lambda;
            probs = new double[probsAmount];
            Matches = new List<string>();
            Wins = new List<string>();
            Losses = new List<string>();
            Draws = new List<string>();
            Points = 0;
        }

        public int getProbsAmount()
        {
            return probsAmount;
        }

        public void setPoints(int x)
        {
            this.Points = x;
        }

    }
}
