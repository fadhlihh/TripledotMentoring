using UnityEngine;

namespace TrainingTripledot.Sesi2
{
    public class ExampleScript : MonoBehaviour
    {
        [Range(0f, 100f)]
        [SerializeField]
        private float speed = 1;
        [TextArea]
        [SerializeField]
        private string dialogue;

        private void Update()
        {

        }
    }
}
