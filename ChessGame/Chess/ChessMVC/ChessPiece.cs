namespace ChessMVC {
    public enum Player {
        Black,
        White
    }
    public class ChessPiece {
        public Player Player { get; set; }
        public char Symbol { get; set; }

        public override string ToString() {
            return Symbol.ToString();
        }

        public ChessPiece(char symbol, Player player) {
            Symbol = symbol;
            Player = player;
        }
    }
    public class King : ChessPiece { public King(Player player) : base('K', player) { } }
    public class Queen : ChessPiece { public Queen(Player player) : base('Q', player) { } }
    public class Bishop : ChessPiece { public Bishop(Player player) : base('B', player) { } }
    public class Knight : ChessPiece { public Knight(Player player) : base('N', player) { } }
    public class Rook : ChessPiece { public Rook(Player player) : base('R', player) { } }
    public class Pawn : ChessPiece { public Pawn(Player player) : base('P', player) { } }    
}