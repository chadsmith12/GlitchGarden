using UnityEngine;

namespace Assets.Scripts.VFX
{
    public class ParticleTrigger : MonoBehaviour
    {
        public void TriggerParticle(Transform triggeredTransform)
        {
            var currentParticle = Instantiate(this, triggeredTransform.position, triggeredTransform.rotation);
            Destroy(currentParticle, 1f);
        }
    }
}
