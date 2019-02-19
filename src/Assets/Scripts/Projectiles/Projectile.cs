using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        // Update is called once per frame
        void Update()
        {
            var movement = Vector2.right * _moveSpeed * Time.deltaTime;
            var newRotation = Vector3.forward * _rotationSpeed * Time.deltaTime;
            transform.Translate(movement, Space.World);
            transform.Rotate(Vector3.forward, _rotationSpeed * Time.deltaTime);
        }
    }
}
