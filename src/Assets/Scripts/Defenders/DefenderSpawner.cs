using UnityEngine;

namespace Assets.Scripts.Defefenders
{
    public class DefenderSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _defender;

        private void OnMouseDown()
        {
            var gridPosition = SnapToGrid(GetSquarePosition());
            SpawnDefender(gridPosition);
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
    }
}
