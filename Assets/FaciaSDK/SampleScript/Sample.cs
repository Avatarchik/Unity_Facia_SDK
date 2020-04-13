using UnityEngine;
using UnityEngine.UI;

namespace nmxi.facia.receiver.sample
{
    public class Sample : MonoBehaviour
    {
        [SerializeField] private Text _targetText;

        public void UpdateText(string s)
        {
            _targetText.text = s;
        }
    }
}