using ChessMoves;
using ChessMVC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace Tests {
    [TestClass]
    public class Tests_Chess {
        [TestMethod]
        public void Test_001() {
            // Model
            // View
            // Controller

            //var moves = new List<string>();

            //var game = new Chess();
            //var board = new Board();
            //var printer = new BoardPrinter();

            //foreach (var move in moves) {
            //    game.Apply(move, board);

            //    printer.Show(board);
            //}
        }

        [TestMethod]
        public void Test_002() {
            // Model
            // View
            // Controller

            var moves = new List<string>() {
             // White, Black
                "G1F3", "G8F6",
                "C2C4", "G7G6",
                "B1C3", "F8G7",
                "D1D4", "E8G8",
                "C1C4", "D7D5",
                "D1B3", "D5C4",
                "B3C4",
            };


            var game = new Chess();
            var board = new Board();
            var printer = new BoardPrinter();

            //board.Move += (move) => Debug.WriteLine("");

            //game.Result += (result) => Debug.WriteLine("");
            //game.Capture += (piece, position) => Debug.WriteLine("");


            foreach (var move in moves) {
                game.Apply(move, board);

                printer.Show(board);
            }
        }

        [TestMethod]
        public void Test_003() {
            var moves = new List<string>() {
             // White, Black
                "G1F3", "G8F6",
                "C2C4", "G7G6",
                "B1C3", "F8G7",
                "D1D4", "E8G8",
                "C1C4", "D7D5",
                "D1B3", "D5C4",
                "B3C4",
            };

            ChessMove result = null;

            var gameMoves = new List<ChessMove>();

            foreach (var move in moves) {
                if (ChessMove.Try(move, ref result)) {


                    gameMoves.Add(result);
                }
                else {
                    break;
                }
            }
        }

        private class BoardPrinter {
            internal void Show(Board board) {
                for (int c = 1; c <= 8; c++) {
                    for (int r = 1; r <= 8; r++) {
                        Debug.Write($"[{board[c, r]?.ToString() ?? " "}]");
                    }
                    Debug.WriteLine(string.Empty);
                }
                Debug.WriteLine(string.Empty.PadRight(8 * 3, '-'));
            }
        }
    }
}
