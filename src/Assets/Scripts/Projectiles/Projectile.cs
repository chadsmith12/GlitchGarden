using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Attacker;

namespace Assets.Scripts.Projectiles
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField]
        [Range(0,5)]
        private float _moveSpeed = 1f;
        [SerializeField]
        [Range(-360, 360)]
        private float _rotationSpeed = 1f;
        [SerializeField] private int _damageAmount = 10;

        // Update is called once per frame
        void Update()
        {
            var movement = Vector2.right * _moveSpeed * Time.deltaTime;
            var newRotation = Vector3.forward * _rotationSpeed * Time.deltaTime;
            transform.Translate(movement, Space.World);
            transform.Rotate(Vector3.forward, _rotationSpeed * Time.deltaTime);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            // if this game object we collided with as a attacker component, then we know it's an attacker. 
            // process collision for it.
            var attackerComponent = collision.GetComponent<Attacker.Attacker>();
            if(attackerComponent != null)
            {
                ProcessAttackerCollision(collision);
                Destroy(gameObject);
            }
        }

        private void ProcessAttackerCollision(Collider2D collision)
        {
            var healthComponent = collision.GetComponent<AttackerHealth>();
            healthComponent.DealDamage(_damageAmount);
        }
    }
}
