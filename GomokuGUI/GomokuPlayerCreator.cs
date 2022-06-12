using GomokuGUI.Enums;
using GomokuGUI.Players;

namespace GomokuGUI
{
    public partial class Gomoku
    {
        private Human CreateHuman() => new(pictureBox);

        private Bot CreateBot1() => new("Bot Adam", GetBot1CheckedAlgorithm(), trackBarBot1.Value);

        private Bot CreateBot2() => new("Bot Peter", GetBot2CheckedAlgorithm(), trackBarBot2.Value);

        private BotAlgorithmType GetBot1CheckedAlgorithm()
        {
            if (radioButtonBot1MCTSClassic.Checked)
            {
                return BotAlgorithmType.MCTSClassic;
            }

            if (radioButtonBot1MCTSUCB1Tuned.Checked)
            {
                return BotAlgorithmType.MCTSUCB1Tuned;
            }

            if (radioButtonBot1MCTSUCB1withHeuristics.Checked)
            {
                return BotAlgorithmType.MCTSUCB1withHeuristics;
            }

            return BotAlgorithmType.MCTSClassic;
        }

        private BotAlgorithmType GetBot2CheckedAlgorithm()
        {
            if (radioButtonBot2MCTSClassic.Checked)
            {
                return BotAlgorithmType.MCTSClassic;
            }

            if (radioButtonBot2MCTSUCB1Tuned.Checked)
            {
                return BotAlgorithmType.MCTSUCB1Tuned;
            }

            if (radioButtonBot2MCTSUCB1withHeuristics.Checked)
            {
                return BotAlgorithmType.MCTSUCB1withHeuristics;
            }

            return BotAlgorithmType.MCTSClassic;
        }
    }
}