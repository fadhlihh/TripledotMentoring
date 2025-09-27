using System.Collections.Generic;
using UnityEngine;

namespace TrainingTripledot.Sesi5
{
    public class Enemy : MonoBehaviour
    {
        List<EnemyAttack> _enemyAttack = new List<EnemyAttack>();
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _enemyAttack.Add(new MeleeAttack());
            _enemyAttack.Add(new RangeAttack());
            _enemyAttack.Add(new MagicAttack());
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _enemyAttack[0].Attack();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                _enemyAttack[1].Attack();
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                _enemyAttack[2].Attack();
            }
        }
    }
}
