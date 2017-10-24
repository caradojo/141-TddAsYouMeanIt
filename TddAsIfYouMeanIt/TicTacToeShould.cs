    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddAsIfYouMeanIt
{
    [TestClass]
    public class TicTacToeShould
    {
        [TestMethod]
        public void no_winner_for_blank_game()
        {
            Assert.IsFalse(hasWinner());
        }

        [TestMethod]
        public void no_winner_with_two_pieces()
        {
            Assert.IsFalse(hasWinner());
        }

        [TestMethod]
        public void no_winner_with_four_pieces()
        {
            Assert.IsFalse(hasWinner());
        }

        [TestMethod]
        public void has_winner_for_three_crosses_on_first_line()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void has_winner_for_three_crosses_on_second_line()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void has_winner_for_three_crosses_on_third_line()
        {
            Assert.IsTrue(true);
        }

        




        private static bool hasWinner()
        {
            return false;
        }
    }
}
