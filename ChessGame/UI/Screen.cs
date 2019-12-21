
namespace ChessGame.UI
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ChessGame.Board;
    using ChessGame.Chess;

    class Screen
    {
        public static void PrintBoard(GameBoard board)
        {

            for (int row = 0; row < board.NumberOfRows; row++)
            {
                Console.Write(board.NumberOfRows - row + " ");
                for (int column = 0; column < board.NumberOfColumns; column++)
                {
                    PrintPiece(board.Piece(row, column));
                }

                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintBoard(GameBoard board, bool[,] possiblePositions)
        {
            ConsoleColor backgroundOriginal = Console.BackgroundColor;
            ConsoleColor backgroundNew = ConsoleColor.DarkGray;

            for (int row = 0; row < board.NumberOfRows; row++)
            {
                Console.Write(board.NumberOfRows - row + " ");
                for (int column = 0; column < board.NumberOfColumns; column++)
                {
                    if (possiblePositions[row, column])
                    {
                        Console.BackgroundColor = backgroundNew;
                    }
                    else
                    {
                        Console.BackgroundColor = backgroundOriginal;
                    }
                    PrintPiece(board.Piece(row, column));
                    Console.BackgroundColor = backgroundOriginal;
                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = backgroundOriginal;
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
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor originalColor = Console.ForegroundColor;

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.Write(piece);
                    Console.ForegroundColor = originalColor;
                }
                Console.Write(" ");
            }
        }

        public static PositionChess ReadPositionChess()
        {
            string moveCommand = Console.ReadLine();

            char moveColumn = moveCommand[0];
            int moveRow = int.Parse(moveCommand[1].ToString());

            return new PositionChess(moveColumn, moveRow);
        }
    }
}
