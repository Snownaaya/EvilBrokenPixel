using Assets._Project.Scripts.Counters;
using UnityEngine;
using VContainer;

namespace Assets._Project.Scripts.Bootstrap.cs
{
    public class GameInitialize : MonoBehaviour
    {
        private ScorePresenter _scorePresenter;  

        [Inject]
        private void Construct(ScorePresenter scorePresenter)
        {
            _scorePresenter = scorePresenter;
        }

        private void OnEnable()
        {
            _scorePresenter?.Enable();
        }

        private void OnDisable()
        {
            _scorePresenter?.Disable();
        }
    }
}