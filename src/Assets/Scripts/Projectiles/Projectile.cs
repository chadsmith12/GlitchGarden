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
        [Range(0, 50)]
        private float _rotationSpeed = 1f;

        // Update is called once per frame
        void Update()
        {
            var movement = Vector2.right * _moveSpeed * Time.deltaTime;
            var rotation = Vector3.forward * _rotationSpeed * Time.deltaTime;
            transform.Translate(movement);
            transform.Rotate(rotation.x, rotation.y, rotation.z);
        }
    }
}
