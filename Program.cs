/* 

    Project Name: cse210_01 TicTacToe

*/

using System;

namespace cse210_01
{
    class Program
    
    {
        static void Main(string[] args)
        {
            startGame(1);
            drawGameBoard();

            string userInput = Console.ReadLine();

            Console.Clear();

        }

        static void startGame(int playerNumber)
        {
            Console.WriteLine("Welcome to the TicTacToe Game!");

            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine("");

            Console.WriteLine("Player {x} to move, select 1 through 9 from the game board");
            Console.WriteLine("");
        }

        static void drawGameBoard()
        {
            Console.WriteLine(" 1 | 2 | 3");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 7 | 8 | 9 ");
            Console.WriteLine("---+---+---");
        }
    }
}
