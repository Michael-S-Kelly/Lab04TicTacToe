using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class Board
    {
        /// <summary>
        /// Tic Tac Toe Gameboard states
        /// </summary>
        public string[,] GameBoard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };


        public void DisplayBoard()
        {
            try
            {
                for (int i = 0; i < GameBoard.GetLength(0); i++)
                {
                    Console.WriteLine("--------");
                    for (int j = 0; j < GameBoard.GetLength(1); j++)
                    {
                        Console.Write($"| {GameBoard[i, j]} |");
                    }
                    Console.WriteLine("--------");
                }
            }
            catch (Exception genEX)
            {
                Console.WriteLine("There was an error in the DisplayBoard method of the Board Class.");
                Console.WriteLine(genEX.Message);
                Console.ReadLine();
            }
            //TODO: Output the board to the console

        }
    }
}
