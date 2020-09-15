using System.Dynamic;

namespace ChessMVC {
    public class Board {
        private ChessPiece[,] board = new ChessPiece[8, 8] {
            { new Rook(Player.White)  , new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Rook(Player.Black)  },
            { new Knight(Player.White), new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Knight(Player.Black)},
            { new Bishop(Player.White), new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Bishop(Player.Black)},
            { new Queen(Player.White) , new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Queen(Player.Black) },
            { new King(Player.White)  , new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new King(Player.Black)  },
            { new Bishop(Player.White), new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Bishop(Player.Black)  },
            { new Knight(Player.White), new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Knight(Player.Black)},
            { new Rook(Player.White)  , new Pawn(Player.White), null, null, null, null, new Pawn(Player.Black), new Rook(Player.Black)}
        };
        public ChessPiece this[int col, int row]
        {
            get
            {
                return board[col-1, row-1];
            } 
            set
            {
                board[col-1, row-1] = value;
            }
        }
    }
}