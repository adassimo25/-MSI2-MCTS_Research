using GomokuGUI.Players;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GomokuGUI
{
    public partial class Gomoku : Form
    {
        private GameType GameType { get; set; }
        private IPlayer Player1 { get; set; }
        private IPlayer Player2 { get; set; }
        public int BoardSize { get; set; } = 13;
        public int Winning { get; set; } = 5;

        public Gomoku()
        {
            InitializeComponent();
            InitializeGameDetails();

            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pictureBox.Image);

            DrawNet();
        }

        private void InitializeGameDetails()
        {
            if (radioButtonBvsB.Checked)
            {
                SetBotBotGameType();
                return;
            }

            if (radioButtonBvsP.Checked)
            {
                SetBotPlayerGameType();
                return;
            }

            if (radioButtonPvsP.Checked)
            {
                SetPlayerPlayerGameType();
                return;
            }
        }

        private void TrackBarBot1_ValueChanged(object sender, EventArgs e)
        {
            SetTrackBarValueInLabel(sender as TrackBar, labelBot1IterationsNumber);
            Player1 = new Bot((Player1 as Bot).AlgorithmType, trackBarBot1.Value);
        }

        private void TrackBarBot2_ValueChanged(object sender, EventArgs e)
        {
            SetTrackBarValueInLabel(sender as TrackBar, labelBot2IterationsNumber);
            Player2 = new Bot((Player2 as Bot).AlgorithmType, trackBarBot2.Value);
        }

        private static void SetTrackBarValueInLabel(TrackBar trackBar, Label label)
        {
            int value = trackBar.Value;
            double indexDouble = (value * 1.0) / trackBar.TickFrequency;
            int index = Convert.ToInt32(Math.Round(indexDouble));

            trackBar.Value = trackBar.TickFrequency * index;

            label.Text = trackBar.Value.ToString();
        }

        private void RadioButtonBvsB_CheckedChanged(object sender, EventArgs e)
        {
            SetBotBotGameType();
        }

        private void RadioButtonBvsP_CheckedChanged(object sender, EventArgs e)
        {
            SetBotPlayerGameType();
        }

        private void RadioButtonPvsP_CheckedChanged(object sender, EventArgs e)
        {
            SetPlayerPlayerGameType();
        }

        private void RadioButtonBot1MCTSClassic_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = new Bot(BotAlgorithmType.MCTSClassic, trackBarBot1.Value);
        }

        private void RadioButtonBot1MCTSUCB1TUNED_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = new Bot(BotAlgorithmType.MCTSUCB1TUNED, trackBarBot1.Value);
        }

        private void RadioButtonBot1MCTSUCB1withVF_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = new Bot(BotAlgorithmType.MCTSUCB1withValueFunction, trackBarBot1.Value);
        }

        private void RadioButtonBot1GreedyHeuristic_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = new Bot(BotAlgorithmType.GreedyHeuristic);
        }

        private void RadioButtonBot2MCTSClassic_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = new Bot(BotAlgorithmType.MCTSClassic, trackBarBot2.Value);
        }

        private void RadioButtonBot2MCTSUCB1TUNED_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = new Bot(BotAlgorithmType.MCTSUCB1TUNED, trackBarBot2.Value);
        }

        private void RadioButtonBot2MCTSUCB1withVF_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = new Bot(BotAlgorithmType.MCTSUCB1withValueFunction, trackBarBot2.Value);
        }

        private void RadioButtonBot2GreedyHeuristic_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = new Bot(BotAlgorithmType.GreedyHeuristic);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            editGameParametersToolStripMenuItem.Enabled = false;
            tableLayoutPanelMenu.Enabled = false;

            // TODO game
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // TODO when player game
        }

        private void EditGameParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameParameters gameParameters = new(this);
            gameParameters.ShowDialog();

            ClearBoard();
            DrawNet();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}