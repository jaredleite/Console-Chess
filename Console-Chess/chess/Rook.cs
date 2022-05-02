using board;

namespace chess
{
    internal class Rook : Piece
    {
        public Rook(Color color, Board board)
            : base(color, board)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        public bool CanMove(Position pos)
        {
            Piece piece = Board.Piece(pos);
            return piece == null || piece.Color != Color;
        }

        public override bool[,] ValidMoves()
        {
            bool[,] mat = new bool[Board.Rows, Board.Columns];
            Position pos = new Position(0, 0);

            //above
            pos.SetValues(this.Position.Row - 1, this.Position.Column);
            while (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Row -= 1;
            }

            //below
            pos.SetValues(this.Position.Row + 1, this.Position.Column);
            while (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Row += 1;
            }

            //right
            pos.SetValues(this.Position.Row, this.Position.Column + 1);
            while (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Column += 1;
            }

            //left
            pos.SetValues(this.Position.Row, this.Position.Column - 1);
            while (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
                if (Board.Piece(pos) != null && Board.Piece(pos).Color != Color)
                {
                    break;
                }
                pos.Column -= 1;
            }

            return mat;
        }
    }
}
