using System;
using System.Collections.Generic;

namespace MCTS
{
    public class UCB1TunedMCTSEngine<TAction> : MCTSEngine<TAction>
    {
        public override string Name { get; } = "UCB1TunedMCTS";

        protected override double CalculateState(State<TAction> state, int n, IEnumerable<TAction> actions)
        {
            if (state.Passes == 0)
            {
                return double.MaxValue;
            }

            var sum = 0.0;
            foreach (var point in state.PointList)
            {
                sum += Math.Pow(point, 2);
            }

            var v = sum / state.Passes - Math.Pow(state.Points / state.Passes, 2) + Math.Sqrt(2 * Math.Log(n) / state.Passes);
            var c = Math.Sqrt(Math.Min(0.25, v));

            return state.Points / state.Passes + c * Math.Sqrt(Math.Log(n) / state.Passes);
        }
    }
}