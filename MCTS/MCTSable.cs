using System.Collections.Generic;

namespace MCTS
{
    public interface MCTSable<TAction>
    {
        MCTSable<TAction> GetGame(IEnumerable<TAction> actions);
        List<TAction> GetAvailableActions();
        void ExecuteAction(TAction action);
    }
}
