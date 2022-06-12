using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomokuGUI
{
    public static class PictureBoxExtensions
    {
        public static Task<object> WhenClicked(this PictureBox target)
        {
            var tcs = new TaskCompletionSource<object>();

            void onClick(object sender, EventArgs e)
            {
                target.Click -= onClick;
                tcs.TrySetResult(e);
            }

            target.Click += onClick;

            return tcs.Task;
        }

        public static (int x, int y) GetBoardCell(this PictureBox board, int cells, int x, int y)
            => ((int)(x / ((float)board.Width / cells)), (int)(y / ((float)board.Height / cells)));
    }
}