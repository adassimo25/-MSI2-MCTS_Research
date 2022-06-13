using GomokuLib;
using Heuristics;
using IronXL;
using MCTS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace MCTSExperiments
{
    internal class Program
    {
        private static void Main()
        {
            GomokuGame.BoardSize = 10;
            GomokuGame.WinPiecesCount = 4;

            Directory.CreateDirectory(Results.Directory);

            WorkBook results = new WorkBook();

            Console.WriteLine("=======================================================================");

            WorkSheet ht1 = results.CreateWorkSheet(Results.WorksheetHypothesis1);
            VerifyHypothesis1(ht1);

            Console.WriteLine();

            WorkSheet ht2 = results.CreateWorkSheet(Results.WorksheetHypothesis2);
            VerifyHypothesis2(ht2);

            Console.WriteLine();

            WorkSheet ht3 = results.CreateWorkSheet(Results.WorksheetHypothesis3);
            VerifyHypothesis3(ht3);

            Console.WriteLine("=======================================================================");

            var file = $"{Results.Directory}/{Results.FileName}" +
                $"_size-{GomokuGame.BoardSize}_win-{GomokuGame.WinPiecesCount}" +
                $"_{DateTime.Now.ToString(Results.FileDateFormat)}.{Results.FileExtension}";
            results.SaveAs(file);
        }

        private static void VerifyHypothesis1(WorkSheet ws)
        {
            var repeat = 3;

            List<(MCTSEngine<GomokuLib.Action> p1, MCTSEngine<GomokuLib.Action> p2, int iterations)> playersPairs = new()
            {
                (new ClassicMCTSEngine<GomokuLib.Action>(), new UCB1TunedMCTSEngine<GomokuLib.Action>(), 500),
                (new UCB1TunedMCTSEngine<GomokuLib.Action>(), new ClassicMCTSEngine<GomokuLib.Action>(), 500),
                (new ClassicMCTSEngine<GomokuLib.Action>(), new UCB1TunedMCTSEngine<GomokuLib.Action>(), 1000),
                (new UCB1TunedMCTSEngine<GomokuLib.Action>(), new ClassicMCTSEngine<GomokuLib.Action>(), 1000),
                (new ClassicMCTSEngine<GomokuLib.Action>(), new UCB1TunedMCTSEngine<GomokuLib.Action>(), 1500),
                (new UCB1TunedMCTSEngine<GomokuLib.Action>(), new ClassicMCTSEngine<GomokuLib.Action>(), 1500),
                (new ClassicMCTSEngine<GomokuLib.Action>(), new HeuristicsMCTSEngine<GomokuLib.Action>(), 500),
                (new HeuristicsMCTSEngine<GomokuLib.Action>(), new ClassicMCTSEngine<GomokuLib.Action>(), 500),
                (new ClassicMCTSEngine<GomokuLib.Action>(), new HeuristicsMCTSEngine<GomokuLib.Action>(), 1000),
                (new HeuristicsMCTSEngine<GomokuLib.Action>(), new ClassicMCTSEngine<GomokuLib.Action>(), 1000),
                (new ClassicMCTSEngine<GomokuLib.Action>(), new HeuristicsMCTSEngine<GomokuLib.Action>(), 1500),
                (new HeuristicsMCTSEngine<GomokuLib.Action>(), new ClassicMCTSEngine<GomokuLib.Action>(), 1500)
            };

            var row = 1;

            ws[$"A{row}"].Value = "PLAYER-1";
            ws[$"A{row}"].Style.Font.Bold = true;
            ws[$"B{row}"].Value = "PLAYER-2";
            ws[$"B{row}"].Style.Font.Bold = true;
            ws[$"C{row}"].Value = "ITERATIONS";
            ws[$"C{row}"].Style.Font.Bold = true;
            ws[$"D{row}"].Value = "TIME";
            ws[$"D{row}"].Style.Font.Bold = true;
            ws[$"E{row}"].Value = "WINNER";
            ws[$"E{row}"].Style.Font.Bold = true;

            row++;

            var stopwatch = new Stopwatch();

            foreach (var pair in playersPairs)
            {
                for (int i = 0; i < repeat; i++)
                {
                    var game = GomokuGame.CreateGomokuGame();

                    pair.p1.IterationCount = pair.iterations;
                    pair.p2.IterationCount = pair.iterations;

                    ws[$"A{row}"].Value = pair.p1.Name;
                    ws[$"B{row}"].Value = pair.p2.Name;
                    ws[$"C{row}"].Value = pair.iterations;

                    stopwatch.Reset();
                    stopwatch.Start();

                    var result = PlayGame(game, pair.p1, pair.p2);

                    stopwatch.Stop();

                    ws[$"D{row}"].Value = stopwatch.ElapsedMilliseconds / 1000.0;
                    ws[$"E{row}"].Value = result;

                    row++;

                    Console.WriteLine($"Verifying hypothesis no. 1: pair no. {playersPairs.IndexOf(pair) + 1} {i + 1}/{repeat}");
                }
            }
        }

        private static void VerifyHypothesis2(WorkSheet ws)
        {
            var repeat = 3;

            List<(MCTSEngine<GomokuLib.Action> p1, HeuristicsEngine<GomokuLib.Action> p2)> playersPairs = new()
            {
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 500 }, new HeuristicsEngine<GomokuLib.Action>()),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1000 }, new HeuristicsEngine<GomokuLib.Action>()),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1500 }, new HeuristicsEngine<GomokuLib.Action>()),
                (new UCB1TunedMCTSEngine<GomokuLib.Action>() { IterationCount = 500 }, new HeuristicsEngine<GomokuLib.Action>()),
                (new UCB1TunedMCTSEngine<GomokuLib.Action>() { IterationCount = 1000 }, new HeuristicsEngine<GomokuLib.Action>()),
                (new UCB1TunedMCTSEngine<GomokuLib.Action>() { IterationCount = 1500 }, new HeuristicsEngine<GomokuLib.Action>()),
                (new HeuristicsMCTSEngine<GomokuLib.Action>() { IterationCount = 500 }, new HeuristicsEngine<GomokuLib.Action>()),
                (new HeuristicsMCTSEngine<GomokuLib.Action>() { IterationCount = 1000 }, new HeuristicsEngine<GomokuLib.Action>()),
                (new HeuristicsMCTSEngine<GomokuLib.Action>() { IterationCount = 1500 }, new HeuristicsEngine<GomokuLib.Action>())
            };

            var row = 1;

            ws[$"A{row}"].Value = "PLAYER-1";
            ws[$"A{row}"].Style.Font.Bold = true;
            ws[$"B{row}"].Value = "PLAYER-1 ITERATIONS";
            ws[$"B{row}"].Style.Font.Bold = true;
            ws[$"C{row}"].Value = "PLAYER-2";
            ws[$"C{row}"].Style.Font.Bold = true;
            ws[$"D{row}"].Value = "STARTING PLAYER";
            ws[$"D{row}"].Style.Font.Bold = true;
            ws[$"E{row}"].Value = "TIME";
            ws[$"E{row}"].Style.Font.Bold = true;
            ws[$"F{row}"].Value = "WINNER";
            ws[$"F{row}"].Style.Font.Bold = true;

            row++;

            var stopwatch = new Stopwatch();

            foreach (var pair in playersPairs)
            {
                for (int i = 0; i < repeat; i++)
                {
                    var game = GomokuGame.CreateGomokuGame();

                    ws[$"A{row}"].Value = pair.p1.Name;
                    ws[$"B{row}"].Value = pair.p1.IterationCount;
                    ws[$"C{row}"].Value = pair.p2.Name;
                    ws[$"D{row}"].Value = pair.p1.Name;

                    stopwatch.Reset();
                    stopwatch.Start();

                    var result = PlayGame(game, pair.p1, pair.p2);

                    stopwatch.Stop();

                    ws[$"E{row}"].Value = stopwatch.ElapsedMilliseconds / 1000.0;
                    ws[$"F{row}"].Value = result;

                    row++;

                    Console.WriteLine($"Verifying hypothesis no. 2: pair no. {playersPairs.IndexOf(pair) + 1} part 1/2 {i + 1}/{repeat}");

                    game = GomokuGame.CreateGomokuGame();

                    ws[$"A{row}"].Value = pair.p1.Name;
                    ws[$"B{row}"].Value = pair.p1.IterationCount;
                    ws[$"C{row}"].Value = pair.p2.Name;
                    ws[$"D{row}"].Value = pair.p2.Name;

                    stopwatch.Reset();
                    stopwatch.Start();

                    result = PlayGame(game, pair.p2, pair.p1);

                    stopwatch.Stop();

                    ws[$"E{row}"].Value = stopwatch.ElapsedMilliseconds / 1000.0;
                    ws[$"F{row}"].Value = result;

                    row++;

                    Console.WriteLine($"Verifying hypothesis no. 2: pair no. {playersPairs.IndexOf(pair) + 1} part 2/2 {i + 1}/{repeat}");
                }
            }
        }

        private static void VerifyHypothesis3(WorkSheet ws)
        {
            var repeat = 3;

            List<(MCTSEngine<GomokuLib.Action> p1, MCTSEngine<GomokuLib.Action> p2)> playersPairs = new()
            {
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 500 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1000 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 500 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1250 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 750 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1500 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 750 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1750 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1000 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 2000 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1000 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 2250 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1250 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 2500 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1250 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 2750 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1500 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 3000 }),
                (new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 1500 }, new ClassicMCTSEngine<GomokuLib.Action>() { IterationCount = 3250 })
            };

            var row = 1;

            ws[$"A{row}"].Value = "PLAYER-1";
            ws[$"A{row}"].Style.Font.Bold = true;
            ws[$"B{row}"].Value = "PLAYER-1 ITERATIONS";
            ws[$"B{row}"].Style.Font.Bold = true;
            ws[$"C{row}"].Value = "PLAYER-2";
            ws[$"c{row}"].Style.Font.Bold = true;
            ws[$"D{row}"].Value = "PLAYER-2 ITERATIONS";
            ws[$"D{row}"].Style.Font.Bold = true;
            ws[$"E{row}"].Value = "TIME";
            ws[$"E{row}"].Style.Font.Bold = true;
            ws[$"F{row}"].Value = "WINNER";
            ws[$"F{row}"].Style.Font.Bold = true;

            row++;

            var stopwatch = new Stopwatch();

            foreach (var pair in playersPairs)
            {
                for (int i = 0; i < repeat; i++)
                {
                    var game = GomokuGame.CreateGomokuGame();

                    ws[$"A{row}"].Value = pair.p1.Name;
                    ws[$"B{row}"].Value = pair.p1.IterationCount;
                    ws[$"C{row}"].Value = pair.p2.Name;
                    ws[$"D{row}"].Value = pair.p2.IterationCount;

                    stopwatch.Reset();
                    stopwatch.Start();

                    var result = PlayGame(game, pair.p1, pair.p2);

                    stopwatch.Stop();

                    ws[$"E{row}"].Value = stopwatch.ElapsedMilliseconds / 1000.0;
                    ws[$"F{row}"].Value = result;

                    row++;

                    Console.WriteLine($"Verifying hypothesis no. 3: pair no. {playersPairs.IndexOf(pair) + 1} {i + 1}/{repeat}");
                }
            }
        }

        private static string PlayGame(GomokuGame game,
            IEngine<GomokuLib.Action> player1, IEngine<GomokuLib.Action> player2)
        {
            var moveCount = 0;
            var actionsExecuted = new List<GomokuLib.Action>();

            Color? winner;

            while (true)
            {
                var currentEngine = ((++moveCount % 2) == 1) ? player1 : player2;

                var action = currentEngine.CalculateFromExecutedActions(game, actionsExecuted);
                game.ExecuteAction(action);

                winner = game.GetWinner();
                if (winner is not null || game.IsDraw())
                {
                    break;
                }
            }

            return winner is null ? "DRAW" : (winner.Value == Color.Red ? $"{player1.Name} (1)" : $"{player2.Name} (2)");
        }
    }

    public static class Results
    {
        public static string Directory { get; } = "./../../../../Results";
        public static string FileName { get; } = "results";
        public static string FileDateFormat { get; } = "yyyy-MM-dd-HHmmss";
        public static string FileExtension { get; } = "xlsx";
        public static string WorksheetHypothesis1 { get; } = "Hypothesis-1";
        public static string WorksheetHypothesis2 { get; } = "Hypothesis-2";
        public static string WorksheetHypothesis3 { get; } = "Hypothesis-3";
    }
}