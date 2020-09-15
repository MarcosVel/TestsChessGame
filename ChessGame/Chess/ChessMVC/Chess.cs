using System;

namespace ChessMVC {
    public class Chess {
        public void Apply(string move, Board board) {
            var start = move.Substring(0, 2);
            var dest = move.Substring(2, 2);

            board[dest[0] - 64, dest[1] - 48] = board[start[0] - 64, start[1] - 48];
            board[start[0] - 64, start[1] - 48] = null;
        }
    }
}
