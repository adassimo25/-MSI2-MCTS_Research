using System;
using System.Windows.Forms;

namespace GomokuGUI
{
    public partial class GameParameters : Form
    {
        private Gomoku Gomoku { get; set; }

        public GameParameters(Gomoku gomoku)
        {
            InitializeComponent();

            Gomoku = gomoku;

            numericUpDownBoardSize.Value = gomoku.BoardSize;
            numericUpDownWinning.Value = gomoku.Winning;
        }

        private void NumericUpDownBoardSize_ValueChanged(object sender, EventArgs e)
        {
            Gomoku.BoardSize = (int)(sender as NumericUpDown).Value;
        }

        private void NumericUpDownWinning_ValueChanged(object sender, EventArgs e)
        {
            Gomoku.Winning = (int)(sender as NumericUpDown).Value;
        }
    }
}