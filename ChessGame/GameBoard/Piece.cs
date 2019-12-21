using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Board
{
    public abstract class Piece
    {
        public Piece(GameBoard board, Color color)
        {
            Board = board;
            Color = color;
            Position = null;
            NumberOfMoves = 0;
        }

        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumberOfMoves { get; protected set; }
        public GameBoard Board { get; protected set; }

        public void IncreaseNumberOfMoves()
        {
            NumberOfMoves++;
        }

        public abstract bool[,] PossibleMoves();
    }
}
