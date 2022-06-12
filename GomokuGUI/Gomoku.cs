using GomokuGUI.Players;
using GomokuLib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GomokuGUI
{
    public partial class Gomoku : Form
    {
        private IPlayer Player1 { get; set; }
        private IPlayer Player2 { get; set; }
        public GomokuGame Game { get; set; }

        public Gomoku()
        {
            InitializeComponent();

            Game = GomokuGame.CreateGomokuGame();
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
        }

        private void TrackBarBot2_ValueChanged(object sender, EventArgs e)
        {
            SetTrackBarValueInLabel(sender as TrackBar, labelBot2IterationsNumber);
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

        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            ClearBoard();
            DrawNet();

            buttonStart.Enabled = false;
            editGameParametersToolStripMenuItem.Enabled = false;
            tableLayoutPanelMenu.Enabled = false;

            Game = GomokuGame.CreateGomokuGame();
            InitializeGameDetails();

            await Play();

            buttonStart.Enabled = true;
            editGameParametersToolStripMenuItem.Enabled = true;
            tableLayoutPanelMenu.Enabled = true;
        }

        private void EditGameParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameParameters gameParameters = new();
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