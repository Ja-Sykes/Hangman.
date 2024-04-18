using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Board
    {
        // Define individual strings/lists
        private List<string> line0 = new List<string> { "-", "-", "-", "|" };
        private List<string> line1 = new List<string> { "|", " ", " ", " " };
        private List<string> line2 = new List<string> { "|", " ", " ", " " };
        private List<string> line3 = new List<string> { "|", " ", " ", " " };
        private List<string> line4 = new List<string> { "|", " ", " ", " " };
        private List<string> line5 = new List<string> { "|", " ", " ", " " };
        private List<string> line6 = new List<string> { "|", " ", " ", " " };
        private List<string> line7 = new List<string> { "-", " ", " ", " " };
        //private List<string> line8 = new List<string> { "\n_"};
        private List<string> guessingBoard = new List<string> { "_", };

        // Create the board using the individual strings/lists in the constructor
        public List<List<string>> board;

        public Board()
        {
            // Initialize the board in the constructor
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

            // Print the guessing board
            Console.WriteLine(string.Join(" ", guessingBoard));
        }

        public void UpdateGuessingBoard(string chosenWord)
        {
            guessingBoard.Clear();
            
            for (int i = 0; i < chosenWord.Length; i++)
            {
                guessingBoard.AddRange(new string[] { "_" });
            }
        }

    }
}
