namespace board
{
    internal class Board
    {
        public int rows { get; set; }
        public int columns { get; set; }

        private Piece[,] _Pieces;

        public Board()
        {
        }

        public Board(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            _Pieces = new Piece[rows, columns];
        }
    }
}
