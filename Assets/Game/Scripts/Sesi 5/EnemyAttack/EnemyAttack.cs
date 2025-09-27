using UnityEngine;

namespace TrainingTripledot.Sesi5
{
    public abstract class EnemyAttack
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public abstract void Attack();
    }
}
