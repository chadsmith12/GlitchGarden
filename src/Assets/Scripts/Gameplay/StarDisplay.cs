using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Gameplay
{
    public class StarDisplay : MonoBehaviour
    {
        [SerializeField] private int _stars = 100;
        private Text _resourceText;

        // Use this for initialization
        void Start()
        {
            _resourceText = GetComponent<Text>();
            UpdateResourceDisplay();
        }

        /// <summary>
        /// Adds the number of stars passed in to the total stars count.
        /// </summary>
        /// <param name="numberStars">number of stars to add to the total stars.</param>
        public void AddStars(int numberStars)
        {
            _stars += numberStars;
            UpdateResourceDisplay();
        }

        /// <summary>
        /// Removes the numer of stars passed in from numerStars.
        /// </summary>
        /// <param name="numberSars">number of stars to remove from the total server.</param>
        public void SpendStars(int numberStars)
        {
            if(_stars >= numberStars)
            {
                _stars -= numberStars;
                UpdateResourceDisplay();
            }
        }

        private void UpdateResourceDisplay()
        {
            _resourceText.text = _stars.ToString();
        }
    }
}

