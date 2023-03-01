using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StPap {
    public partial class Form1 : Form {

        private readonly List<PeopleSelection> peopleSelections;

        public Form1() {
            InitializeComponent();

            string[] split = Properties.Resources.jatek.Split('\n');

            peopleSelections = new List<PeopleSelection>(split.Length);

            foreach (string one in split) {
                foreach (string selection in one.Split('-')) {
                    peopleSelections.Add(new PeopleSelection(int.Parse(selection)));
                }
            }

            tovabbiJatekok.Text = "További játékok száma: " + peopleSelections.Count / 2;
            specsf.Text += "\n1 - papír\n2 - olló";
            Stats();
        }

        private void Selection_TextChanged(object sender, EventArgs e) {
            eredmeny.Hide();

            if (!IsBetween(firstSelection.Text, out int first) || !IsBetween(secondSelection.Text, out int second)) {
                return;
            }

            PeopleSelection ps1 = new PeopleSelection(first);
            PeopleSelection ps2 = new PeopleSelection(second);

            peopleSelections.Add(ps1);
            peopleSelections.Add(ps2);

            PeopleSelection winner = ps1.CalculateWinner(ps2);

            SaveToFile();

            tovabbiJatekok.Text = "További játékok száma: " + peopleSelections.Count / 2;
            eredmeny.Show();
            eredmeny.Text = "Eredmény kódolva (0-döntetlen, 1-első nyert, 2-második nyert):";

            if (winner == null) {
                eredmeny.Text += "0";
            } else {
                eredmeny.Text += winner == ps1 ? "1" : "2";
            }

            Stats();
        }

        private bool IsBetween(string input, out int res) {
            return int.TryParse(input, out res) && res >= 0 && res < 3;
        }

        private void SaveToFile() {
            using (StreamWriter writer = File.CreateText("jatek.txt")) {
                foreach (PeopleSelection one in peopleSelections) {
                    writer.WriteLine($"{one.selection}-{2}");
                }
            }
        }

        private void Stats() {
            int dontetlenek = 0, elsoJatekos = 0, masodikJatekos = 0;

            for (int y = 0; y < peopleSelections.Count; y++) {
                PeopleSelection first = peopleSelections[y];
                PeopleSelection winner = first.CalculateWinner(peopleSelections[y++]);

                if (winner == null) {
                    dontetlenek++;
                } else if (winner == first) {
                    elsoJatekos++;
                } else {
                    masodikJatekos++;
                }
            }

            string dontetlen = string.Format("{0,30}", $"Döntetlenek: {dontetlenek} db");
            string elso = string.Format("{0,36}", $"Első játékos nyert: {elsoJatekos} db");
            string masodik = string.Format("{0,39}", $"Második játékos nyert: {masodikJatekos} db");

            statsText.Text = $"Statisztika\n{dontetlen}\n{elso}\n{masodik}";
        }

        private class PeopleSelection {

            public readonly int selection;

            public PeopleSelection(int selection) {
                this.selection = selection;
            }

            public PeopleSelection CalculateWinner(PeopleSelection another) {
                if (selection == another.selection) {
                    return null;
                }

                if (selection == 0) {
                    return another.selection == 1 ? another : this;
                }

                if (another.selection == 0) {
                    return selection == 1 ? this : another;
                }

                if (selection == 1) {
                    return another.selection == 2 ? another : this;
                }

                if (another.selection == 1) {
                    return selection == 2 ? this : another;
                }

                if (selection == 2) {
                    return another.selection == 1 ? this : another;
                }

                if (another.selection == 2) {
                    return selection == 1 ? another : this;
                }

                return null;
            }
        }
    }
}
