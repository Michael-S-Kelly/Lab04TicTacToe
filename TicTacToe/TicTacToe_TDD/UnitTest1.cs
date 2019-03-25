using System;
using Xunit;
using static TicTacToe.Program;
using TicTacToe.Classes;

namespace TicTacToe_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            Player playerOne = new Player();
            playerOne.Name = "M";
            playerOne.Marker = "X";
            Player playerTwo = new Player();
            playerTwo.Name = "S";
            playerTwo.Marker = "O";

            //act

            //assert
        }
    }
}
