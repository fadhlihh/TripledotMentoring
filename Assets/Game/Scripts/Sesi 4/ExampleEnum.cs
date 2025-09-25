using UnityEngine;

namespace TrainingTripledot
{
    public class ExampleEnum : MonoBehaviour
    {
        public enum Platform
        {
            Android = 0,
            IOS = 1,
            PC = 2
        }

        private Platform target;

        private void Start()
        {
            target = (Platform)2;
            Debug.Log(target);
        }
    }
}
