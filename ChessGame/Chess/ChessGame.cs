using ChessGame.Board;
using System;

namespace ChessGame.Chess
{
    public class ChessGame
    {
        public ChessGame()
        {
            GameBoard = new GameBoard(8, 8);
            Turn = 1;
            PlayerTurn = Color.White;
            PutPieces();
            HasGameFinished = false;
        }

        public GameBoard GameBoard { get; set; }
        private int Turn;
        private Color PlayerTurn;
        public bool HasGameFinished { get; private set; }

        public void MovePiece(Position origin, Position destination)
        {
            Piece piece = GameBoard.RemovePiece(origin);

            piece.IncreaseNumberOfMoves();

            Piece pieceKilled = GameBoard.RemovePiece(destination);

            GameBoard.PutPiece(piece, destination);
        }

        private void PutPieces()
        {
            GameBoard.PutPiece(new Tower(GameBoard, Color.White), new PositionChess('c', 1).ToPosition());
            GameBoard.PutPiece(new Tower(GameBoard, Color.Black), new Position(1, 3));
            GameBoard.PutPiece(new King(GameBoard, Color.Black), new Position(0, 2));
            GameBoard.PutPiece(new Tower(GameBoard, Color.White), new Position(3, 5));
        }
    }
}
