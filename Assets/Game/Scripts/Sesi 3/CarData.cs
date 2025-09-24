using System.Collections.Generic;
using UnityEngine;

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
