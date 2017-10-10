    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddAsIfYouMeanIt
{
    [TestClass]
    public class TicTacToeShould
    {
        [TestMethod]
        public void noWinnerAtBegining()
        {
            var game = TicTacToe.CreateGame("---"
                       + "---"
                       + "---");
            var hasWinner = TicTacToe.HasWinner(game);
            Assert.IsFalse(hasWinner);
        }


        [TestMethod]
        public void noWinnerAfterOneMove()
        {
            var game = TicTacToe.CreateGame("x--"
                       + "---"
                       + "---");
            var hasWinner = TicTacToe.HasWinner(game);
            var nbMove = 1;
            Assert.IsFalse(hasWinner && nbMove == 1);
        }

        [TestMethod]
        public void oneLineOfCrossHasWinner()
        {
            var game = TicTacToe.CreateGame("xxx"
                       + "oo-"
                       + "---");
            var hasWinner = TicTacToe.HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void secondLineOfCrossHasWinner()
        {
            var game = TicTacToe.CreateGame("oo-" 
                       + "xxx"
                       + "---");
            var hasWinner = TicTacToe.HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void thridLineOfCrossHasWinner()
        {
            var game = TicTacToe.CreateGame("oo-"
                       + "---"
                       + "xxx");
            var hasWinner = TicTacToe.HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void fiveMoveHasNoWinner()
        {
            var game = TicTacToe.CreateGame("oo-"
                       + "--x"
                       + "xx-");
            var hasWinner = TicTacToe.HasWinner(game);
            Assert.IsFalse(hasWinner);
        }

        [TestMethod]
        public void oneDiagOfCrossHasWinner()
        {
            var game = TicTacToe.CreateGame("x--"
                       + "oxo"
                       + "--x");
            var hasWinner = TicTacToe.HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void oneColOfCrossHasWinner()
        {
            var game = TicTacToe.CreateGame("x--"
                       + "xoo"
                       + "x--");
            var hasWinner = TicTacToe.HasWinner(game);
            Assert.IsTrue(hasWinner);
        }
    }
}
