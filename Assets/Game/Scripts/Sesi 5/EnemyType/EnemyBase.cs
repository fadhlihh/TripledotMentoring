using UnityEngine;

namespace TrainingTripledot.Sesi5
{
    public abstract class EnemyBase : MonoBehaviour
    {
        [SerializeField]
        protected string _name;
        [SerializeField]
        private int _healthPoint;
    }
}
