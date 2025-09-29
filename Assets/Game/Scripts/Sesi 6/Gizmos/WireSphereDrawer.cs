using UnityEngine;

namespace TrainingTripledot
{
    public class WireSphereDrawer : MonoBehaviour
    {
        private void OnDrawGizmos()
        {
            // Gizmos.DrawLine(transform.position, transform.right * 8 + transform.position);
            // Gizmos.DrawRay(transform.position, transform.right * 8);
            // Gizmos.DrawWireSphere(transform.position, 5);
            // Gizmos.DrawWireCube(transform.position, new Vector3(5, 2, 2));
            // Gizmos.DrawIcon(transform.position, "brain.png");
            Gizmos.color = Color.red;
            Gizmos.DrawFrustum(transform.position, 45, 40, 0, 1);
        }

        private void OnDrawGizmosSelected()
        {
        }
    }
}
