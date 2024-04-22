using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Board
    {
        private List<string> line0 = new List<string> { "-", "-", "-", "|" };
        private List<string> line1 = new List<string> { "|", " ", " ", " " };
        private List<string> line2 = new List<string> { "|", " ", " ", " " };
        private List<string> line3 = new List<string> { "|", " ", " ", " " };
        private List<string> line4 = new List<string> { "|", " ", " ", " " };
        private List<string> line5 = new List<string> { "|", " ", " ", " " };
        private List<string> line6 = new List<string> { "|", " ", " ", " " };
        private List<string> line7 = new List<string> { "-", " ", " ", " " };

        public List<string> guessingBoard = new List<string> { "_", };

        public List<List<string>> board;

        public Board()
        {
            board = new List<List<string>>
            {
                line0,
                line1,
                line2,
                line3,
                line4,
                line5,
                line6,
                line7
            };
        }

        public void UpdateHangman(int attemptsLeft)
        {
            switch (attemptsLeft)
            {
                case 6:
                    // Update line1 when 6 attempts left
                    line1[3] = "0";
                    break;
                case 5:
                    // Update line2 when 5 attempts left
                    line2[3] = "|";
                    break;
                case 4:
                    // Update line3 when 4 attempts left
                    line3[3] = "O";
                    break;
                case 3:
                    // Update line4 when 3 attempts left
                    line4[3] = "O";
                    break;
                case 2:
                    // Update line5 when 2 attempts left
                    line5[3] = "/";
                    break;
                case 1:
                    // Update line6 when 1 attempt left
                    line5[3] = "/\\";
                    break;
                default:
                    // For 7 attempts left or any other cases, no changes
                    break;
            }
        }

        public void PrintBoard()
        {
            foreach (List<string> line in board)
            {
                foreach (string element in line)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
            }

            Console.WriteLine(string.Join(" ", guessingBoard));
        }
    }
}
