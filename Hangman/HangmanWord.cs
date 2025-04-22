using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HangmanWord
    {
        public string Word { get; set; }
        public HashSet<char> AllLetters { get; set; }
        public HashSet<char> WordLetters { get; set; }
        public int FailedAttempts { get; set; }
        public int MaxFailedAttempts { get; set; }
        public int SecondsLeft { get; set; }

        public HangmanWord(string word, int maxFailedAttempts)
        {
            Word = word;
            WordLetters = new HashSet<char>();
            foreach (char c in Word)
            {
                WordLetters.Add(char.ToLower(c));
            }
            AllLetters = new HashSet<char>();
            FailedAttempts = 0;
            MaxFailedAttempts = maxFailedAttempts;
            SecondsLeft = 120;
        }

        public bool Win()
        {
            return WordLetters.Count == 0;
        }

        public bool Lose()
        {
            return FailedAttempts == MaxFailedAttempts || SecondsLeft == 0;
        }

        public bool GameOver()
        {
            return Win() || Lose();
        }

        public String Timer()
        {
            return $"{SecondsLeft / 60}:{SecondsLeft % 60}";
        }

        public int TrialsUsed()
        {
            return (int)Math.Ceiling(100.0 * FailedAttempts / MaxFailedAttempts);
        }

        public string MaskedWord()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in Word)
            {
                char letter = char.ToLower(c);
                if (WordLetters.Contains(letter))
                {
                    sb.Append("_");
                }
                else
                {
                    sb.Append(c);
                }
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public string MaskedAlphabet()
        {
            StringBuilder sb = new StringBuilder();
            for (char c = 'a'; c <= 'z'; c++)
            {
                if (AllLetters.Contains(c))
                {
                    sb.Append(char.ToUpper(c));
                }
                else
                {
                    sb.Append("_");
                }
                sb.Append(" ");
            }
            return sb.ToString();
        }

        public void Guess(char letter)
        {
            if (WordLetters.Contains(char.ToLower(letter)))
            {
                WordLetters.Remove(char.ToLower(letter));
            }
            else if (!AllLetters.Contains(char.ToLower(letter)))
            {
                FailedAttempts++;
            }
            AllLetters.Add(char.ToLower(letter));
        }
    }
}
