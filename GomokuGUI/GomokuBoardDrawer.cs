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
            var pen = new Pen(Color.Black, borderThickness);
            var (width, height) = ((float)pictureBox.Width, (float)pictureBox.Height);

            for (int i = 1; i < BoardSize; i++)
            {
                graphics.DrawLine(pen, 0, i * height / BoardSize, width, i * height / BoardSize);
                graphics.DrawLine(pen, i * width / BoardSize, 0, i * width / BoardSize, height);
            }

            pictureBox.Refresh();
        }

        private void DrawStone(Color color, int netX, int netY)
        {
            var (width, height) = ((float)pictureBox.Width, (float)pictureBox.Height);

            var radius = Math.Min(width / BoardSize, height / BoardSize) - 3;
            var deltaX = (width / BoardSize - radius) / 2.0f;
            var deltaY = (height / BoardSize - radius) / 2.0f;
            var centreX = netX * width / BoardSize + deltaX;
            var centreY = netY * height / BoardSize + deltaY;

            graphics.FillEllipse(new SolidBrush(color), centreX, centreY, radius, radius);
            pictureBox.Refresh();
        }
    }
}