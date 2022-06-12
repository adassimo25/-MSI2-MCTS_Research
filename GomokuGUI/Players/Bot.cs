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
        private readonly int? _iterations;

        public string Name { get => _name; }
        public BotAlgorithmType AlgorithmType { get => _algorithmType; }
        public IEngine<Action> Engine { get => _engine; }
        public int? Iterations { get => _iterations; }

        public Bot(string name, BotAlgorithmType algorithmType, int? iterations = null)
        {
            _name = name;
            _engine = GetEngineForAlgorithm(algorithmType);
            _iterations = (algorithmType == BotAlgorithmType.GreedyHeuristics ? null : iterations);
        }

        private static IEngine<Action> GetEngineForAlgorithm(BotAlgorithmType algorithmType)
        {
            return algorithmType switch
            {
                BotAlgorithmType.MCTSClassic => new ClassicMCTSEngine<Action>(),
                BotAlgorithmType.MCTSUCB1Tuned => new UCB1TunedMCTSEngine<Action>(),
                BotAlgorithmType.MCTSUCB1withHeuristics => new HeuristicsMCTSEngine<Action>(),
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