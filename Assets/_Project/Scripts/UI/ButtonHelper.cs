using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts.UI
{
    public abstract class ButtonHelper : MonoBehaviour
    {
        [SerializeField] protected Button Button;

        public event Action Clicked;

        private void OnEnable() => 
            Button.onClick.AddListener(OnClicked);

        private void OnDisable() => 
            Button.onClick.RemoveListener(OnClicked);

        protected virtual void OnClicked() => 
            Clicked?.Invoke();
    }
}