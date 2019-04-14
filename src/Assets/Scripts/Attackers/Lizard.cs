using Assets.Scripts.Defefenders;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Attacker
{
    public class Lizard : MonoBehaviour
    {
        private Attacker _attacker;

        private void Start()
        {
            _attacker = GetComponent<Attacker>();
        }

        private void OnTriggerEnter2D(Collider2D otherCollider)
        {
            var otherObject = otherCollider.gameObject;
            var isDefender = otherObject.GetComponent<Defender>() != null;

            if(isDefender)
            {
                _attacker.Attack(otherObject);
            }
        }
    }
}

