using GomokuLib;
using System;
using System.Windows.Forms;

namespace GomokuGUI
{
    public partial class GameParameters : Form
    {
        public GameParameters()
        {
            InitializeComponent();

            numericUpDownBoardSize.Value = GomokuGame.BoardSize;
            numericUpDownWinning.Value = GomokuGame.WinPiecesCount;
        }

        private void NumericUpDownBoardSize_ValueChanged(object sender, EventArgs e)
        {
            GomokuGame.BoardSize = (int)(sender as NumericUpDown).Value;
        }

        private void NumericUpDownWinning_ValueChanged(object sender, EventArgs e)
        {
            GomokuGame.WinPiecesCount = (int)(sender as NumericUpDown).Value;
        }
    }
}