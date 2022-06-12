using System;
using System.Collections.Generic;

namespace MCTS
{
    public class UCB1TunedMCTSEngine<TAction> : MCTSEngine<TAction>
    {
        protected override double CalculateState(State<TAction> state, int n, IEnumerable<State<TAction>> allStates, IEnumerable<TAction> actions)
        {
            if (state.Passes == 0)
            {
                return double.MaxValue;
            }

            var sum = 0.0;
            var div = 0;
            foreach (var allState in allStates)
            {
                if(allState.Id <= state.Id)
                {
                    sum += Math.Pow(allState.Points - state.Points, 2);
                    div++;
                }
            }

            var r = state.Passes;
            var v = sum/div + Math.Sqrt(2 * Math.Log(n) / div);
            var c = Math.Sqrt(Math.Min(0.25, v));

            return state.Points / state.Passes + c * Math.Sqrt(Math.Log(n) / state.Passes);
        }
    }
}
