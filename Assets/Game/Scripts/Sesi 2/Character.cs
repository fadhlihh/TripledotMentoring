using UnityEngine;

namespace TrainingTripledot.Sesi2
{
    public class Character
    {
        private string _name;
        private int _healthPoint = 100;
        private int _level = 1;
        private int _attackStat = 10;
        private int _defenseStat = 5;

        public string Name { get => _name; }
        public int HealthPoint { get => _healthPoint; }
        public int Level { get => _level; }
        public int AttackStat { get => _attackStat; }
        public int DefenseStat { get => _defenseStat; }

        public Character(string name, int healthPoint = 100)
        {
            this._name = name;
            this._healthPoint = healthPoint;
        }

        public void Attack(Character target)
        {
            Debug.Log($"{_name} Attack {target.Name}");
            target.Damage(_attackStat);
        }

        public void LevelUp()
        {
            _level += 1;
            _attackStat += 5;
            _defenseStat += 5;
            Debug.Log($"{_name} Level Up, Level: {_level}, Attack: {_attackStat}, Defense: {_defenseStat}");
        }

        public void Damage(int hitPoint)
        {
            _healthPoint -= hitPoint - DefenseStat;
            Debug.Log($"{_name} Received Damage. HP: {_healthPoint}");
        }
    }
}
