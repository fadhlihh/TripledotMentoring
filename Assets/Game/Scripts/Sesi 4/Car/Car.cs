using UnityEngine;

namespace TrainingTripledot.Sesi4
{
    [CreateAssetMenu(fileName = "New Car", menuName = "Car/Car Data")]
    public class Car : ScriptableObject
    {
        public Person Owner;
        public string Manufacture;
        public string Name;
        public string Color;
        public string LicensePlate;
    }
}
