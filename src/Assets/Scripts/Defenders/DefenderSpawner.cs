using UnityEngine;

namespace Assets.Scripts.Defefenders
{
    public class DefenderSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _defender;

        private void OnMouseDown()
        {
            SpawnDefender(GetSquarePosition());
        }

        private Vector2 GetSquarePosition()
        {
            var clickedPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            var worldPosition = Camera.main.ScreenToWorldPoint(clickedPosition);

            return worldPosition;
        }

        private void SpawnDefender(Vector2 spawnPosition)
        {
            var defender = Instantiate(_defender, spawnPosition, Quaternion.identity);
        }
    }
}
