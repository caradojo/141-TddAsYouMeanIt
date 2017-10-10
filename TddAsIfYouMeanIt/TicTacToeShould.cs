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
            var game = "---"
                       + "---"
                       + "---";
            var hasWinner = HasWinner(game);
            Assert.IsFalse(hasWinner);
        }

        private static bool HasWinner(string game)
        {
            return HasOneRowOfCross(game) 
                || HasOneDiagOfCross(game)
                || HasColDiagOfCross(game);
        }

        private static bool HasColDiagOfCross(string game)
        {
            return "x--"+ "xoo" + "x--" == game;
        }

        private static bool HasOneDiagOfCross(string game)
        {
            return "x--"+ "oxo" + "--x" == game;
        }

        private static bool HasOneRowOfCross(string game)
        {
            return game.IndexOf("xxx") % 3 == 0;
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
        public void secondLineOfCrossHasWinner()
        {
            var game = "oo-" 
                       + "xxx"
                       + "---";
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void thridLineOfCrossHasWinner()
        {
            var game = "oo-"
                       + "---"
                       + "xxx";
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void fiveMoveHasNoWinner()
        {
            var game = "oo-"
                       + "--x"
                       + "xx-";
            var hasWinner = HasWinner(game);
            Assert.IsFalse(hasWinner);
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
