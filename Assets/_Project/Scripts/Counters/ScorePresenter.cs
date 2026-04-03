using Assets._Project.Scripts.UI.Score;
using System;

namespace Assets._Project.Scripts.Counters
{
    public class ScorePresenter
    {
        IView _view;
        IScoreCounter _counter;

        public ScorePresenter(
            IView view,
            IScoreCounter counter)
        {
            _view = view;
            _counter = counter;
        }

        public void Enable() => 
            _counter.ScoreChanged += OnChanged;

        public void Disable() => 
            _counter.ScoreChanged -= OnChanged;

        private void OnChanged(int amount) => 
            _view.UpdateDisplay(amount);
    }
}