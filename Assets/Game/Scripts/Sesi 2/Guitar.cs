using UnityEngine;

public class Guitar : MusicInstrument
{
    private string _type;
    public Guitar(string name, string type) : base(name)
    {
        _type = type;
    }
    public override void Play()
    {
        Debug.Log("Pick Guitar String");
    }
}
