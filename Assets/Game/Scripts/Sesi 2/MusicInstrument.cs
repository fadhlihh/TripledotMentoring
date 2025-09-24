using UnityEngine;

public class MusicInstrument : MonoBehaviour
{
    private string _name;
    private int _number;

    public MusicInstrument(string name)
    {
        _name = name;
    }

    public MusicInstrument(string name, int number)
    {
        _name = name;
        _number = number;
    }

    public virtual void Play()
    {

    }
}
