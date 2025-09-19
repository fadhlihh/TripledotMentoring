using UnityEngine;

public class CubeGizmos : MonoBehaviour
{
    [SerializeField]
    private float _detectionRadius = 1f;

    private void Update()
    {
        Debug.DrawLine(transform.position, transform.position + (transform.forward * 5f));
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _detectionRadius);
        // Gizmos.DrawFrustum(transform.position, 45, 5, 1, 1f);
        // Gizmos.DrawIcon(transform.position, "brain.png", true, Color.red);
    }
}
