using UnityEngine;

namespace TrainingTripledot.Sesi2
{
    public class MeleeEnemy : Enemy
    {
        private int _weaponDurability = 100;

        public int WeaponDurability { get => _weaponDurability; }

        public void RepairWeapon()
        {
            Debug.Log("Repair Weapon");
        }

        public override void Attack()
        {
            Debug.Log("Attack with sword");
        }
    }
}
