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
    }
}
