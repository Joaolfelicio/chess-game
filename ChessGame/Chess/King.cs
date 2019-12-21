using ChessGame.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Chess
{
    public class King : Piece
    {

        public King(GameBoard board, Color color) : base(board, color)
        {

        }

        public bool CanMove(Position destination)
        {
            Piece piece = Board.Piece(destination);

            return piece == null || piece.Color != Color;
        }

        public override bool[,] PossibleMoves()
        {
            bool[,] possibleDestinations = new bool[Board.NumberOfRows, Board.NumberOfColumns];

            Position position = new Position(0, 0);

            //Setting possible moves to the King
            #region

            //Top
            position.SetAllowedMoves(position.Row - 1, position.Column);
            if(Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;
            }

            //NE
            position.SetAllowedMoves(position.Row - 1, position.Column + 1);
            if (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;
            }

            //Right
            position.SetAllowedMoves(position.Row, position.Column + 1);
            if (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;
            }

            //SE
            position.SetAllowedMoves(position.Row + 1, position.Column + 1);
            if (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;
            }

            //Bottom
            position.SetAllowedMoves(position.Row + 1, position.Column);
            if (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;
            }

            //SO
            position.SetAllowedMoves(position.Row + 1, position.Column - 1);
            if (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;
            }

            //Left
            position.SetAllowedMoves(position.Row, position.Column - 1);
            if (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;
            }

            //NO
            position.SetAllowedMoves(position.Row - 1, position.Column - 1);
            if (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;
            }

            #endregion

            return possibleDestinations;
        }

        public override string ToString()
        {
            return "K";
        }
    }
}
