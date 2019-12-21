
namespace ChessGame
{
    using ChessGame.Board;
    using ChessGame.Chess;
    using ChessGame.UI;
    using System;
    using ChessGame.Board;

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessGame chessGame = new ChessGame();


                Screen.PrintBoard(chessGame.GameBoard);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
