using UnityEngine;
using TMPro;

namespace Assets._Project.Scripts.UI.Score
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;

        public void UpdateDisplay(int amount) =>
            _text.text = amount.ToString();
    }
}