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

            WordSelction wordSelction = new WordSelction();
            wordSelction.chooseWord();

            hangmanBoard.PrintBoard();

        }
    }
}