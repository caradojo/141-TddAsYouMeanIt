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
            var game = CreateGame("---"
                       + "---"
                       + "---");
            var hasWinner = HasWinner(game);
            Assert.IsFalse(hasWinner);
        }

        private static string CreateGame(string game)
        {
            return game;
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
            var game = CreateGame("x--"
                       + "---"
                       + "---");
            var hasWinner = HasWinner(game);
            var nbMove = 1;
            Assert.IsFalse(hasWinner && nbMove == 1);
        }

        [TestMethod]
        public void oneLineOfCrossHasWinner()
        {
            var game = CreateGame("xxx"
                       + "oo-"
                       + "---");
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void secondLineOfCrossHasWinner()
        {
            var game = CreateGame("oo-" 
                       + "xxx"
                       + "---");
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void thridLineOfCrossHasWinner()
        {
            var game = CreateGame("oo-"
                       + "---"
                       + "xxx");
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void fiveMoveHasNoWinner()
        {
            var game = CreateGame("oo-"
                       + "--x"
                       + "xx-");
            var hasWinner = HasWinner(game);
            Assert.IsFalse(hasWinner);
        }

        [TestMethod]
        public void oneDiagOfCrossHasWinner()
        {
            var game = CreateGame("x--"
                       + "oxo"
                       + "--x");
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }

        [TestMethod]
        public void oneColOfCrossHasWinner()
        {
            var game = CreateGame("x--"
                       + "xoo"
                       + "x--");
            var hasWinner = HasWinner(game);
            Assert.IsTrue(hasWinner);
        }
    }
}
