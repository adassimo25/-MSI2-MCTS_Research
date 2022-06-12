using GomokuLib;
using MCTS;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GomokuGUI.Players
{
    public interface IPlayer
    {
        string Name { get; }

        Task<Action> MakeMoveAsync(IMCTSAble<Action> game, IEnumerable<Action> actions);
    }
}