using UnityEditor;
using UnityEngine;

namespace TrainingTripledot.Sesi6
{
    public class TurretDetector : MonoBehaviour
    {
        [SerializeField]
        private float _detectionDistance;
        private void OnDrawGizmos()
        {
            DamagableObject[] detectedObjectArray = FindObjectsByType<DamagableObject>(FindObjectsSortMode.None);
            Gizmos.color = Color.blue;
            Gizmos.DrawWireSphere(transform.position, .25f);
            Gizmos.color = Color.white;
            Gizmos.DrawWireSphere(transform.position, _detectionDistance);
            foreach (DamagableObject detectedObject in detectedObjectArray)
            {
                float distance = Vector3.Distance(detectedObject.transform.position, transform.position);
                if (distance < _detectionDistance)
                {
                    Gizmos.color = Color.red;
                    Gizmos.DrawLine(transform.position, detectedObject.transform.position + transform.up * 2f);
                    Gizmos.DrawWireSphere(detectedObject.transform.position + transform.up * 2f, .5f);
                }
            }
        }
    }
}
