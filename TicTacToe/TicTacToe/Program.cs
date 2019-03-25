using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    class Program
    {
        #region Main
        static void Main(string[] args)
        {
            try
            {
                bool playAgain = true;
                while (playAgain)
                {
                    playAgain = PlayGame();
                }
            }
            catch (Exception genEX)
            {
                Console.WriteLine("There was an error in the Main method.");
                Console.WriteLine(genEX.Message);
                Console.ReadLine();
            }
        }
        #endregion

        static bool PlayGame()
        {
            try
            {
                Player playerOne = new Player();
                Player playerTwo = new Player();

                Console.Clear();
                Console.WriteLine("\tPlayer One");
                Console.WriteLine("\tPlease enter your name");
                playerOne.Name = Console.ReadLine();
                playerOne.Marker = "X";

                Console.Clear();
                Console.WriteLine("\tPlayer Two");
                Console.WriteLine("\tPlease enter your name");
                playerTwo.Name = Console.ReadLine();
                playerTwo.Marker = "O";

                Console.Clear();
                Console.WriteLine($"\tWelcome {playerOne.Name} and {playerTwo.Name}!");
                Console.WriteLine();
                Console.WriteLine($"\t{playerOne.Name} will play {playerOne.Marker}'s.");
                Console.WriteLine();
                Console.WriteLine($"\t{playerTwo.Name} will play {playerTwo.Marker}'s.");
                Console.WriteLine();
                Console.WriteLine("Please press enter to start the game.");
                Console.ReadLine();

                Game game = new Game(playerOne, playerTwo);
                game.Play();

                return false;
            }
            catch (Exception genEX)
            {
                Console.WriteLine("There was an error in the PlayGame method.");
                Console.WriteLine(genEX.Message);
                Console.ReadLine();
                throw;
            }
            // TODO: Setup your game here. Create an introduction. 
            // Create your players, and instantiate your Game class. 
            // output to the console the winner
        }
    }
}
