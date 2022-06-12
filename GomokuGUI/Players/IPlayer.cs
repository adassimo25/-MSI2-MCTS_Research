using GomokuLib;
using MCTS;
using System.Collections.Generic;

namespace GomokuGUI.Players
{
    public interface IPlayer
    {
        string Name { get; }
        Action MakeMove(IMCTSAble<Action> game, IEnumerable<Action> actions);
    }
}