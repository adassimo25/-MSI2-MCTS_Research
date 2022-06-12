using GomokuLib;
using MCTS;
using System.Collections.Generic;
using System.Linq;

namespace Heuristics
{
    public class HeuristicsEngine<TAction> : IEngine<TAction>
    {
        public TAction CalculateFromExecutedActions(IMCTSAble<TAction> game, IEnumerable<TAction> actions)
        {
            var gomokuActions = actions.Select(a => a as Action).ToList();
            var gomokuGame = GomokuGame.CreateGomokuGame(gomokuActions);
            var availableActions = game.GetAvailableActions();

            TAction bestAction = actions.First();
            double bestScore = double.MinValue;
            foreach (var availableAction in availableActions)
            {
                var gameWithAction = GomokuGame.CreateGomokuGame(gomokuActions);
                gameWithAction.ExecuteAction(availableAction as Action);

                var result = CalculateHeuristics(gameWithAction);

                if (result > bestScore)
                {
                    bestAction = availableAction;
                    bestScore = result;
                }
            }
            return bestAction;
        }

        public static double CalculateHeuristics(GomokuGame gameWithAction)
        {
            // TODO

            return 0;
        }
    }
}