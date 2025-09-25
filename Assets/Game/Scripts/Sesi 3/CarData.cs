using System.Collections.Generic;
using TrainingTripledot.Sesi2;
using UnityEngine;

namespace TrainingTripledot.Sesi3
{
    public class CarData : MonoBehaviour
    {
        [SerializeField]
        private List<Car> carList = new List<Car>();

        private void Start()
        {
            Car car = carList.Find(car => string.Equals(car.Name, "Avanza"));
            bool isAvanzaExsist = carList.Exists(car => string.Equals(car.Name, "Avanza"));
            // carList.Remove(car);
        }
    }
}
