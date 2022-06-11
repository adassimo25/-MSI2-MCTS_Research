using System.Collections.Generic;
using System.Linq;

namespace MCTS
{
    public class MCTSEngine<TAction>
    {
        public int IterationCount { get; set; }
        public State CurrentState { get; set; }

        public State RootState { get; set; }

        public TAction CalculateFromExecutedActions(MCTSable<TAction> game, IEnumerable<TAction> actions)
        {
            // clear roostate, intercount ...
            for (var i = 0; i < IterationCount; i++)
            {
                var iterationGame = game.GetGame(actions);

                // algorithm
            }

            // mocked
            var actionsAvailable = game.GetAvailableActions();
            return actionsAvailable.First();
        }
    }

    public class State
    {
        public ulong Id { get; set; }
    }
}
