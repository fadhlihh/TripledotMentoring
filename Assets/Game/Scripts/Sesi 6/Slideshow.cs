using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TrainingTripledot.Sesi6
{
    public class Slideshow : MonoBehaviour
    {
        [SerializeField]
        private List<Sprite> _sprites = new List<Sprite>();
        [SerializeField]
        private Image _imageUI;
        int _index = 0;

        private void Start()
        {
            _imageUI.sprite = _sprites[_index];
        }

        public void NextImage()
        {
            if (_index < _sprites.Count - 1)
            {
                _index++;
            }
            else
            {
                _index = 0;
            }
            _imageUI.sprite = _sprites[_index];
        }

        public void PreviousImage()
        {
            if (_index > 0)
            {
                _index--;
            }
            else
            {
                _index = _sprites.Count - 1;
            }
            _imageUI.sprite = _sprites[_index];
        }
    }
}
