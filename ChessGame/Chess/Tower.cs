using ChessGame.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Chess
{
    public class Tower : Piece
    {
        public Tower(GameBoard board, Color color) : base(board, color)
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

            //Setting possible moves to the Tower
            #region

            //Top
            position.SetAllowedMoves(position.Row - 1, position.Column);
            while (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;

                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }

                position.Row = position.Row - 1;
            }



            //Bottom
            position.SetAllowedMoves(position.Row + 1, position.Column);
            while (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;

                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }

                position.Row = position.Row + 1;
            }



            //Right
            position.SetAllowedMoves(position.Row, position.Column + 1);
            while (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;

                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }

                position.Column = position.Column+ 1;
            }


            //Left
            position.SetAllowedMoves(position.Row, position.Column - 1);
            while (Board.IsPositionValid(position) && CanMove(position))
            {
                possibleDestinations[position.Row, position.Column] = true;

                if (Board.Piece(position) != null && Board.Piece(position).Color != Color)
                {
                    break;
                }

                position.Column = position.Column - 1;
            }


            #endregion

            return possibleDestinations;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
