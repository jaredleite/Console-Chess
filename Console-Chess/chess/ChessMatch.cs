using System;
using board;

namespace chess
{
    internal class ChessMatch
    {
        public Board Board { get; private set; }
        private int Turn { get; set; }
        public Color PlayerTurn { get; set; }
        public bool GameOver { get; private set; }

        public ChessMatch()
        {
            Board = new Board(8, 8);
            Turn = 1;
            GameOver = false;
            PlayerTurn = Color.White;
            PlacePiece();
        }

        public void ExecuteMove(Position posFrom, Position posTo)
        {
            Piece piece = Board.RemovePiece(posFrom);
            piece.IncrementNumMoviments();
            Piece capturedPiece =  Board.RemovePiece(posTo);
            Board.PlacePiece(piece, posTo);

        }

        public void PlacePiece()
        {
            Board.PlacePiece(new Rook(Color.White, Board), new ChessPosition('c', 1).ToPosition());
            Board.PlacePiece(new Rook(Color.White, Board), new ChessPosition('c', 2).ToPosition());
            Board.PlacePiece(new King(Color.White, Board), new ChessPosition('d', 1).ToPosition());
            Board.PlacePiece(new Rook(Color.White, Board), new ChessPosition('d', 2).ToPosition());
            Board.PlacePiece(new Rook(Color.White, Board), new ChessPosition('e', 1).ToPosition());
            Board.PlacePiece(new Rook(Color.White, Board), new ChessPosition('e', 2).ToPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new ChessPosition('c', 8).ToPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new ChessPosition('c', 7).ToPosition());
            Board.PlacePiece(new King(Color.Black, Board), new ChessPosition('d', 8).ToPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new ChessPosition('d', 7).ToPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new ChessPosition('e', 8).ToPosition());
            Board.PlacePiece(new Rook(Color.Black, Board), new ChessPosition('e', 7).ToPosition());

        }
    }
}
