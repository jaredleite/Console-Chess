using System;
using board;

namespace Console_Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8,8);
            Screen.PrintingBoard(board);
        }
    }
}
