using System.Collections.Generic;

namespace MCTS
{
    public interface IEngine<TAction>
    {
        public string Name { get; }

        public TAction CalculateFromExecutedActions(IMCTSAble<TAction> game, IEnumerable<TAction> actions);
    }
}