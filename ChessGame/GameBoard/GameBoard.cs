namespace ChessGame.Board
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GameBoard
    {
        public GameBoard(int numberOfRows, int numberOfColumns)
        {
            NumberOfRows = numberOfRows;
            NumberOfColumns = numberOfColumns;
            piecesOnBoard = new Piece[numberOfRows, numberOfColumns];
        }

        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        private Piece[,] piecesOnBoard;

        public Piece Piece(int row, int column)
        {
            return piecesOnBoard[row, column];
        }

        public Piece Piece(Position position)
        {
            return piecesOnBoard[position.Row, position.Column];
        }

        public void PutPiece(Piece piece, Position position)
        {
            if (PositionHasPiece(position))
            {
                throw new GameBoardException("There is already a piece in that position");
            }

            piecesOnBoard[position.Row, position.Column] = piece;
            piece.Position = position;
        }

        public Piece RemovePiece(Position position)
        {
            if (Piece(position) == null)
            {
                return null;
            }
            else
            {
                Piece piece = Piece(position);

                piece.Position = null;
                piecesOnBoard[position.Row, position.Column] = null;

                return piece;
            }
        }

        public bool PositionHasPiece(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public void ValidatePosition(Position position)
        {
            if (!IsPositionValid(position))
            {
                throw new GameBoardException("Invalid Position");
            }
        }

        public bool IsPositionValid(Position position)
        {
            if (position.Row < 0 || position.Column < 0 || position.Row >= NumberOfRows || position.Column >= NumberOfColumns)
            {
                return false;
            }
            return true;
        }
    }
}
