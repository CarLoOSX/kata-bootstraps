using System;
using Kata.Entities.Services;

namespace Kata.Entities
{
    public class Player
    {
        private readonly Game _game;

        public Player()
        {
            _game = new Game(10, new ScoreService());
        }

        private void Bowl()
        {
            for (var i = 0; i < _game.Frames.Count; i++)
            {
                var random = new Random(10).Next();
                _game.Roll(random);
            }
            Console.WriteLine(GetScore());
        }

        private int GetScore()
        {
            return _game.GetScore();
        }
    }
}