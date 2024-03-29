﻿using System;
using System.Collections.Generic;

namespace MCTS
{
    public class ClassicMCTSEngine<TAction> : MCTSEngine<TAction>
    {
        public override string Name { get; } = "ClassicMCTS";

        protected override double CalculateState(State<TAction> state, int n, IEnumerable<TAction> actions)
        {
            if (state.Passes == 0)
            {
                return double.MaxValue;
            }

            return state.Points / state.Passes + Math.Sqrt(2) * Math.Sqrt(Math.Log(n) / state.Passes);
        }
    }
}