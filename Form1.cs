using System;
using System.Drawing;
using System.Windows.Forms;
using RPSLS.Properties;

namespace RPSLS
{
    public partial class Form1 : Form
    {
        private ResultCalculator _resultCalculator;

        public Form1()
        {
            InitializeComponent();
            InitialText();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            var playerMove = CheckPlayedMove();
            var computerMove = ComputerMove();

            if (playerMove == Moves.InvalidMove)
                return;

            var round = new Round(playerMove, computerMove);
            var result = round.Result();

            RoundResultText(result);

            LblStatistics.Text = _resultCalculator.Calculate(result);


            ShowPlayedMoves(computerMove, playerMove);

            UncheckPlayedMove();
        }

        private void RoundResultText(string result)
        {
            if (result == GameResult.Win)
                LblGameResult.ForeColor = Color.LawnGreen;
            if (result == GameResult.Draw)
                LblGameResult.ForeColor = Color.Yellow;
            if (result == GameResult.Loss)
                LblGameResult.ForeColor = Color.LightCoral;

            LblGameResult.Text = result;
        }

        private void ShowPlayedMoves(int computerMove, int playerMove)
        {
            var playerImage = Resources.ResourceManager.GetObject(playerMove.ToString());
            pictureBoxPlayer.Image = (Image) playerImage;

            var computerImage = Resources.ResourceManager.GetObject(computerMove.ToString());
            pictureBoxComputer.Image = (Image) computerImage;
        }

        private int CheckPlayedMove()
        {
            if (rbPaper.Checked)
                return Moves.Paper;
            if (rbRock.Checked)
                return Moves.Rock;
            if (rbScissors.Checked)
                return Moves.Scissors;
            if (rbLizard.Checked)
                return Moves.Lizard;
            if (rbSpock.Checked)
                return Moves.Spock;

            return Moves.InvalidMove;
        }

        private void UncheckPlayedMove()
        {
            foreach (Control ctrl in Controls)
                if (ctrl is Panel)
                    foreach (Control rdb in ctrl.Controls)
                        if (rdb is RadioButton && ((RadioButton) rdb).Checked)
                            ((RadioButton) rdb).Checked = false;
        }

        private static int ComputerMove()
        {
            var randomChoice = new Random();
            return randomChoice.Next(1, 6);
        }

        public void InitialText()
        {
            _resultCalculator = new ResultCalculator();
            LblGameResult.Text = @"Good Luck";
            LblGameResult.ForeColor = Color.FromArgb(222, 153, 88);
            LblStatistics.Text = @"Rock paper scissors lizard spock...";
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            var newGame = MessageBox.Show(@"Are you sure you want to start a new game?", @"RPSLS",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (newGame == DialogResult.Yes)
                InitialText();
        }
    }
}