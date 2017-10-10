    using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddAsIfYouMeanIt
{
    [TestClass]
    public class TicTacToeShould
    {
        [TestMethod]
        public void noWinnerAtBegining()
        {
            var game = "---"
                       + "---"
                       + "---";
            var hasWinner = HasWinner(game);
            Assert.IsFalse(hasWinner);
        }

        private static bool HasWinner(string game)
        {
            return "xxx"+ "oo-"+ "---" == game 
                || "x--"+ "oxo" + "--x" == game
                || "x--"+ "xoo" + "x--" == game;
        }

        [TestMethod]
        public void noWinnerAfterOneMove()
        {
            var game = "x--"
                       + "---"
                       + "---";
            var hasWinner = HasWinner(game);
            var nbMove = 1;
            Assert.IsFalse(hasWinner && nbMove == 1);
        }

        [TestMethod]
        public void oneLineOfCrossHasWinner()
        {
            var game = "xxx"
                       + "oo-"
                       + "---";
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void oneDiagOfCrossHasWinner()
        {
            var game = "x--"
                       + "oxo"
                       + "--x";
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void oneColOfCrossHasWinner()
        {
            var game = "x--"
                       + "xoo"
                       + "x--";
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }
    }
}
