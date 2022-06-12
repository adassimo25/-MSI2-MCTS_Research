using GomokuLib;
using MCTS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomokuGUI.Players
{
    public class Human : IPlayer
    {
        private readonly PictureBox _board;
        public string Name { get => "Human"; }

        public Human(PictureBox board)
        {
            _board = board;
        }

        public async Task<Action> MakeMoveAsync(IMCTSAble<Action> game, IEnumerable<Action> actions)
        {
            var availableActions = game.GetAvailableActions();
            while (true)
            {
                var e = (await _board.WhenClicked()) as MouseEventArgs;
                (var x, var y) = _board.GetBoardCell(GomokuGame.BoardSize, e.X, e.Y);

                var action = new Action(x, y);
                if (availableActions.Any(aA => aA.X == x && aA.Y == y))
                {
                    return action;
                }
            }
        }
    }
}