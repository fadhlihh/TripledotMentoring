using UnityEngine;

namespace TrainingTripledot.Sesi5
{
    public class Score : MonoBehaviour
    {
        [SerializeField]
        private InputManager _input;
        public int ScoreCount { get; private set; }

        private void OnEnable()
        {
            // _input.OnSpaceInput.AddListener(AddScore);
        }

        public void AddScore(int score)
        {
            ScoreCount += score;
        }

        private void OnDisable()
        {
            // _input.OnSpaceInput.RemoveListener(AddScore);
        }

    }
}
