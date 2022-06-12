using GomokuLib;
using MCTS;
using System.Collections.Generic;

namespace GomokuGUI.Players
{
    public class Human : IPlayer
    {
        public string Name { get => "Human"; }

        public Action MakeMove(IMCTSAble<Action> game, IEnumerable<Action> actions)
        {
            // TODO

            return null;
        }
    }
}