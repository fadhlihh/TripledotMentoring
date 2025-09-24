using UnityEngine;

public class ExampleStatic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string result = StringConcat.Concat("Hello", " World");
        Debug.Log(result);
    }
}
