using System.Windows.Forms;

namespace GomokuGUI
{
    public partial class GameResult : Form
    {
        public GameResult(string result)
        {
            InitializeComponent();

            labelResult.Text = result;
        }
    }
}