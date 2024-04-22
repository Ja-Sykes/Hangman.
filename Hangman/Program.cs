using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Board hangmanBoard = new Board();
            hangmanBoard.PrintBoard();

            WordSelection wordSelection = new WordSelection(hangmanBoard); // Pass the Board instance to WordSelection constructor
            wordSelection.ChooseWord(); // Prompt user to choose a word

            Console.Clear();

            hangmanBoard.PrintBoard(); // Print the updated board with the guessing board filled

            GuessWord guessWord = new GuessWord(wordSelection.ChosenWord, 7); // Initialize with 7 guess attempts

            while (!guessWord.IsGameOver() && !guessWord.CheckWin())
            {
                Console.WriteLine("Guess a letter or type 'guess' to guess the whole word:");
                string input = Console.ReadLine();

                if (input.ToLower() == "guess")
                {
                    Console.WriteLine("Enter your word guess:");
                    string wordGuess = Console.ReadLine();
                    guessWord.GuessWholeWord(wordGuess);
                }
                else if (input.Length == 1 && char.IsLetter(input[0]))
                {
                    char letter = char.ToLower(input[0]);
                    guessWord.GuessLetter(letter);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a single letter or 'guess' to guess the whole word.");
                }

                // Inside the while loop of the Main method in Program.cs
                hangmanBoard.UpdateHangman(guessWord.GetRemainingAttempts());
                hangmanBoard.PrintBoard(); // Print the updated board with the guessing board filled


                guessWord.DisplayGuessingBoard();
            }

            if (guessWord.CheckWin())
            {
                Console.WriteLine("Congratulations! You won!");
            }
            else
            {
                Console.WriteLine("Sorry, you lost. The word was: " + wordSelection.ChosenWord);
            }
        }
    }


}