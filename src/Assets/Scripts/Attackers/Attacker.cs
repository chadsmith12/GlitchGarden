using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Attacker
{
    public class Attacker : MonoBehaviour
    {
        [Range(0f, 5f)]
        [SerializeField]
        private float _walkSpeed = 1f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var movementSpeed = Vector2.left * _walkSpeed * Time.deltaTime;
            transform.Translate(movementSpeed);
        }
    }
}