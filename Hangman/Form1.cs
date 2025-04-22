using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public List<String> Words = new List<string>()
        {
            "Argentina",
            "Macedonia",
            "Greece",
            "Quatar",
            "Iceland",
            "France",
            "Germany",
            "Austria",
            "Canada",
            "Netherlands",
            "Columbia"
        };

        public Random Random { get; set; }
        public HangmanWord Hangman { get; set; }
        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            Random = new Random();
            Hangman = new HangmanWord(Words[Random.Next(Words.Count)], 5);
            timer1.Enabled = true;
            timer1.Interval = 1000; // 1 second

            pbTimeLeft.Value = 100;
            pbTrialsLeft.Value = 0;
            lbWord.Text = Hangman.MaskedWord();
            tbGuessedLetters.Text = Hangman.MaskedAlphabet();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hangman.SecondsLeft--;
            lbTimer.Text = Hangman.Timer();
            int pbPercentage = (int)Math.Ceiling(100.0 * Hangman.SecondsLeft / 120.0);
            pbTimeLeft.Value = pbPercentage;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbLetter.Text.Length == 1)
            {
                Hangman.Guess(tbLetter.Text[0]);
                lbWord.Text = Hangman.MaskedWord();
                tbGuessedLetters.Text = Hangman.MaskedAlphabet();
                int trialsLeft = (int)Math.Ceiling(100.0 * Hangman.FailedAttempts / Hangman.MaxFailedAttempts);
                pbTrialsLeft.Value = trialsLeft;
            }
            tbLetter.Clear();
            if (Hangman.GameOver())
                GameStatus();
        }

        private void GameStatus()
        {
            timer1.Stop();
            if (Hangman.Win())
            {
                DialogResult dr = MessageBox.Show("Победивте. Дали сакате нова игра?", "Победа", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Start();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("Изгубивте. Дали сакате нова игра?", "Загуба", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    Start();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
