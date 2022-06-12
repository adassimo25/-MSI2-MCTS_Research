using System.Collections.Generic;

namespace MCTS
{
    public interface IEngine<TAction>
    {
        public TAction CalculateFromExecutedActions(IMCTSAble<TAction> game, IEnumerable<TAction> actions);
    }
}