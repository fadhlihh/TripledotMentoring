using UnityEngine;

public class RangedEnemy : Enemy
{
    private int _ammunition = 10;

    public int Ammunition { get => _ammunition; }

    public void Reload()
    {
        _ammunition = 10;
        Debug.Log("Reload");
    }

    public override void Attack()
    {
        Debug.Log("Attack with bow");
    }
}
