using UnityEngine;

namespace TrainingTripledot.Sesi2
{
    public class Enemy
    {
        private string _name;
        private int _healthPoint;

        public string Name { get => _name; }
        public int HealthPoint { get => _healthPoint; }

        public void Move()
        {
            Debug.Log($"{_name} Moving");
        }

        public virtual void Attack()
        {
            Debug.Log($"{_name} Attack");
        }
    }
}
