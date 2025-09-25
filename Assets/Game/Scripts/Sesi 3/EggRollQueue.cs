using System.Collections.Generic;
using UnityEngine;

namespace TrainingTripledot.Sesi3
{
    public class EggRollQueue : MonoBehaviour
    {
        private Queue<string> eggRollQueue = new Queue<string>();

        private void Start()
        {
            eggRollQueue.Enqueue("Glina");
            eggRollQueue.Enqueue("Phoebe");
            eggRollQueue.Enqueue("Inge");
            eggRollQueue.Enqueue("Peter");
        }

        private void Update()
        {
            bool isSpaceDetected = Input.GetKeyDown(KeyCode.Space);
            if (isSpaceDetected)
            {
                string name = eggRollQueue.Dequeue();
                Debug.Log(name);
            }
        }
    }
}
