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
            MovesCounter++;
        }
    }
}