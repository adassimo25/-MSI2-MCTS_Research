using GomokuLib;
using MCTS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Heuristics
{
    public class HeuristicsMCTSEngine<TAction> : MCTSEngine<TAction>
    {
        public override string Name { get; } = "HeuristicsMCTS";

        protected override double CalculateState(State<TAction> state, int n, IEnumerable<TAction> actions)
        {
            if (state.Passes == 0)
            {
                return double.MaxValue;
            }

            var gomokuActions = actions.Select(a => a as GomokuLib.Action).ToList();
            var gomokuGame = GomokuGame.CreateGomokuGame(gomokuActions);

            var d = Math.Sqrt(2);

            return state.Points / state.Passes + Math.Sqrt(2) * Math.Sqrt(Math.Log(n) / state.Passes) + d * HeuristicsEngine<TAction>.CalculateHeuristics(gomokuGame);
        }
    }
}