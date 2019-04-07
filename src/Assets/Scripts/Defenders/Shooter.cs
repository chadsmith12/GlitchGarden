using UnityEngine;
using Assets.Scripts.Projectiles;

namespace Assets.Scripts.Attacker
{
    public class Shooter : MonoBehaviour
    {
        [SerializeField] private Projectile _projectile;
        [SerializeField] private GameObject _gun;


        private AttackerSpawner _laneSpawner;
        private Animator _animator;
        private bool _isAttacking;

        private void Start()
        {
            SetLaneSpawner();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            if(IsAttackerInLane())
            {
                SetIsAttacking(true);
            }
            else
            {
                SetIsAttacking(false);
            }
        }

        private void SetLaneSpawner()
        {
            var attackerSpawners = FindObjectsOfType<AttackerSpawner>();

            foreach(var spawner in attackerSpawners)
            {
                var isCloseEnough = IsSpawnerCloseEnough(spawner);
                if(isCloseEnough)
                {
                    _laneSpawner = spawner;
                    return;
                }
            }
        }

        private bool IsSpawnerCloseEnough(AttackerSpawner spawner)
        {
            var currentDiff = Mathf.Abs(spawner.transform.position.y - transform.position.y);
            Debug.Log("Current Dif: " + currentDiff);
            Debug.Log("Epislon Value: " + Mathf.Epsilon);
            var difference = Mathf.Abs(currentDiff) <= Mathf.Epsilon;
            Debug.Log("Is Close Enough: " + difference);

            return difference;
        }

        private bool IsAttackerInLane()
        {
            return _laneSpawner.transform.childCount > 0;
        }

        private void SetIsAttacking(bool isAttacking)
        {
            _isAttacking = isAttacking;
            _animator.SetBool("IsAttacking", _isAttacking);
        }

        public void Fire()
        {
            Instantiate(_projectile, _gun.transform.position, _gun.transform.rotation);
        }
    }
}
