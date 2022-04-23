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

            ChessPosition chessPosition = new ChessPosition('a', 8);
            Console.WriteLine(chessPosition.ToPosition());
            Console.WriteLine(chessPosition.ToString());
        }
    }
}
