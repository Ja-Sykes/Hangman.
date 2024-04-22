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
    class WordSelection
    {
        public string ChosenWord { get; private set; } // Property to hold the chosen word

        private Board boardInstance; // Declare a variable to hold an instance of the Board class

        public WordSelection(Board board)
        {
            boardInstance = board; // Initialize the boardInstance variable with the provided Board instance
        }

        public void ChooseWord()
        {
            Console.WriteLine("Type your word in!");
            ChosenWord = Console.ReadLine(); // Store the chosen word in the ChosenWord property
            UpdateGuessingBoard(ChosenWord); // Update the guessing board after choosing the word
        }

        public void UpdateGuessingBoard(string chosenWord)
        {
            // Access the guessingBoard through the Board instance
            boardInstance.guessingBoard.Clear();

            for (int i = 0; i < chosenWord.Length; i++)
            {
                boardInstance.guessingBoard.AddRange(new string[] { "_" });
            }
        }
    }
}

