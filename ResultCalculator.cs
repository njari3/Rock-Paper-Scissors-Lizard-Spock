namespace RPSLS
{
    public class ResultCalculator
    {
        private int _draw;
        private int _gamePlayed;
        private int _userLoss;

        private int _userWin;

        public string Calculate(string result)
        {
            ++_gamePlayed;
            if (result == GameResult.Win)
                ++_userWin;
            if (result == GameResult.Loss)
                ++_userLoss;
            if (result == GameResult.Draw)
                ++_draw;

            if (_gamePlayed == 1)
                return $"Played game: {_gamePlayed}  Win: {_userWin}  Loss: {_userLoss}  Draw:  {_draw}";

            return $"Played games: {_gamePlayed}  Wins: {_userWin}  Loss: {_userLoss}  Draw:  {_draw}";
        }
    }
}