    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddAsIfYouMeanIt
{
    [TestClass]
    public class TicTacToeShould
    {
        private static string _game;

        [TestMethod]
        public void no_winner_for_blank_game()
        {
            CreateGame(".........");

            Assert.IsFalse(hasWinner());
        }

        [TestMethod]
        public void no_winner_with_two_pieces()
        {
            CreateGame("...x....o");

            Assert.IsFalse(hasWinner());
        }

        [TestMethod]
        public void no_winner_with_four_pieces()
        {
            CreateGame("...xx..oo");

            Assert.IsFalse(hasWinner());
        }

        [TestMethod]
        public void has_winner_for_three_crosses_on_first_line()
        {
            CreateGame("xxx....oo");

            Assert.IsTrue(hasWinner());
        }

        [TestMethod]
        public void has_winner_for_three_crosses_on_second_line()
        {
            CreateGame("...xxx.oo");

            Assert.IsTrue(hasWinner());
        }

        [TestMethod]
        public void has_winner_for_three_crosses_on_third_line()
        {
            CreateGame(".oo...xxx");

            Assert.IsTrue(hasWinner());
        }

        private static bool hasWinner()
        {
            return _game.Contains("xxx");
        }

        private static void CreateGame(string game)
        {
            _game = game;
        }
    }
}
