using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Board
{
    public class GameBoardException : Exception
    {
        public GameBoardException(string msg) : base(msg)
        {

        }
    }
}
