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
            var hasWinner = false;
            Assert.IsFalse(hasWinner);
        }

        [TestMethod]
        public void noWinnerAfterOneMove()
        {
            var hasWinner = false;
            var nbMove = 1;
            Assert.IsFalse(hasWinner && nbMove == 1);
        }

        [TestMethod]
        public void oneLineOfCrossHasWinner()
        {
            var game = "xxx"
                       + "oo-"
                       + "---";
            var hasWinner = true;
            Assert.IsTrue(hasWinner);
        }
    }
}
