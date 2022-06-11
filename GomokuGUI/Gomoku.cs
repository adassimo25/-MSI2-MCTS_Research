using GomokuGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomokuGUI
{
    public partial class Gomoku : Form
    {
        public Gomoku()
        {
            InitializeComponent();
        }

        private void TrackBarBot1_ValueChanged(object sender, EventArgs e)
        {
            SetTrackBarValueInLabel(sender as TrackBar, labelBot1Iterations);
        }

        private void TrackBarBot2_ValueChanged(object sender, EventArgs e)
        {
            SetTrackBarValueInLabel(sender as TrackBar, labelBot2Iterations);
        }

        private static void SetTrackBarValueInLabel(TrackBar trackBar, Label label)
        {
            int value = trackBar.Value;
            double indexDouble = (value * 1.0) / trackBar.TickFrequency;
            int index = Convert.ToInt32(Math.Round(indexDouble));

            trackBar.Value = trackBar.TickFrequency * index;

            label.Text = trackBar.Value.ToString();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RadioButtonBvsB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonBvsP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonPvsP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {

        }
    }
}
