using System;


namespace TicTacToeTDD
{
    internal class Game
    {
        public Game()
        {

        }

        public double MovesCounter { get; private set; }

        public void MakeMove(int index)
        {
            if (index < 1 || index > 9)
                throw new ArgumentOutOfRangeException();
            MovesCounter++;
        }
    }
}