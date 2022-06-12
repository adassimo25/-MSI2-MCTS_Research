using GomokuGUI.Players;
using GomokuLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GomokuGUI
{
    public partial class Gomoku
    {
        private void Play()
        {
            var firstMove = (new Random()).Next() % 2;

            var moveCount = firstMove;
            var actionsExecuted = new List<GomokuLib.Action>();

            Color? winner;
            Color current = Color.Red;

            while (true)
            {
                IPlayer currentPlayer = ((++moveCount % 2) == 1) ? Player1 : Player2;
                Text = $"Gomoku -> {currentPlayer.Name}'s move";

                var action = currentPlayer.MakeMove(Game, actionsExecuted);
                Game.ExecuteAction(action);
                DrawStone((Color)(((int)current++ - 1) % 2 + 1), action.X, action.Y);

                winner = Game.GetWinner();
                if (winner is not null || Game.IsDraw())
                {
                    break;
                }
            }

            if (winner is null)
            {
                MessageBox.Show("Draw!");
            }
            else
            {
                var winnerName = (((int)winner.Value + firstMove) % 2 == 0) ? Player1.Name : Player2.Name;
                MessageBox.Show($"{winnerName} won!");
            }

            Text = "Gomoku";
        }
    }
}