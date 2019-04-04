﻿using UnityEngine;
using Assets.Scripts.Gameplay;

namespace Assets.Scripts.Defefenders
{
    public class DefenderSpawner : MonoBehaviour
    {
        private Defender _defender;
        private StarDisplay _starDisplay;

        private void Start()
        {
            _starDisplay = FindObjectOfType<StarDisplay>();
        }

        private void OnMouseDown()
        {
            var gridPosition = SnapToGrid(GetSquarePosition());
            AttemptToPlaceDefender(gridPosition);
        }

        /// <summary>
        /// Sets the defender to spawn to the defender that was selected.
        /// </summary>
        /// <param name="defenderToSelect">The defender that was selected that should be spawned.</param>
        public void SetSelectedDefender(Defender defenderToSelect)
        {
            _defender = defenderToSelect;
        }

        private Vector2 GetSquarePosition()
        {
            var clickedPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            var worldPosition = Camera.main.ScreenToWorldPoint(clickedPosition);

            return worldPosition;
        }

        private Vector2 SnapToGrid(Vector2 rawPosition)
        {
            return new Vector2(Mathf.RoundToInt(rawPosition.x), Mathf.RoundToInt(rawPosition.y));
        }

        private void SpawnDefender(Vector2 spawnPosition)
        {
            Instantiate(_defender, spawnPosition, Quaternion.identity);
        }

        private void AttemptToPlaceDefender(Vector2 gridPos)
        {
            var defenderCost = _defender.StarCost;

            if(_starDisplay.HasEnoughStars(defenderCost))
            {
                SpawnDefender(gridPos);
                _starDisplay.SpendStars(defenderCost);
            }
        }
    }
}
