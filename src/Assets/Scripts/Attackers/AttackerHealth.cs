using UnityEngine;
using Assets.Scripts.VFX;

namespace Assets.Scripts.Attacker
{
    public class AttackerHealth : MonoBehaviour
    {
        [SerializeField] private int _currentHealth;
        [SerializeField] private ParticleTrigger _deathVfx;

        /// <summary>
        /// Deals damage to this attackers health by a specific amount.
        /// If the attacker runs out of health, will destroy itself.
        /// </summary>
        /// <param name="damageAmount">Amount of health to deal.</param>
        public void DealDamage(int damageAmount)
        {
            _currentHealth -= damageAmount;

            if(_currentHealth <=0)
            {
                TriggerDeathVFX();
                Destroy(gameObject);
            }
        }

        private void TriggerDeathVFX()
        {
            if (!_deathVfx)
            {
                return;
            }

            _deathVfx.TriggerParticle(transform);
        }
    }
}