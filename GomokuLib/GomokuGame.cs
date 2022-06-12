using MCTS;
using System;
using System.Collections.Generic;

namespace GomokuLib
{
    public class GomokuGame : IMCTSAble<Action>
    {
        private static readonly int BoardSize = 10;
        private static readonly int WinPiecesCount = 4;

        public Cell[,] Board { get; set; } = new Cell[BoardSize, BoardSize];
        public Color ActualColorMove { get; set; } = Color.Red;
        public int ActualPieceNumber { get; set; } = 1;

        private GomokuGame()
        { }

        public void PrintBoard()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    var ch = Board[i, j].Color == Color.Red ? "x" : (Board[i, j].Color == Color.Green ? "o" : "-");
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static GomokuGame CreateGomokuGame()
        {
            var game = new GomokuGame();
            for (var i = 0; i < BoardSize; i++)
            {
                for (var j = 0; j < BoardSize; j++)
                {
                    game.Board[i, j] = new();
                }
            }

            return game;
        }

        public static GomokuGame CreateGomokuGame(IEnumerable<Action> actions)
        {
            var game = CreateGomokuGame();
            foreach (var action in actions)
            {
                game.ExecuteAction(action);
            }

            return game;
        }

        public IMCTSAble<Action> GetGame(IEnumerable<Action> actions)
        {
            return CreateGomokuGame(actions);
        }

        public double? GetFirstPlayerPoints()
        {
            if (IsDraw())
            {
                return 0.5;
            }

            var winner = GetWinner();

            if (!winner.HasValue)
            {
                return null;
            }

            if (winner == Color.Red)
            {
                return 1.0;
            }
            else
            {
                return 0.0;
            }
        }

        public bool IsDraw()
        {
            return ActualPieceNumber == BoardSize * BoardSize + 1;
        }

        public List<Action> GetAvailableActions()
        {
            var availableActions = new List<Action>();
            for (var i = 0; i < Board.GetLength(0); i++)
            {
                for (var j = 0; j < Board.GetLength(1); j++)
                {
                    var cell = Board[i, j];
                    if (cell.IsEmpty())
                    {
                        availableActions.Add(new Action(i, j));
                    }
                }
            }

            return availableActions;
        }

        public void ExecuteAction(Action action)
        {
            var cell = Board[action.X, action.Y];
            cell.Update(ActualColorMove, ActualPieceNumber);
            UpdateActualColorMoveAndPieceNumber();
        }

        public Color? GetWinner()
        {
            // TODO ukośne

            for (var i = 0; i < BoardSize; i++)
            {
                var actualCount = 0;
                Color? actualColor = null;
                for (var j = 0; j < BoardSize; j++)
                {
                    var cell = Board[i, j];
                    if (!cell.IsEmpty())
                    {
                        if (cell.Color == actualColor)
                        {
                            actualCount++;
                            if (actualCount == WinPiecesCount)
                            {
                                return actualColor;
                            }
                        }
                        else
                        {
                            actualColor = cell.Color;
                            actualCount = 1;
                        }
                    }
                    else
                    {
                        actualColor = null;
                        actualCount = 0;
                    }
                }
            }

            for (var i = 0; i < BoardSize; i++)
            {
                var actualCount = 0;
                Color? actualColor = null;
                for (var j = 0; j < BoardSize; j++)
                {
                    var cell = Board[j, i];
                    if (!cell.IsEmpty())
                    {
                        if (cell.Color == actualColor)
                        {
                            actualCount++;
                            if (actualCount == 5)
                            {
                                return actualColor;
                            }
                        }
                        else
                        {
                            actualColor = cell.Color;
                            actualCount = 1;
                        }
                    }
                    else
                    {
                        actualColor = null;
                        actualCount = 0;
                    }
                }
            }

            return null;
        }

        private void UpdateActualColorMoveAndPieceNumber()
        {
            ActualPieceNumber++;

            if (ActualColorMove == Color.Red)
            {
                ActualColorMove = Color.Green;
            }
            else
            {
                ActualColorMove = Color.Red;
            }
        }
    }
}