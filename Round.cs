namespace RPSLS
{
    public class Round
    {
        private readonly int _computer;
        private readonly int _player;

        public Round(int player, int computer)
        {
            _player = player;
            _computer = computer;
        }

        public string Result()
        {
            switch (_player)
            {
                case Moves.Rock:
                    if (_computer == Moves.Scissors || _computer == Moves.Lizard)
                        return GameResult.Win;
                    if (_computer == Moves.Paper || _computer == Moves.Spock)
                        return GameResult.Loss;
                    break;

                case Moves.Paper:
                    if (_computer == Moves.Rock || _computer == Moves.Spock)
                        return GameResult.Win;
                    if (_computer == Moves.Scissors || _computer == Moves.Lizard)
                        return GameResult.Loss;
                    break;

                case Moves.Scissors:
                    if (_computer == Moves.Paper || _computer == Moves.Lizard)
                        return GameResult.Win;
                    if (_computer == Moves.Rock || _computer == Moves.Spock)
                        return GameResult.Loss;
                    break;

                case Moves.Lizard:
                    if (_computer == Moves.Paper || _computer == Moves.Spock)
                        return GameResult.Win;
                    if (_computer == Moves.Rock || _computer == Moves.Scissors)
                        return GameResult.Loss;
                    break;

                case Moves.Spock:
                    if (_computer == Moves.Scissors || _computer == Moves.Rock)
                        return GameResult.Win;
                    if (_computer == Moves.Paper || _computer == Moves.Lizard)
                        return GameResult.Loss;
                    break;
                default:
                    return GameResult.Draw;
            }
            return GameResult.Draw;
        }
    }
}