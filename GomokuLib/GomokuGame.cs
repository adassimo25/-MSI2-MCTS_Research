using MCTS;
using System;
using System.Collections.Generic;

namespace GomokuLib
{
    public class GomokuGame : IMCTSAble<Action>
    {
        public static int BoardSize { get; set; } = 13;
        public static int WinPiecesCount { get; set; } = 5;

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
            => CheckDiagonalWinner() ?? CheckHorizontalWinner() ?? CheckVerticalWinner() ?? null;

        private Color? CheckDiagonalWinner()
        {
            for (var i = 0; i < BoardSize - WinPiecesCount + 1; i++)
            {
                var bestCount = 0;
                Color? bestColor = null;

                var currentCount = 0;
                Color? currentColor = null;

                for (var j = 0; j < BoardSize - i; j++)
                {
                    AnalyzeCell(Board[j, j + i],
                        ref bestCount, ref bestColor, ref currentCount, ref currentColor);
                }

                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestColor = currentColor;
                }

                if (bestCount == WinPiecesCount)
                {
                    return bestColor;
                }
            }

            for (var i = 1; i < BoardSize - WinPiecesCount + 1; i++)
            {
                var bestCount = 0;
                Color? bestColor = null;

                var currentCount = 0;
                Color? currentColor = null;

                for (var j = 0; j < BoardSize - i; j++)
                {
                    AnalyzeCell(Board[j + i, j],
                        ref bestCount, ref bestColor, ref currentCount, ref currentColor);
                }

                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestColor = currentColor;
                }

                if (bestCount == WinPiecesCount)
                {
                    return bestColor;
                }
            }

            for (var i = 0; i < BoardSize - WinPiecesCount + 1; i++)
            {
                var bestCount = 0;
                Color? bestColor = null;

                var currentCount = 0;
                Color? currentColor = null;

                for (var j = 0; j < BoardSize - i; j++)
                {
                    AnalyzeCell(Board[j, BoardSize - 1 - (j + i)],
                        ref bestCount, ref bestColor, ref currentCount, ref currentColor);
                }

                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestColor = currentColor;
                }

                if (bestCount == WinPiecesCount)
                {
                    return bestColor;
                }
            }

            for (var i = 1; i < BoardSize - WinPiecesCount + 1; i++)
            {
                var bestCount = 0;
                Color? bestColor = null;

                var currentCount = 0;
                Color? currentColor = null;

                for (var j = 0; j < BoardSize - i; j++)
                {
                    AnalyzeCell(Board[j + i, BoardSize - 1 - j],
                        ref bestCount, ref bestColor, ref currentCount, ref currentColor);
                }

                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestColor = currentColor;
                }

                if (bestCount == WinPiecesCount)
                {
                    return bestColor;
                }
            }

            return null;
        }

        private Color? CheckHorizontalWinner()
        {
            for (var i = 0; i < BoardSize; i++)
            {
                var bestCount = 0;
                Color? bestColor = null;

                var currentCount = 0;
                Color? currentColor = null;

                for (var j = 0; j < BoardSize; j++)
                {
                    AnalyzeCell(Board[j, i],
                        ref bestCount, ref bestColor, ref currentCount, ref currentColor);
                }

                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestColor = currentColor;
                }

                if (bestCount == WinPiecesCount)
                {
                    return bestColor;
                }
            }

            return null;
        }

        private Color? CheckVerticalWinner()
        {
            for (var i = 0; i < BoardSize; i++)
            {
                var bestCount = 0;
                Color? bestColor = null;

                var currentCount = 0;
                Color? currentColor = null;

                for (var j = 0; j < BoardSize; j++)
                {
                    AnalyzeCell(Board[i, j],
                        ref bestCount, ref bestColor, ref currentCount, ref currentColor);
                }

                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestColor = currentColor;
                }

                if (bestCount == WinPiecesCount)
                {
                    return bestColor;
                }
            }

            return null;
        }

        private static void AnalyzeCell(Cell cell,
            ref int bestCount, ref Color? bestColor, ref int currentCount, ref Color? currentColor)
        {
            if (!cell.IsEmpty() && cell.Color == currentColor)
            {
                currentCount++;
            }
            else
            {
                if (bestCount < currentCount)
                {
                    bestCount = currentCount;
                    bestColor = currentColor;
                }

                currentCount = 1;
                currentColor = cell.Color;
            }
        }

        private void UpdateActualColorMoveAndPieceNumber()
        {
            ActualPieceNumber++;
            ActualColorMove = ActualColorMove == Color.Red ? Color.Green : Color.Red;
        }
    }
}