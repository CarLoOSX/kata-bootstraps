using System.Collections.Generic;
using Kata.Entities.Services.Contracts;

namespace Kata.Entities.Services
{
    public class ScoreService : IScoreService
    {
        private int _score;

        private IList<Frame> _frames;

        public int GetScore(IList<Frame> frameList)
        {
            _frames = frameList;

            foreach (var frame in _frames)
            {
                CalculateStrikeScore(frame);
            }

            return _score;
        }

        private void CalculateStrikeScore(Frame frame)
        {
            var index = _frames.IndexOf(frame);

            if (frame.Strike)
            {
                _score += frame.Pins + _frames[index + 1].Pins;

                if (_frames[index + 1].Strike)
                {
                    CalculateStrikeScore(frame);
                }
            }

            if (frame.Spare)
            {
                _score += frame.Pins + _frames[index + 1].Score[0];
            }

            _score += frame.Pins;
        }
    }
}