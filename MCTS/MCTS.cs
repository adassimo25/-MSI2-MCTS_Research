using System;
using System.Collections.Generic;
using System.Linq;

namespace MCTS
{
    public class MCTSEngine<TAction>
    {
        public int IterationCount { get; set; }
        
        private State<TAction> RootState { get; set; }
        private int LastStateNumber { get; set; }
        private Random Random { get; set; } = new Random();

        public double CalculateState(State<TAction> state, int n)
        {
            if (state.Passes == 0)
            {
                return double.MaxValue;
            }

            return state.Points / state.Passes + Math.Sqrt(2) * Math.Sqrt(Math.Log(n)/state.Passes);
        }

        public TAction CalculateFromExecutedActions(MCTSable<TAction> game, IEnumerable<TAction> actions)
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
                var actionsExecutedCount = actions.Count();
                var iterationGame = game.GetGame(actions);

                var visitedStates = new List<State<TAction>>();

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
                        var res = CalculateState(child, i);
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

                var result = Rollout(iterationGame, ref actionsExecutedCount);

                Backpropagate(visitedStates, result);
            }

            return GetResultState(RootState).Action;
        }

        private State<TAction> GetResultState(State<TAction> rootState)
        {
            State<TAction> bestChild = null;
            double bestValue = double.MinValue;

            foreach (var child in rootState.Childs)
            {
                var res = CalculateState(child, IterationCount);
                if (res > bestValue)
                {
                    bestValue = res;
                    bestChild = child;
                }
            }

            return bestChild;
        }

        private void Backpropagate(IEnumerable<State<TAction>> visitedStates, double result)
        {
            foreach(var state in visitedStates)
            {
                state.Visit(result);
            }
        }

        private double Rollout(MCTSable<TAction> game, ref int actionsExecutedCount)
        {
            while(true)
            {
                var points = game.GetFirstPlayerPoints();
                if (points.HasValue)
                {
                    return WasFirstPlayerMove(ref actionsExecutedCount) ? (double)points : (double)(1.0 - points); 
                }

                var availableActions = game.GetAvailableActions();
                var randomAction = availableActions[Random.Next(availableActions.Count)];

                game.ExecuteAction(randomAction);
                actionsExecutedCount++;
            }
        }

        private bool WasFirstPlayerMove(ref int actionsExecutedCount)
        {
            return actionsExecutedCount % 2 == 1;
        }

        private void InitNew()
        {
            RootState = State<TAction>.CreateInitial();
            LastStateNumber = 0;
        }
    }

    public class State<TAction>
    {
        public int Id { get; set; }
        public double Points { get; set; } = 0.0;
        public int Passes { get; set; } = 0;
        public TAction Action { get; set; }

        public List<State<TAction>> Childs { get; set; } = new();

        public static State<TAction> Create(int id, TAction action)
        {
            return new()
            {
                Id = id,
                Action = action,
            };
        }

        public static State<TAction> CreateInitial()
        {
            return new()
            {
                Id = 0,
            };
        }

        public void AddChild(State<TAction> state)
        {
            Childs.Add(state);
        }

        public void Visit(double points)
        {
            Passes++;
            Points += points;
        }
    }
}
