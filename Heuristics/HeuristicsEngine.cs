using GomokuLib;
using MCTS;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Heuristics
{
    public class HeuristicsEngine<TAction> : IEngine<TAction>
    {
        public TAction CalculateFromExecutedActions(IMCTSAble<TAction> game, IEnumerable<TAction> actions)
        {
            var gomokuActions = actions.Select(a => a as GomokuLib.Action).ToList();
            var gomokuGame = GomokuGame.CreateGomokuGame(gomokuActions);
            var availableActions = game.GetAvailableActions();

            TAction bestAction = actions.FirstOrDefault();
            double bestScore = double.MinValue;
            foreach (var availableAction in availableActions)
            {
                var gameWithAction = GomokuGame.CreateGomokuGame(gomokuActions);
                gameWithAction.ExecuteAction(availableAction as GomokuLib.Action);

                var result = CalculateHeuristics(gameWithAction);

                if (result > bestScore)
                {
                    bestAction = availableAction;
                    bestScore = result;
                }
            }
            return bestAction;
        }

        public static double CalculateHeuristics(GomokuGame gameWithAction)
        {
            var points = 0.0;
            for (var i = 0; i < GomokuGame.BoardSize; i++)
            {
                var actualLineType = LineType.Closed;
                var actualCount = 0;
                for (var j = 0; j < GomokuGame.BoardSize; j++)
                {
                    var cell = gameWithAction.Board[i, j];
                    if (!cell.IsEmpty())
                    {
                        if (cell.Color == gameWithAction.ActualColorMove)
                        {
                            actualCount++;
                        }
                        else
                        {
                            if (actualLineType == LineType.Open)
                            {
                                points += Math.Pow(actualCount / 2, 2);
                                actualCount = 0;
                                actualLineType = LineType.Closed;
                            }
                        }
                    }
                    else
                    {
                        if (actualLineType == LineType.Open)
                        {
                            points += Math.Pow(actualCount, 2);
                        }
                        else
                        {
                            points += Math.Pow(actualCount / 2, 2);
                        }

                        actualCount = 0;
                        actualLineType = LineType.Open;
                    }
                }

                if (actualLineType == LineType.Open)
                {
                    points += Math.Pow(actualCount / 2, 2);
                }
            }

            for (var i = 0; i < GomokuGame.BoardSize; i++)
            {
                var actualLineType = LineType.Closed;
                var actualCount = 0;
                for (var j = 0; j < GomokuGame.BoardSize; j++)
                {
                    var cell = gameWithAction.Board[j, i];
                    if (!cell.IsEmpty())
                    {
                        if (cell.Color == gameWithAction.ActualColorMove)
                        {
                            actualCount++;
                        }
                        else
                        {
                            if (actualLineType == LineType.Open)
                            {
                                points += Math.Pow(actualCount / 2, 2);
                                actualCount = 0;
                                actualLineType = LineType.Closed;
                            }
                        }
                    }
                    else
                    {
                        if (actualLineType == LineType.Open)
                        {
                            points += Math.Pow(actualCount, 2);
                        }
                        else
                        {
                            points += Math.Pow(actualCount / 2, 2);
                        }

                        actualCount = 0;
                        actualLineType = LineType.Open;
                    }
                }

                if (actualLineType == LineType.Open)
                {
                    points += Math.Pow(actualCount / 2, 2);
                }
            }

            return points;
        }

        private enum LineType
        {
            Closed = 1,
            Open = 2,
        }
    }
}