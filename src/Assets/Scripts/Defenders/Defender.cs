using UnityEngine;
using Assets.Scripts.Gameplay;

namespace Assets.Scripts.Defefenders
{
    public class Defender : MonoBehaviour
    {
        private StarDisplay _starDisplay;
        [SerializeField] private int _starCost = 100;

        private void Start()
        {
            _starDisplay = FindObjectOfType<StarDisplay>();
        }

        /// <summary>
        /// Adds the number of stars this defender generated to the star display.
        /// </summary>
        /// <param name="amount">The number of stars that were generated.</param>
        public void AddStars(int amount)
        {
            _starDisplay.AddStars(amount);
        }
    }
}
