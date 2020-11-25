using System.Collections.Generic;
using Kata.Entities.Services.Contracts;

namespace Kata.Entities
{
    public class Game
    {
        public List<Frame> Frames { get; set; }

        private readonly IScoreService _scoreService;

        private readonly int _totalFrames;

        private int _currentFrame;

        public Game(int numberOfFrames, IScoreService scoreService)
        {
            _totalFrames = numberOfFrames;

            _scoreService = scoreService;

            InitializeFrames();
        }

        public int GetScore()
        {
            return _scoreService.GetScore(Frames);
        }

        private void InitializeFrames()
        {
            Frames = new List<Frame>();

            for (var i = 0; i < _totalFrames; i++)
            {
                Frames.Add(new Frame());
            }
        }

        public void Roll(int pins)
        {
            var current = Frames[_currentFrame];

            current.Pins = pins;

            if (current.RollNumber == current.TotalRolls)
                _currentFrame++;
        }
    }
}