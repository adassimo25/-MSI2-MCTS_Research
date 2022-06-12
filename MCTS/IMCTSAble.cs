using System.Collections.Generic;

namespace MCTS
{
    public interface IMCTSAble<TAction>
    {
        IMCTSAble<TAction> GetGame(IEnumerable<TAction> actions);

        List<TAction> GetAvailableActions();

        void ExecuteAction(TAction action);

        double? GetFirstPlayerPoints();
    }
}