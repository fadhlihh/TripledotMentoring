using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace TrainingTripledot.Sesi6
{
    public class CardDeck : MonoBehaviour
    {
        [SerializeField]
        private List<Sprite> _cardList;
        [SerializeField]
        private Image _cardDeckImage;
        [SerializeField]
        private Image _openCardImage;

        private Stack<Sprite> _cardDeck = new Stack<Sprite>();

        private void Awake()
        {
            _cardList = Resources.LoadAll<Sprite>("Cards").ToList<Sprite>();
            foreach (Sprite sprite in _cardList)
            {
                _cardDeck.Push(sprite);
            }
        }

        public void GetCard()
        {
            Sprite card = _cardDeck.Pop();
            _openCardImage.sprite = card;
            if (_cardDeck.Count <= 0)
            {
                _cardDeckImage.gameObject.SetActive(false);
            }
        }
    }
}
