using UnityEngine;

namespace TrainingTripledot.Sesi4
{
    public class Musician : MonoBehaviour
    {
        [SerializeField]
        private MusicInstrument _musicInstrument;

        private void Start()
        {
            _musicInstrument.Play();
            IWeapon weapon = _musicInstrument.GetComponent<IWeapon>();
            if (weapon != null)
            {
                weapon.Use();
            }
        }
    }
}
