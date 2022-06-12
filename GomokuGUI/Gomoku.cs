using GomokuGUI.Players;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GomokuGUI
{
    public partial class Gomoku : Form
    {
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
            Player1 = new Bot(groupBoxBot1.Text, (Player1 as Bot).AlgorithmType, trackBarBot1.Value);
        }

        private void TrackBarBot2_ValueChanged(object sender, EventArgs e)
        {
            SetTrackBarValueInLabel(sender as TrackBar, labelBot2IterationsNumber);
            Player2 = new Bot(groupBoxBot2.Text, (Player2 as Bot).AlgorithmType, trackBarBot2.Value);
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
            Player1 = new Bot(groupBoxBot1.Text, BotAlgorithmType.MCTSClassic, trackBarBot1.Value);
        }

        private void RadioButtonBot1MCTSUCB1Tuned_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = new Bot(groupBoxBot1.Text, BotAlgorithmType.MCTSUCB1Tuned, trackBarBot1.Value);
        }

        private void RadioButtonBot1MCTSUCB1withHeuristics_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = new Bot(groupBoxBot1.Text, BotAlgorithmType.MCTSUCB1withHeuristics, trackBarBot1.Value);
        }

        private void RadioButtonBot1GreedyHeuristics_CheckedChanged(object sender, EventArgs e)
        {
            Player1 = new Bot(groupBoxBot1.Text, BotAlgorithmType.GreedyHeuristics);
        }

        private void RadioButtonBot2MCTSClassic_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = new Bot(groupBoxBot2.Text, BotAlgorithmType.MCTSClassic, trackBarBot2.Value);
        }

        private void RadioButtonBot2MCTSUCB1Tuned_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = new Bot(groupBoxBot2.Text, BotAlgorithmType.MCTSUCB1Tuned, trackBarBot2.Value);
        }

        private void RadioButtonBot2MCTSUCB1withHeuristics_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = new Bot(groupBoxBot2.Text, BotAlgorithmType.MCTSUCB1withHeuristics, trackBarBot2.Value);
        }

        private void RadioButtonBot2GreedyHeuristics_CheckedChanged(object sender, EventArgs e)
        {
            Player2 = new Bot(groupBoxBot2.Text, BotAlgorithmType.GreedyHeuristics);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ClearBoard();
            DrawNet();

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