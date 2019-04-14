using UnityEngine;

namespace Assets.Scripts.Attacker
{
    [RequireComponent(typeof(AttackerHealth))]
    public class Attacker : MonoBehaviour
    {
        private float _currentSpeed = 1f;
        private GameObject _currentTarget;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            var movementSpeed = Vector2.left * _currentSpeed * Time.deltaTime;
            transform.Translate(movementSpeed);
        }

        /// <summary>
        /// Function is called from Unity Animation event.
        /// Sets the current speed to the speed passed in from the event.
        /// </summary>
        public void SetMovementSpeed(float speed)
        {
           _currentSpeed = speed;
        }

        public void Attack(GameObject target)
        {
            _currentTarget = target;
            var animator = GetComponent<Animator>();
            animator.SetBool("IsAttacking", true);
        }
    }
}