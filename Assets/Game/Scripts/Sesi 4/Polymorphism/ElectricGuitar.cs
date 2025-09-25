using UnityEngine;

namespace TrainingTripledot.Sesi4
{
    public class ElectricGuitar : Guitar
    {
        public void Play()
        {
            base.Play();
            Debug.Log("Plug the cable to amplifier");
        }
    }
}
