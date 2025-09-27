using System;
using UnityEngine;
using UnityEngine.Events;

namespace TrainingTripledot.Sesi5
{
    public class InputManager : MonoBehaviour
    {
        public UnityEvent<int> OnSpaceInput;
        private void Update()
        {
            bool isSpaceDetected = Input.GetKeyDown(KeyCode.Space);
            if (isSpaceDetected)
            {
                OnSpaceInput?.Invoke(5);
            }
        }
    }
}
