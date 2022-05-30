namespace board
{
    abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumMoviments { get; protected set; }
        public Board Board {get; protected set; }


        public Piece()
        {
        }
        
        public Piece(Color color, Board board)
        {
            Position = null;
            Color = color;
            Board = board;
            NumMoviments = 0;
        }

        public void IncrementNumMoviments()
        {
            NumMoviments++;
        }

        public abstract bool[,] ValidMoves();

        public bool ExistValidMoves()
        {
            //int numValidMoves = 0;
            bool[,] mat = ValidMoves();
            for(int j = 0; j < Board.Columns; j++)
            {
                for(int i = 0; i < Board.Rows; i++)
                {
                    if(mat[i, j])
                    {
                        return true;
                        //numValidMoves++;
                    }
                }
            }
            return false;
            //return numValidMoves > 0;
        }

        public bool CanMoveTo (Position pos)
        {
            return ValidMoves()[pos.Row, pos.Column];
        }
    }
}
