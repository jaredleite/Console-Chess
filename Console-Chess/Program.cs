using System;
using board;
using chess;

namespace Console_Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ChessMatch chessMatch = new ChessMatch();

                while (!chessMatch.GameOver)
                {
                    Console.Clear();
                    Screen.PrintingBoard(chessMatch.Board);
                    Console.WriteLine();
                    Console.Write("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();


                    bool[,] validMoves = chessMatch.Board.Piece(origin).ValidMoves();
                    Console.Clear();
                    Screen.PrintingBoard(chessMatch.Board, validMoves);
                    Console.WriteLine();
                    Console.Write("Destiny: ");
                    Position destiny = Screen.ReadChessPosition().ToPosition();

                    chessMatch.ExecuteMove(origin, destiny);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
