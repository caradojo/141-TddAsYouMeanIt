namespace TddAsIfYouMeanIt
{
    public class TicTacToe
    {
        public static string CreateGame(string game)
        {
            return game;
        }

        public static bool HasWinner(string game)
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
    }
}