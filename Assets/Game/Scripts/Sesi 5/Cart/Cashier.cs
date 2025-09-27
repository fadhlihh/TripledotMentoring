using System.Collections.Generic;
using UnityEngine;

namespace TrainingTripledot.Sesi5
{
    public class Cashier : MonoBehaviour
    {
        [Header("Database")]
        [SerializeField]
        private ItemDatabase _itemDatabase;

        [Header("Input")]
        [SerializeField]
        private string _itemToBuy;

        private List<Item> _cartItem = new List<Item>();
        public int _totalPayAmount = 0;

        public void AddToCart(string id)
        {
            Item itemToAdd = _itemDatabase.Items.Find(item => string.Equals(item.ID, id));
            if (itemToAdd != null)
            {
                _cartItem.Add(itemToAdd);
            }
        }

        public void RemoveFromCart(string id)
        {
            Item itemToAdd = _itemDatabase.Items.Find(item => string.Equals(item.ID, id));
            if (itemToAdd != null)
            {
                _cartItem.Remove(itemToAdd);
            }
        }

        public void Checkout()
        {
            if (_cartItem.Count > 0)
            {
                foreach (Item item in _cartItem)
                {
                    _totalPayAmount = _totalPayAmount + item.Price;
                }
                _cartItem.Clear();
                Debug.Log(_totalPayAmount);
            }
            else
            {
                Debug.Log("Cart kosong tidak bisa dicheckout");
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                AddToCart(_itemToBuy);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                RemoveFromCart(_itemToBuy);
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Checkout();
            }
        }
    }
}
