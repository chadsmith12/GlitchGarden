using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Gameplay
{
    public class StarDisplay : MonoBehaviour
    {
        [SerializeField] private int _stars = 1000;
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

        /// <summary>
        /// Check to see if we have enough stars.
        /// </summary>
        /// <param name="amount">Amount of stars we need to have.</param>
        /// <returns>True if we have enough stars, otherwise; false.</returns>
        public bool HasEnoughStars(int amount)
        {
            return _stars >= amount;
        }

        private void UpdateResourceDisplay()
        {
            _resourceText.text = _stars.ToString();
        }
    }
}

