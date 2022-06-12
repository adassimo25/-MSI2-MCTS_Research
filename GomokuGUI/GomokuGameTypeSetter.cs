namespace GomokuGUI
{
    public partial class Gomoku
    {
        private void SetBotBotGameType()
        {
            groupBoxBot1.Enabled = true;
            groupBoxBot2.Enabled = true;

            Player1 = CreateBot1();
            Player2 = CreateBot2();
        }

        private void SetBotPlayerGameType()
        {
            groupBoxBot1.Enabled = true;
            groupBoxBot2.Enabled = false;

            Player1 = CreateBot1();
            Player2 = CreateHuman();
        }

        private void SetPlayerPlayerGameType()
        {
            groupBoxBot1.Enabled = false;
            groupBoxBot2.Enabled = false;

            Player1 = CreateHuman();
            Player2 = CreateHuman();
        }
    }
}