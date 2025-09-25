using System.Collections;
using UnityEngine;

namespace TrainingTripledot.Sesi4
{
    public class CarWash : MonoBehaviour
    {
        [SerializeField]
        private bool _isRotating = true;
        [SerializeField]
        private Transform _cubeTransform;

        private void Start()
        {
            StartCoroutine(RotateCube());
            Debug.Log("Cube Change color to red");
        }

        private IEnumerator RotateCube()
        {
            while (_isRotating == true)
            {
                _cubeTransform.Rotate(0, 10 * Time.deltaTime, 0);
                yield return null;
            }
        }
    }
}

