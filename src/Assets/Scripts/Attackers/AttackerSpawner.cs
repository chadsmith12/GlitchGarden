using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Attacker
{
    public class AttackerSpawner : MonoBehaviour
    {
        private bool _spawn = true;
        [SerializeField]
        [Tooltip("The minimum amount of time to delay, inclusive, before another attacker is spawned (in seconds)")]
        private int _minSpawnDelay = 1;
        [SerializeField]
        [Tooltip("The maximum amount of time to delay, inclusive, before another attacker is spawned (in seconds)")]
        private int _maxSpawnDelay = 5;
        [SerializeField] private Attacker _attackerPrefab;

        // Use this for initialization
        void Start()
        {
            StartCoroutine(StartSpawning());
        }

        // Update is called once per frame
        void Update()
        {

        }

        private IEnumerator StartSpawning()
        {
            while(_spawn)
            {
                var nextSpawnTime = Random.Range(_minSpawnDelay, _maxSpawnDelay);
                yield return new WaitForSeconds(nextSpawnTime);
                SpawnAttacker();
            }
        }

        private void SpawnAttacker()
        {
            Instantiate(_attackerPrefab, transform.position, transform.rotation);
        }
    }
}
