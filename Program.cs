/* 

    Project Name: cse210_01 TicTacToe

*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace cse210_01
{
    class Program
    
    {
        static void Main(string[] args)
        {
            string player = nextPlayer("");
             
        }

        int createBoard()
        {   
            List<int> board = new List<int>();
            
            foreach (int value in Enumerable.Range(1, 9))
            {
                board.Add(value + 1);
            }

            return board;
        }

        string nextPlayer(current)
        {   
            value = ""

            if(current == "" || current == "o")
            {
                string value = "x";
            }
            else if(current == "x")
            {
                string value = "o"
            }

            return value;
        }
    }
}
