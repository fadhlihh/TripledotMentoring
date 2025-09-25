using UnityEngine;

namespace TrainingTripledot.Sesi2
{
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
}
