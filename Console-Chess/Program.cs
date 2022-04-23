using System;
using board;
using chess;

namespace Console_Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);
            
            board.PlacePiece(new Rook(Color.White,board),new Position(0,0));
            board.PlacePiece(new Rook(Color.White, board), new Position(5, 5));
            board.PlacePiece(new King(Color.White, board), new Position(3, 7));

            Screen.PrintingBoard(board);


        }
    }
}
