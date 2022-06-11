namespace GomokuGUI
{
    public partial class Gomoku
    {
        private void SetBotBotGameType()
        {
            GameType = GameType.BotBot;
            Player1 = CreateBot1();
            Player2 = CreateBot2();

            groupBoxBot1.Text = "Bot 1";
            groupBoxBot1.Enabled = true;
            groupBoxBot2.Enabled = true;
        }

        private void SetBotPlayerGameType()
        {
            GameType = GameType.BotPlayer;
            Player1 = CreateBot1();
            Player2 = CreateHuman();

            groupBoxBot1.Text = "Bot";
            groupBoxBot1.Enabled = true;
            groupBoxBot2.Enabled = false;
        }

        private void SetPlayerPlayerGameType()
        {
            GameType = GameType.PlayerPlayer;
            Player1 = CreateHuman();
            Player2 = CreateHuman();

            groupBoxBot1.Text = "Bot 1";
            groupBoxBot1.Enabled = false;
            groupBoxBot2.Enabled = false;
        }
    }
}