using UnityEngine;

public class Drum : MusicInstrument
{
    public Drum(string name) : base(name)
    {

    }
    public override void Play()
    {
        Debug.Log("Hit Drum");
    }
}
