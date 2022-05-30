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
                    try
                    {
                        Console.Clear();
                        Screen.PrintingBoard(chessMatch.Board);
                        Console.WriteLine();
                        Console.WriteLine("Turn # " + chessMatch.Turn);
                        Console.WriteLine("Waiting for " + chessMatch.PlayerTurn + " Player");

                        Console.Write("Origin: ");
                        Position origin = Screen.ReadChessPosition().ToPosition();
                        chessMatch.CheckOrginPosition(origin);


                        bool[,] validMoves = chessMatch.Board.Piece(origin).ValidMoves();
                        Console.Clear();
                        Screen.PrintingBoard(chessMatch.Board, validMoves);
                        Console.WriteLine();


                        Console.Write("Destiny: ");
                        Position destiny = Screen.ReadChessPosition().ToPosition();
                        chessMatch.CheckDestinyPosition(origin, destiny);

                        chessMatch.MakeMove(origin, destiny);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }


            }
            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
