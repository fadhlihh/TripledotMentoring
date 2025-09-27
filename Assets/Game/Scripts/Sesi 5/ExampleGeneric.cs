using UnityEngine;

namespace TrainingTripledot
{
    public class ExampleGeneric : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int a = 10;
            int b = 12;
            string stringA = "Hello";
            string stringB = "World";
            Swapper<int>.Swap(a, b);
            Swapper<string>.Swap(stringA, stringB);
            Debug.Log($"A: {a}");
            Debug.Log($"B: {b}");
            Debug.Log($"String A: {stringA}");
            Debug.Log($"String B: {stringB}");
        }
    }
}
