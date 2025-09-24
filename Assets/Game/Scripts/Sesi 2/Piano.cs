using UnityEngine;

public class Piano : MusicInstrument
{
    public Piano(string name) : base(name)
    {

    }

    public override void Play()
    {
        Debug.Log("Press Piano Button");
    }
}
