using UnityEngine;
using UnityEngine.Events;

namespace TrainingTripledot
{
    public class AnimationEventHandler : MonoBehaviour
    {
        public UnityEvent HandleStartAttack;
        public UnityEvent HandleEndAttack;
        public void OnStartAttack()
        {
            HandleStartAttack.Invoke();
        }

        public void OnEndAttack()
        {
            HandleEndAttack.Invoke();
        }
    }
}
