using UnityEngine;

namespace Assets.Scripts.Defefenders
{
    public class DefenderSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _defender;

        private void OnMouseDown()
        {
            SpawnDefender();
        }

        private void SpawnDefender()
        {
            var defender = Instantiate(_defender, transform.position, Quaternion.identity);
        }
    }
}
