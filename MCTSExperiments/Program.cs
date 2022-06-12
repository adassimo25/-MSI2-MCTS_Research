using GomokuLib;
using Heuristics;
using MCTS;
using System;
using System.Collections.Generic;

namespace MCTSExperiments
{
    internal class Program
    {
        private static void Main()
        {
            var game = GomokuGame.CreateGomokuGame();

            var engine1 = new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1000 };
            var engine2 = new HeuristicsEngine<GomokuLib.Action>();

            var moveCount = 0;
            var actionsExecuted = new List<GomokuLib.Action>();

            Color? winner;

            while (true)
            {
                IEngine<GomokuLib.Action> currentEngine;
                if (++moveCount % 2 == 1)
                {
                    currentEngine = engine1;
                }
                else
                {
                    currentEngine = engine2;
                }

                var action = currentEngine.CalculateFromExecutedActions(game, actionsExecuted);

                game.ExecuteAction(action);

                game.PrintBoard();

                winner = game.GetWinner();

                if (winner is not null || game.IsDraw())
                {
                    game.PrintBoard();
                    break;
                }
            }

            if (winner is null)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                var winnerString = winner.Value == Color.Green ? "engine1" : "engine2";
                Console.WriteLine($"Winner: {winnerString}");
            }
        }
    }
}