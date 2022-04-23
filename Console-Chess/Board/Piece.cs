namespace board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumMoviments { get; protected set; }
        public Board Board {get; protected set; }

        public Piece()
        {
        }
        
        public Piece(Position position, Color color, Board board)
        {
            Position = position;
            Color = color;
            Board = board;
            NumMoviments = 0;
        }
    }
}
