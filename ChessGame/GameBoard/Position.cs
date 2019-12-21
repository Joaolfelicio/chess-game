using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Board
{
    public class Position
    {
        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public int Row { get; set; }
        public int Column { get; set; }

        public override string ToString()
        {
            return $"{Column}, {Row}";
        }

        public void SetAllowedMoves(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
