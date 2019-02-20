using UnityEngine;

namespace Assets.Scripts.UI
{
    public class DefenderButton : MonoBehaviour
    {
        private readonly Color _selectedColor = Color.white;
        private readonly Color32 _unSelectedColor = new Color32(19, 19, 19, 255);

        private DefenderButton[] _defenderButtons;

        /// <summary>
        /// Gets the current sprite renderer for this button.
        /// </summary>
        public SpriteRenderer SpriteRenderer { get; private set; }

        private void Start()
        {
            SpriteRenderer = GetComponent<SpriteRenderer>();
            _defenderButtons = FindObjectsOfType<DefenderButton>();
        }

        private void OnMouseDown()
        {
            // unselect all the buttons
            foreach(var defenderButton in _defenderButtons)
            {
                defenderButton.SpriteRenderer.color = _unSelectedColor;
            }

            // clicked on the defender we are going to have selected to spawn, change the color to white to show it is selected.
            SpriteRenderer.color = _selectedColor;
        }
    }
}
