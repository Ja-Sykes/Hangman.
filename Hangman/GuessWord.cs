using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class GuessWord
    {
        private string chosenWord;
        private string[] guessingBoard;
        private int guessAttempts;

        public GuessWord(string word, int attempts)
        {
            chosenWord = word;
            guessingBoard = new string[chosenWord.Length];
            Array.Fill(guessingBoard, "_");
            guessAttempts = attempts;
        }

        public bool GuessLetter(char letter)
        {
            bool correctGuess = false;

            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord[i] == letter)
                {
                    guessingBoard[i] = letter.ToString();
                    correctGuess = true;
                }
            }

            if (!correctGuess)
            {
                guessAttempts--;
                Console.WriteLine($"The letter '{letter}' is not in the word. You have {guessAttempts} attempts left.");
            }

            return correctGuess;
        }

        public void GuessWholeWord(string word)
        {
            if (word == chosenWord)
            {
                Console.WriteLine("Congratulations! You guessed the word correctly.");
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    guessingBoard[i] = chosenWord[i].ToString();
                }
            }
            else
            {
                guessAttempts--;
                Console.WriteLine($"Incorrect guess. Try again. You have {guessAttempts} attempts left.");
            }
        }


        public void DisplayGuessingBoard()
        {
            Console.WriteLine("Current guessing board:");
            Console.WriteLine(string.Join(" ", guessingBoard));
        }

        public bool CheckWin()
        {
            return !Array.Exists(guessingBoard, element => element == "_");
        }

        public bool IsGameOver()
        {
            return guessAttempts <= 0;
        }
        // Inside the GuessWord class
        public int GetRemainingAttempts()
        {
            return guessAttempts;
        }

    }
}
