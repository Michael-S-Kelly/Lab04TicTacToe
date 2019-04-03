using System;
using Xunit;
using TicTacToe;
using TicTacToe.Classes;

namespace TicTacToe_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestForWinners()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Name = "M";
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Name = "S";
            playerTwo.Marker = "O";
            Game game1 = new Game(playerOne, playerTwo);
            Board board = new Board();
            board.GameBoard = new string[,]
            {
                {"X", "O", "3"},
                {"4", "X", "6"},
                {"7", "O", "X"},
            };
            game1.Board = board;

            //act
            bool winner = game1.CheckForWinner(board);

            //assert
            Assert.True(winner);
        }

        [Fact]
        public void TestSwitchBetweenTurns()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Name = "M";
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Name = "S";
            playerTwo.Marker = "O";
            Game game1 = new Game(playerOne, playerTwo);
            playerOne.IsTurn = false;

            //act
            game1.SwitchPlayer();

            //assert
            Assert.True(playerOne.IsTurn);

        }
    }
}
