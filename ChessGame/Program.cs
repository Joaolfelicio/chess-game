
namespace ChessGame
{
    using ChessGame.Board;
    using ChessGame.Chess;
    using ChessGame.UI;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame chessGame = new ChessGame();

                while (!chessGame.HasGameFinished)
                {
                    Console.Clear();
                    Screen.PrintBoard(chessGame.GameBoard);


                    Console.WriteLine("Origin position:");
                    Position origin = Screen.ReadPositionChess().ToPosition();

                    var possiblePositions = chessGame.GameBoard.Piece(origin);
                    var test = possiblePositions.PossibleMoves();


                    Console.Clear();
                    Screen.PrintBoard(chessGame.GameBoard, test);

                    Console.WriteLine();
                    Console.WriteLine("Destination position:");
                    Position destination = Screen.ReadPositionChess().ToPosition();

                    chessGame.MovePiece(origin, destination);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
