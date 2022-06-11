﻿using System;
using System.Collections.Generic;
using MCTS;

namespace GomokuLib
{
    public class GomokuGame : MCTSable<Action>
    {
        private static readonly int BoardSize = 15;
        private static readonly int WinPiecesCount = 5;

        public Cell[,] Board { get; set; } = new Cell[BoardSize, BoardSize];
        public Color ActualColorMove { get; set; } = Color.Black;
        public int ActualPieceNumber { get; set; } = 1;
        
        private GomokuGame() { }

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

        public MCTSable<Action> GetGame(IEnumerable<Action> actions)
        {
            return CreateGomokuGame(actions);
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

            if (ActualColorMove == Color.Black)
            {
                ActualColorMove = Color.White;
            }
            else
            {
                ActualColorMove = Color.Black;
            }
        }
    }
}