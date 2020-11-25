using System.Collections.Generic;

namespace Kata.Entities.Services.Contracts
{
    public interface IScoreService
    {
        int GetScore(IList<Frame> frames);
    }
}