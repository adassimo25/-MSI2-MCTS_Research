using System;
using System.Drawing;

namespace GomokuGUI
{
    public partial class Gomoku
    {
        private static readonly float borderThickness = 1.5f;

        private readonly Graphics graphics;

        private void ClearBoard()
        {
            graphics.Clear(pictureBox.BackColor);
            pictureBox.Refresh();
        }

        private void DrawNet()
        {
            var (width, height) = ((float)pictureBox.Width, (float)pictureBox.Height);
            var boardSize = GomokuLib.GomokuGame.BoardSize;

            var pen = new Pen(Color.Black, borderThickness);

            for (int i = 1; i < boardSize; i++)
            {
                graphics.DrawLine(pen, 0, i * height / boardSize, width, i * height / boardSize);
                graphics.DrawLine(pen, i * width / boardSize, 0, i * width / boardSize, height);
            }

            pictureBox.Refresh();
        }

        private void DrawStone(GomokuLib.Color color, int netX, int netY)
        {
            var (width, height) = ((float)pictureBox.Width, (float)pictureBox.Height);
            var boardSize = GomokuLib.GomokuGame.BoardSize;

            var radius = Math.Min(width / boardSize, height / boardSize) - 3;
            var deltaX = (width / boardSize - radius) / 2.0f;
            var deltaY = (height / boardSize - radius) / 2.0f;
            var centreX = netX * width / boardSize + deltaX;
            var centreY = netY * height / boardSize + deltaY;

            graphics.FillEllipse(new SolidBrush(color == GomokuLib.Color.Red ? Color.Red : Color.Green),
                centreX, centreY, radius, radius);
            pictureBox.Refresh();
        }
    }
}