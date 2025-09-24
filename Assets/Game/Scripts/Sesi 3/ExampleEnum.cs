using System.Collections.Generic;
using UnityEngine;

public class ExampleEnum : MonoBehaviour
{
    [SerializeField]
    List<Weapon> weaponList;

    private void Start()
    {
        weaponList.Find(weapon => weapon.Type == WeaponType.Range);
    }
}
