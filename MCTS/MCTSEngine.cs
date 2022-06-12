using System;
using System.Collections.Generic;
using System.Linq;

namespace MCTS
{
    public abstract class MCTSEngine<TAction> : IEngine<TAction>
    {
        public abstract string Name { get; }

        public int IterationCount { get; set; }

        private State<TAction> RootState { get; set; }
        private int LastStateNumber { get; set; }
        private Random Random { get; set; } = new Random();

        public TAction CalculateFromExecutedActions(IMCTSAble<TAction> game, IEnumerable<TAction> actions)
        {
            InitNew();

            var initialActions = game.GetAvailableActions();
            foreach (var availableAction in initialActions)
            {
                RootState.AddChild(State<TAction>.Create(++LastStateNumber, availableAction));
            }

            for (var i = 0; i < IterationCount; i++)
            {
                var currentState = RootState;
                var firstPlayerMoves = actions.Count() % 2 == 0;
                var iterationGame = game.GetGame(actions);

                var visitedStates = new List<State<TAction>> { RootState };

                while (true)
                {
                    if (currentState.Childs.Count == 0)
                    {
                        break;
                    }

                    State<TAction> bestChild = null;
                    double bestValue = double.MinValue;

                    foreach (var child in currentState.Childs)
                    {
                        var res = CalculateState(child, currentState.Passes, actions);
                        if (res > bestValue)
                        {
                            bestChild = child;
                            bestValue = res;
                        }
                    }

                    visitedStates.Add(bestChild);
                    currentState = bestChild;
                }

                if (currentState.Passes != 0)
                {
                    var availableActions = iterationGame.GetAvailableActions();
                    foreach (var availableAction in availableActions)
                    {
                        currentState.AddChild(State<TAction>.Create(++LastStateNumber, availableAction));
                    }
                }

                var result = Rollout(iterationGame, firstPlayerMoves);

                Backpropagate(visitedStates, result);
            }

            return GetResultState(RootState).Action;
        }

        protected abstract double CalculateState(State<TAction> state, int n, IEnumerable<TAction> actions);

        private State<TAction> GetResultState(State<TAction> rootState)
        {
            State<TAction> bestChild = null;
            double bestValue = double.MinValue;

            foreach (var child in rootState.Childs)
            {
                var res = child.Points;
                if (res > bestValue)
                {
                    bestValue = res;
                    bestChild = child;
                }
            }

            return bestChild;
        }

        private static void Backpropagate(IEnumerable<State<TAction>> visitedStates, double result)
        {
            foreach (var state in visitedStates)
            {
                state.Visit(result);
            }
        }

        private double Rollout(IMCTSAble<TAction> game, bool firstPlayerMoves)
        {
            while (true)
            {
                var points = game.GetFirstPlayerPoints();
                if (points.HasValue)
                {
                    return 1.0 * (firstPlayerMoves ? (double)points : (double)(1.0 - points));
                }

                var availableActions = game.GetAvailableActions();
                var randomAction = availableActions[Random.Next(availableActions.Count)];

                game.ExecuteAction(randomAction);
            }
        }

        private void InitNew()
        {
            RootState = State<TAction>.CreateInitial();
            LastStateNumber = 0;
        }
    }
}