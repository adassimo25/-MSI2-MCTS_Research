using System;
using System.Collections.Generic;
using System.Linq;
using GomokuLib;
using MCTS;

namespace MCTSExperiments
{
    class Program
    {
        static void Main()
        {
            var game = GomokuGame.CreateGomokuGame();

            var engine1 = new MCTSEngine<GomokuLib.Action>();
            var engine2 = new MCTSEngine<GomokuLib.Action>();

            var moveCount = 0;
            var actionsExecuted = new List<GomokuLib.Action>();

            Color? winner = null; 

            while (true)
            {
                MCTSEngine<GomokuLib.Action> currentEngine;
                if (moveCount % 2 == 0)
                {
                    currentEngine = engine1;
                }
                else
                {
                    currentEngine = engine2;
                }

                var action = currentEngine.CalculateFromExecutedActions(game, actionsExecuted);

                game.ExecuteAction(action);

                winner = game.GetWinner();

                if (winner is not null || game.IsDraw())
                {
                    break;
                }
            }

            if (winner is null)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                var winnerString = winner.Value == Color.Black ? "engine1" : "engine2";
                Console.WriteLine($"Winner: {winnerString}");
            }
        }
    }
}
