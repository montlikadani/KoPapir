using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StPap {
    public partial class Form1 : Form {

        private readonly List<Game> games;

        public Form1() {
            InitializeComponent();

            string[] split = Properties.Resources.jatek.Split('\n');

            games = new List<Game>(split.Length);

            foreach (string one in split) {
                string[] arr = one.Split('-');

                games.Add(new Game(int.Parse(arr[0]), int.Parse(arr[1])));
            }

            tovabbiJatekok.Text = "További játékok száma: " + games.Count;
            specsf.Text += "\n1 - papír\n2 - olló";
            Stats();
        }

        private void Selection_TextChanged(object sender, EventArgs e) {
            eredmeny.Hide();

            if (!IsBetween(firstSelection.Text, out int first) || !IsBetween(secondSelection.Text, out int second)) {
                return;
            }

            Game game = new Game(first, second);
            games.Add(game);

            tovabbiJatekok.Text = "További játékok száma: " + games.Count;
            eredmeny.Show();
            eredmeny.Text = $"Eredmény kódolva (0-döntetlen, 1-első nyert, 2-második nyert):{game.winner}";
            Stats();
        }

        private bool IsBetween(string input, out int res) {
            return int.TryParse(input, out res) && res >= 0 && res < 3;
        }

        private void Stats() {
            string dontetlen = string.Format("{0,29}", $"Döntetlenek: {games.Where(game => game.winner == 0).Count()} db");
            string elso = string.Format("{0,36}", $"Első játékos nyert: {games.Where(game => game.winner == 1).Count()} db");
            string masodik = string.Format("{0,39}", $"Második játékos nyert: {games.Where(game => game.winner == 2).Count()} db");

            statsText.Text = $"Statisztika\n{dontetlen}\n{elso}\n{masodik}";
        }

        private sealed class Game {

            public readonly int winner;

            public Game(int firstPlayerDecision, int secondPlayerDecision) {
                winner = new int[,] {
                    { 0, 2, 1 },
                    { 1, 0, 2 },
                    { 2, 1, 0 }
                }[firstPlayerDecision, secondPlayerDecision];
            }
        }
    }
}
