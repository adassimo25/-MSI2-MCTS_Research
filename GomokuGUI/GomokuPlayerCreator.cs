using GomokuGUI.Players;

namespace GomokuGUI
{
    public partial class Gomoku
    {
        private static Human CreateHuman() => new();

        private Bot CreateBot1() => new(GetBot1CheckedAlgorithm(), trackBarBot1.Value);

        private Bot CreateBot2() => new(GetBot2CheckedAlgorithm(), trackBarBot2.Value);

        private BotAlgorithmType GetBot1CheckedAlgorithm()
        {
            if (radioButtonBot1MCTSClassic.Checked)
            {
                return BotAlgorithmType.MCTSClassic;
            }

            if (radioButtonBot1MCTSUCB1TUNED.Checked)
            {
                return BotAlgorithmType.MCTSUCB1TUNED;
            }

            if (radioButtonBot1MCTSUCB1withVF.Checked)
            {
                return BotAlgorithmType.MCTSUCB1withValueFunction;
            }

            return BotAlgorithmType.MCTSClassic;
        }

        private BotAlgorithmType GetBot2CheckedAlgorithm()
        {
            if (radioButtonBot2MCTSClassic.Checked)
            {
                return BotAlgorithmType.MCTSClassic;
            }

            if (radioButtonBot2MCTSUCB1TUNED.Checked)
            {
                return BotAlgorithmType.MCTSUCB1TUNED;
            }

            if (radioButtonBot2MCTSUCB1withVF.Checked)
            {
                return BotAlgorithmType.MCTSUCB1withValueFunction;
            }

            return BotAlgorithmType.MCTSClassic;
        }
    }
}