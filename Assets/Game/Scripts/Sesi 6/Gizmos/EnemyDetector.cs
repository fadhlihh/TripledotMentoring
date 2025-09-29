using UnityEngine;

namespace TrainingTripledot
{
    public class EnemyDetector : MonoBehaviour
    {
        [SerializeField]
        private float _distance;
        [SerializeField]
        private Vector3 _cubeSize;
        [SerializeField]
        private LayerMask _detectionLayer;

        private void Update()
        {
            bool _isObjectDetected = Physics.BoxCast(transform.position, _cubeSize * 0.5f, transform.forward, out RaycastHit hit, Quaternion.identity, _distance, _detectionLayer);
            if (_isObjectDetected)
            {
                Debug.Log(hit.collider.gameObject.layer);
            }
        }

        private void OnDrawGizmos()
        {
            bool _isObjectDetected = Physics.BoxCast(transform.position, _cubeSize * 0.5f, transform.forward, out RaycastHit hit, Quaternion.identity, _distance, _detectionLayer);
            if (_isObjectDetected)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawLine(transform.position, transform.position + transform.forward * hit.distance);
                Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, _cubeSize);
            }
            else
            {
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, transform.position + transform.forward * _distance);
                Gizmos.DrawWireCube(transform.position + transform.forward * _distance, _cubeSize);
            }
        }
    }
}
