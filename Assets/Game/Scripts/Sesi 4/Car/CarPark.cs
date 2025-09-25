using System.Collections.Generic;
using TrainingTripledot.Sesi3;
using TrainingTripledot.Sesi4;
using UnityEngine;

namespace TrainingTripledot
{
    public class CarPark : MonoBehaviour
    {
        [SerializeField]
        private CarDatabase _carDatabase;

        private Queue<Car> _carParkQueue = new Queue<Car>();

        private void Start()
        {
            foreach (Car car in _carDatabase.CarList)
            {
                _carParkQueue.Enqueue(car);
            }
        }

        private void Update()
        {
            bool isSpaceDetected = Input.GetKeyDown(KeyCode.Space);
            if (isSpaceDetected)
            {
                Car car = _carParkQueue.Dequeue();
                Debug.Log($"{car.Name} : {car.Owner.Name}");
            }
        }
    }
}
