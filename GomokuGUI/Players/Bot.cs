using GomokuGUI.Enums;
using GomokuLib;
using Heuristics;
using MCTS;
using System.Collections.Generic;

namespace GomokuGUI.Players
{
    public class Bot : IPlayer
    {
        private readonly string _name;
        private readonly BotAlgorithmType _algorithmType;
        private readonly IEngine<Action> _engine;

        public string Name { get => _name; }
        public BotAlgorithmType AlgorithmType { get => _algorithmType; }
        public IEngine<Action> Engine { get => _engine; }

        public Bot(string name, BotAlgorithmType algorithmType, int? iterations = null)
        {
            _name = name;
            _algorithmType = algorithmType;
            _engine = GetEngineForAlgorithm(algorithmType, iterations);
        }

        private static IEngine<Action> GetEngineForAlgorithm(BotAlgorithmType algorithmType, int? iterations)
        {
            return algorithmType switch
            {
                BotAlgorithmType.MCTSClassic =>
                    new ClassicMCTSEngine<Action>() { IterationCount = (int)iterations },
                BotAlgorithmType.MCTSUCB1Tuned =>
                    new UCB1TunedMCTSEngine<Action>() { IterationCount = (int)iterations },
                BotAlgorithmType.MCTSUCB1withHeuristics =>
                    new HeuristicsMCTSEngine<Action>() { IterationCount = (int)iterations },
                BotAlgorithmType.GreedyHeuristics => new HeuristicsEngine<Action>(),
                _ => null,
            };
        }

        public Action MakeMove(IMCTSAble<Action> game, IEnumerable<Action> actions)
        {
            return _engine.CalculateFromExecutedActions(game, actions);
        }
    }
}