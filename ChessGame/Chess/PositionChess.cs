using ChessGame.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Chess
{
    public class PositionChess
    {

        public PositionChess(char column, int row)
        {
            Column = column;
            Row = row;
        }

        public char Column { get; set; }
        public int Row { get; set; }

        public Position ToPosition()
        {
            return new Position(8 - Row, Column - 'a');
        }

        public override string ToString()
        {
            return "" + Column + Row;
        }
    }
}
