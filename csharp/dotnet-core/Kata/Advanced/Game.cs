using System.Collections.Generic;
using Kata.Entities;

namespace Kata.Advanced
{
    public class Game : EntityBase
    {
        private int Bonus { get; set; }

        private List<Frame> _frames;

        private int _score;
        
        private int TotalFrames { get; set; }

        public Game(int numberOfFrames = 10)
        {
            _score = 0;
            TotalFrames = numberOfFrames;
        }
        
    }
}