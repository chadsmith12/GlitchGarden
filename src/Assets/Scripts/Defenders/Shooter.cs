using UnityEngine;
using Assets.Scripts.Projectiles;

namespace Assets.Scripts.Attacker
{
    public class Shooter : MonoBehaviour
    {
        [SerializeField] private Projectile _projectile;
        [SerializeField] private GameObject _gun;

        public void Fire()
        {
            Instantiate(_projectile, _gun.transform.position, _gun.transform.rotation);
        }
    }
}
