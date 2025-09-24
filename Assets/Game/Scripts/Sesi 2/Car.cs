using System;
using UnityEngine;

[Serializable]
public class Car
{
    [SerializeField]
    private string _manufacture;
    [SerializeField]
    private string _name;
    [SerializeField]
    private string _licensePlate;
    [SerializeField]
    private float _topSpeed;

    public string Manufacture { get => _manufacture; }
    public string Name { get => _name; }
    public string LicensePlate { get => _licensePlate; }
    public float TopSpeed
    {
        get => _topSpeed;
        set
        {
            if (value >= 200)
            {
                _topSpeed = 200;
            }
            else
            {
                _topSpeed = value;
            }
        }
    }

    public Car()
    {

    }

    public Car(string manufacture, string name, string licensePlate, float topSpeed)
    {
        _manufacture = manufacture;
        _name = name;
        _licensePlate = licensePlate;
        _topSpeed = topSpeed;
    }

    public void Throttle()
    {
        Debug.Log("Car is Moving");
    }

    public void Brake()
    {
        Debug.Log("Car Stops");
    }
}
