using UnityEngine;
using UnityEngine.UI;

namespace TrainingTripledot
{
    public class ImageChange : MonoBehaviour
    {
        [SerializeField]
        private Sprite _imageToShow;
        [SerializeField]
        private Image _imageUI;

        public void ShowImage()
        {
            _imageUI.sprite = _imageToShow;
        }
    }
}
