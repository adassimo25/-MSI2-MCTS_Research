using GomokuLib;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GomokuGUI
{
    public partial class Gomoku
    {
        private async Task Play()
        {
            (var player1, var player2)
                = new Random().Next() % 2 == 0 ? (Player1, Player2) : (Player2, Player1);

            var moveCount = 0;
            var actionsExecuted = new List<GomokuLib.Action>();

            Color? winner;

            while (true)
            {
                var currentPlayer = ((++moveCount % 2) == 1) ? player1 : player2;
                Text = $"Gomoku -> {currentPlayer.Name}'s move!";

                var action = await currentPlayer.MakeMoveAsync(Game, actionsExecuted);
                Game.ExecuteAction(action);
                DrawStone((Color)(-1 * (moveCount % 2) + 2), action.X, action.Y);

                winner = Game.GetWinner();
                if (winner is not null || Game.IsDraw())
                {
                    break;
                }
            }

            if (winner is null)
            {
                (new GameResult("Draw!")).ShowDialog();
            }
            else
            {
                var winnerName = winner.Value == Color.Red ? player1.Name : player2.Name;
                (new GameResult($"{winnerName} won!")).ShowDialog();
            }

            Text = "Gomoku";
        }
    }
}