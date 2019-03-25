using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    public class Program
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
        /// <summary>
        /// This method sets up the game to be played
        /// </summary>
        /// <returns>This bool will determine if there will be a new game or exit after a game is played</returns>
        static bool PlayGame()
        {
            try
            {
                Player playerOne = new Player();
                Player playerTwo = new Player();

                Console.Clear();
                Console.WriteLine("Player One");
                Console.WriteLine("Please enter your name");
                playerOne.Name = Console.ReadLine();
                playerOne.Marker = "X";

                Console.Clear();
                Console.WriteLine("Player Two");
                Console.WriteLine("Please enter your name");
                playerTwo.Name = Console.ReadLine();
                playerTwo.Marker = "O";

                Console.Clear();
                Console.WriteLine($"Welcome {playerOne.Name} and {playerTwo.Name}!");
                Console.WriteLine();
                Console.WriteLine($"{playerOne.Name} will play {playerOne.Marker}'s.");
                Console.WriteLine();
                Console.WriteLine($"{playerTwo.Name} will play {playerTwo.Marker}'s.");
                Console.WriteLine();
                Console.WriteLine("Please press enter to start the game.");
                Console.ReadLine();

                Game game = new Game(playerOne, playerTwo);
                game.Play();

                Console.Clear();
                Console.WriteLine("Would you like to play another game?");
                Console.WriteLine("Please enter 'y' if you would like a new game, ");
                Console.WriteLine("or just press enter if you would like to exit.");
                string newGame = Console.ReadLine();
                if (newGame.ToLower() == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
