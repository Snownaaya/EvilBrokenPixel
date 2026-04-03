using System;

namespace Assets._Project.Scripts.Counters
{
    public interface IScoreCounter
    {
        public event Action<int> ScoreChanged;

        public void Add();

        public void ResetScore();
    }
}