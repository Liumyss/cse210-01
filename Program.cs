﻿/* 

    Project Name: cse210_01 TicTacToe

*/

using System;

namespace cse210_01
{
    class Program
    
    {
        static void Main(string[] args)
        {   
            int gameStatus = 0;
            int currentPlayer = -1;
            char[] gameMarkers = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

            do 
            {   
                Console.Clear();

                currentPlayer = nextPlayer(currentPlayer);

                startGame(currentPlayer);
                drawGameBoard(gameMarkers);

                gameEngine(gameMarkers, currentPlayer);

                gameStatus = checkWinner(gameMarkers);

            } while (gameStatus.Equals(0));

            Console.Clear();
            startGame(currentPlayer);
            drawGameBoard(gameMarkers);

            if (gameStatus.Equals(1))
            {
                Console.WriteLine($"Player {currentPlayer} is the winner!");
            }
            
            if (gameStatus.Equals(2))
            {
                Console.WriteLine("The game is a draw");
            }
        }

        private static int checkWinner(char[] gameMarkers)
        {
            if (isGameWinner(gameMarkers))
            {
                return 1;
            }

            if (isGameDraw(gameMarkers))
            {
                return 2;
            }

            return 0;
        }

        private static bool isGameDraw(char[] gameMarkers)
        {
            return gameMarkers[0] != '1' &&
                   gameMarkers[1] != '2' &&
                   gameMarkers[2] != '3' &&
                   gameMarkers[3] != '4' &&
                   gameMarkers[4] != '5' &&
                   gameMarkers[5] != '6' &&
                   gameMarkers[6] != '7' &&
                   gameMarkers[7] != '8' &&
                   gameMarkers[8] != '9';
        }

        private static bool isGameWinner(char[] gameMarkers)
        {
             if (IsGameMarkersTheSame(gameMarkers, 0, 1, 2))
            {
                return true;
            }

            if (IsGameMarkersTheSame(gameMarkers, 3, 4, 5))
            {
                return true;
            }

            if (IsGameMarkersTheSame(gameMarkers, 6, 7, 8))
            {
                return true;
            }

            if (IsGameMarkersTheSame(gameMarkers, 0, 3, 6))
            {
                return true;
            }

            if (IsGameMarkersTheSame(gameMarkers, 1, 4, 7))
            {
                return true;
            }

            if (IsGameMarkersTheSame(gameMarkers, 2, 5, 8))
            {
                return true;
            }

            if (IsGameMarkersTheSame(gameMarkers, 0, 4, 8))
            {
                return true;
            }

            if (IsGameMarkersTheSame(gameMarkers, 2, 4, 6))
            {
                return true;
            }

            return false;
        }

        private static bool IsGameMarkersTheSame(char[] testGameMarkers, int pos1, int pos2, int pos3)
        {
            return testGameMarkers[pos1].Equals(testGameMarkers[pos2]) && testGameMarkers[pos2].Equals(testGameMarkers[pos3]);
        }

        private static void gameEngine(char[] gameMarkers, int currentPlayer)
        {   
            bool notValidMove = true;

            do
            {
                string userInput = Console.ReadLine();

                if (!string.IsNullOrEmpty(userInput) &&
                    (userInput.Equals("1") ||
                    userInput.Equals("2") ||
                    userInput.Equals("3") ||
                    userInput.Equals("4") ||
                    userInput.Equals("5") ||
                    userInput.Equals("6") ||
                    userInput.Equals("7") ||
                    userInput.Equals("8") ||
                    userInput.Equals("9")))
                {

                    int.TryParse(userInput, out var gamePlacementMarker);

                    char currentMarker = gameMarkers[gamePlacementMarker - 1];

                    if (currentMarker.Equals('X') || currentMarker.Equals('O'))
                    {
                        Console.WriteLine("Placement has already a marker please select another pleacement.");
                    }
                    else
                    {
                        gameMarkers[gamePlacementMarker - 1] = getPlayerMarker(currentPlayer);

                        notValidMove = false;
                    }
                }
            } while (notValidMove);
        }

        private static char getPlayerMarker(int player)
        {
            if(player % 2 == 0)
            {
                return 'O';
            }

            return 'X';
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

        static void drawGameBoard(char[] gameMarkers)
        {
            Console.WriteLine($" {gameMarkers[0]} | {gameMarkers[1]} | {gameMarkers[2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {gameMarkers[3]} | {gameMarkers[4]} | {gameMarkers[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {gameMarkers[6]} | {gameMarkers[7]} | {gameMarkers[8]} ");
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
