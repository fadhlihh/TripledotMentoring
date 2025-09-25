using UnityEngine;

namespace TrainingTripledot.Sesi4
{
    public class Guitar : MusicInstrument, IWeapon
    {
        public string Name;
        public override void Play()
        {
            Debug.Log("Pick Guitar String");
        }

        public void TuneGuitar()
        {
            Debug.Log("Tuning Guitar");
        }

        public void Use()
        {
            Debug.Log($"Hit character with {Name}");
        }
    }
}
