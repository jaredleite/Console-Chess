using System;
using System.Collections.Generic;
using board;

namespace chess
{
    internal class ChessMatch
    {
        public Board Board { get; private set; }
        public int Turn { get; private set; }
        public Color PlayerTurn { get; private set; }
        public bool GameOver { get; private set; }
        private HashSet<Piece> Pieces;
        private HashSet<Piece> Captured;
        public ChessMatch()
        {
            Board = new Board(8, 8);
            Turn = 1;
            GameOver = false;
            PlayerTurn = Color.White;
            Pieces = new HashSet<Piece>();
            Captured = new HashSet<Piece>();
            PlacePiece();
        }

        public void CheckOrginPosition(Position pos)
        {
            if(Board.Piece(pos) == null)
            {
                throw new BoardException("There is not a piece in the selected position!");
            }
            if(PlayerTurn != Board.Piece(pos).Color)
            {
                throw new BoardException("Selected piece is not " + PlayerTurn + "!");
            }
            if (!Board.Piece(pos).ExistValidMoves())
            {
                throw new BoardException("Selected piece has not valid moves!");
            }
        }

        public void CheckDestinyPosition(Position origin, Position destiny)
        {
            if(!Board.Piece(origin).CanMoveTo(destiny))
            {
                throw new BoardException("Invalid destiny position!");
            }
        }

        public void ExecuteMove(Position posFrom, Position posTo)
        {
            Piece piece = Board.RemovePiece(posFrom);
            piece.IncrementNumMoviments();
            Piece capturedPiece = Board.RemovePiece(posTo);
            Board.PlacePiece(piece, posTo);
            if(capturedPiece != null)
            {
                Captured.Add(capturedPiece);
            }

        }

        public HashSet<Piece> CapturedPieces(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach(Piece x in Captured)
            {
                if(x.Color == color)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Piece> PiecesInGame(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece x in Pieces)
            {
                if (x.Color == color)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(CapturedPieces(color));
            return aux;
        }

        public void MakeMove(Position posFrom, Position posTo)
        {
            ExecuteMove(posFrom, posTo);
            Turn++;
            ChangePlayer();

            
        }


        private void ChangePlayer()
        {
            if (PlayerTurn == Color.White)
            {
                PlayerTurn = Color.Black;
            }
            else
            {
                PlayerTurn = Color.White;
            }
        }

        public void PlaceNewPiece(char col, int row, Piece piece)
        {
            Board.PlacePiece(piece, new ChessPosition(col, row).ToPosition());
            Pieces.Add(piece);
        }
        public void PlacePiece()
        {
            PlaceNewPiece('c', 1, new Rook(Color.White, Board));
            PlaceNewPiece('c', 2, new Rook(Color.White, Board));
            PlaceNewPiece('d', 1, new King(Color.White, Board));
            PlaceNewPiece('d', 2, new Rook(Color.White, Board));
            PlaceNewPiece('e', 1, new Rook(Color.White, Board));
            PlaceNewPiece('e', 2, new Rook(Color.White, Board));
            PlaceNewPiece('c', 8, new Rook(Color.Black, Board));
            PlaceNewPiece('c', 7, new Rook(Color.Black, Board));
            PlaceNewPiece('d', 8, new King(Color.Black, Board));
            PlaceNewPiece('d', 7, new Rook(Color.Black, Board));
            PlaceNewPiece('e', 8, new Rook(Color.Black, Board));
            PlaceNewPiece('e', 7, new Rook(Color.Black, Board));

        }
    }
}
