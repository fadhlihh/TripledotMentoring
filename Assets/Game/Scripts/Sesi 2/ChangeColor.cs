using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private Material _material;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        meshRenderer.material = _material;
    }

    void OnCollisionStay(Collision collision)
    {

    }

    void OnCollisionExit(Collision collision)
    {

    }

    void OnTriggerEnter(Collider other)
    {

    }
}
