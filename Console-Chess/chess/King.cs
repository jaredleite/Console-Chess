using board;

namespace chess
{
    internal class King : Piece
    {
        public King(Color color, Board board)
            : base(color, board)
        {
        }

        public override string ToString()
        {
            return "K";
        }

        public bool CanMove(Position pos)
        {
            Piece piece = Board.Piece(pos);
            return piece == null || piece.Color != Color;
        }

        public override bool[,] ValidMoves()
        {
            bool[,] mat = new bool[Board.Rows, Board.Columns];
            Position pos = new Position(0,0);

            //above
            pos.SetValues(this.Position.Row - 1, this.Position.Column);
            if(Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //below
            pos.SetValues(this.Position.Row + 1, this.Position.Column);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //right
            pos.SetValues(this.Position.Row, this.Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //left
            pos.SetValues(this.Position.Row, this.Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //NE
            pos.SetValues(this.Position.Row - 1, this.Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //NW
            pos.SetValues(this.Position.Row - 1, this.Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //SE
            pos.SetValues(this.Position.Row + 1, this.Position.Column + 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            //SW
            pos.SetValues(this.Position.Row + 1, this.Position.Column - 1);
            if (Board.ValidPosition(pos) && CanMove(pos))
            {
                mat[pos.Row, pos.Column] = true;
            }

            return mat;
        }
    }
}
