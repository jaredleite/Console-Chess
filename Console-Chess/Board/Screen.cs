using System;
using board;
using chess;

namespace board
{
    internal class Screen
    {
        public static void PrintingBoard(Board board)
        {
            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write($"{board.Rows - i} ");

                for (int j = 0; j < board.Columns; j++)
                {
                    Screen.PrintPiece(board.Piece(i, j));

                }
                Console.WriteLine();
            }
            Console.Write("  ");
            for (int j = 0; j < board.Columns; j++)
            {
                Console.Write($"{(char)('a' + j)} ");
            }
            Console.WriteLine();
        }

        public static void PrintingBoard(Board board, bool[,] validMoves)
        {
            ConsoleColor _originalBackgroud = Console.BackgroundColor;
            ConsoleColor _newBackgroud = ConsoleColor.Green;

            for (int i = 0; i < board.Rows; i++)
            {
                Console.Write($"{board.Rows - i} ");

                for (int j = 0; j < board.Columns; j++)
                {

                    if (validMoves[i, j])
                    {
                        Console.BackgroundColor = _newBackgroud;
                    }
                    else
                    {
                        Console.BackgroundColor = _originalBackgroud;
                    }
                    Screen.PrintPiece(board.Piece(i, j));
                    Console.BackgroundColor = _originalBackgroud;

                }
                Console.WriteLine();
            }
            Console.Write("  ");
            for (int j = 0; j < board.Columns; j++)
            {
                Console.Write($"{(char)('a' + j)} ");
            }
            Console.WriteLine();

        }

        public static void PrintPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("- ");
            }
            else
            {

                if (piece.Color == Color.White)
                {
                    ConsoleColor _aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = _aux;
                }
                else
                {
                    ConsoleColor _aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(piece);
                    Console.ForegroundColor = _aux;
                }
                Console.Write(" ");
            }
        }

        public static ChessPosition ReadChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
        }
    }
}
