using UnityEngine;

public class Player : MonoBehaviour
{
    [Title("Player")]
    [SerializeField]
    private string _name;
    [Separator(1.5f, 10)]
    [ReadOnly]
    [SerializeField]
    private int _level;
}
