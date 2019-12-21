
namespace ChessGame.UI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ChessGame.Board;

    class Screen
    {
        public static void PrintBoard(GameBoard board)
        {

            for (int row = 0; row < board.NumberOfRows; row++)
            {
                Console.Write(board.NumberOfRows - row + " ");
                for (int column = 0; column < board.NumberOfColumns; column++)
                {
                    if (board.Piece(row, column) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(board.Piece(row, column));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor originalColor = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write(piece);
                Console.ForegroundColor = originalColor;
            }
        }
    }
}
