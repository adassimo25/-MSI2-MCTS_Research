namespace GomokuGUI.Players
{
    public class Bot : IPlayer
    {
        private readonly BotAlgorithmType _algorithmType;
        private readonly int? _iterations;

        public BotAlgorithmType AlgorithmType { get => _algorithmType; }
        public int? Iterations { get => _iterations; }

        public Bot(BotAlgorithmType algorithmType, int? iterations = null)
        {
            _algorithmType = algorithmType;
            _iterations = (algorithmType == BotAlgorithmType.GreedyHeuristic ? null : iterations);
        }
    }
}