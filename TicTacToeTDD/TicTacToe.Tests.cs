using NUnit.Framework;
using System;

namespace TicTacToeTDD
{
    [TestFixture]
    public class TicTacToeTests
    {
        [Test]
        public void CreateGame_ZeroMoves()
        {
            var game = new Game();
            Assert.AreEqual(0, game.MovesCounter);
        }

        [Test]
        public void MakeMove_CounterShifts()
        {
            var game = new Game();
            game.MakeMove(1);
            Assert.AreEqual(1, game.MovesCounter);
        }
        [Test]
        public void MakeInvalidMove_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var game = new Game();
                game.MakeMove(0);
            });
        }
        [Test]
        public void MoveOnTheSameSquare_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var game = new Game();
                game.MakeMove(1);
                game.MakeMove(1);
            });
        }

        [Test]
        public void MakingMoves_SetStateCorrectly()
        {
            var game = new Game();
            MakeMoves(new int[] { 1, 2, 3, 4 }, game);

            Assert.AreEqual(State.Cross, game.GetState(1));
            Assert.AreEqual(State.Zero, game.GetState(2));
            Assert.AreEqual(State.Cross, game.GetState(3));
            Assert.AreEqual(State.Zero, game.GetState(4));
        }



        private void MakeMoves(int[] moves, Game game)
        {
            for (int i = 0; i < moves.Length; i++)
            {
                game.MakeMove(moves[i]);
            }
        }
    }
}
