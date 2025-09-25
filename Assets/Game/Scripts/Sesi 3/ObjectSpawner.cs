using UnityEngine;

namespace TrainingTripledot.Sesi3
{
    public class ObjectSpawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject spawnPrefab;
        [SerializeField]
        private Transform spawnTransform;

        private GameObject lastSpawnObject;

        private void Update()
        {
            bool detectSpaceInput = Input.GetKeyDown(KeyCode.Space);
            if (detectSpaceInput == true)
            {
                lastSpawnObject = Instantiate(spawnPrefab, spawnTransform.position, spawnTransform.rotation);
            }

            bool detectEInput = Input.GetKeyDown(KeyCode.E);
            if (detectEInput)
            {
                Destroy(lastSpawnObject);
            }
        }
    }
}
