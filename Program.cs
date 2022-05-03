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
            int currentPlayer = -1;

            do 
            {   
                currentPlayer = nextPlayer(currentPlayer);

                startGame(currentPlayer);
                drawGameBoard();

                string userInput = Console.ReadLine();

                Console.Clear();


            } while (true);

        }

        static void startGame(int playerNumber)
        {
            Console.WriteLine("Welcome to the TicTacToe Game!");

            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine("");

            Console.WriteLine($"Player {playerNumber} to move, select 1 through 9 from the game board");
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

        static int nextPlayer(int player)
        {
            if (player.Equals(1))
            {
                return 2;
            }

            return 1;
        }
    }
}
