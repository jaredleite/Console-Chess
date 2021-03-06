namespace board
{
    internal class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        private Piece[,] _Pieces;

        public Board()
        {
        }

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            _Pieces = new Piece[rows, columns];
        }

        public Piece Piece(int row, int column)
        {
            return _Pieces[row, column];
        }

        public Piece Piece(Position pos)
        {
            return _Pieces[pos.Row, pos.Column];
        }


        public void PlacePiece(Piece piece,Position pos)
        {
            if (ExistPiece(pos))
            {
                throw new BoardException("Already exists a piece in this position!");
            }
            _Pieces[pos.Row, pos.Column] = piece;
            piece.Position = pos;
        }

        public Piece RemovePiece(Position pos)
        {
            if(Piece(pos) == null)
            {
                return null;
            }
            Piece aux = Piece(pos);
            aux.Position = null;
            _Pieces[pos.Row, pos.Column] = null;
            return aux;
        }

        public bool ExistPiece(Position pos)
        {
            ValidingPosition(pos);
            return Piece(pos) != null;
        }

        public bool ValidPosition(Position pos)
        {
            return pos.Row >=0 && pos.Column >=0 &&
                pos.Row < Rows && pos.Column < Columns;
        }

        public void ValidingPosition(Position pos)
        {
            if (! ValidPosition(pos)){
                throw new BoardException("Invalid position!");
            }
        }
    }
}
