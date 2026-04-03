using Assets._Project.Scripts.Counters;
using System;

namespace Assets._Project.Scripts.Counter
{
    public class ScoreCounter : IScoreCounter
    {
        private int _value;

        public event Action<int> ScoreChanged;

        public void Add()
        {
            _value++;
            ScoreChanged?.Invoke(_value);
        }

        public void ResetScore()
        {
            _value = 0;
        }
    }
}