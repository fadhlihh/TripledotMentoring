using System.Collections.Generic;
using UnityEngine;

namespace TrainingTripledot.Sesi4
{
    [CreateAssetMenu(fileName = "New Car Database", menuName = "Car/Car Database")]
    public class CarDatabase : ScriptableObject
    {
        public List<Car> CarList = new List<Car>();
    }
}
