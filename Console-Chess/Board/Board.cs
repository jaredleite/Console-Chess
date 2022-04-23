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


    }
}
