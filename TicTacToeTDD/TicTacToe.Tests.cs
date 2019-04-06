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
    }
}
