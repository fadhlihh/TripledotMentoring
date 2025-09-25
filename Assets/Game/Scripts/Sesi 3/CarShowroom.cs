using UnityEngine;

namespace TrainingTripledot.Sesi3
{
    public class CarShowroom : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            CarStruct jazzCar1 = new CarStruct("Honda", "Jazz", "Red", "B 1234 XYZ");
            CarStruct jazzCar2 = jazzCar1;
            jazzCar2.LicensePlate = "B 7890 ABC";
            Debug.Log(jazzCar1.LicensePlate);
            Debug.Log(jazzCar2.LicensePlate);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
