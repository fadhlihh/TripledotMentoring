using System.Collections.Generic;
using UnityEngine;

namespace TrainingTripledot
{
    public class Bank : MonoBehaviour
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private List<CustomersData> _customerData = new List<CustomersData>();

        public void CreateAccount(string name)
        {
            _customerData.Add(new CustomersData(name));
        }

        public void WithdrawMoney(string name, int amount)
        {
            CustomersData customer = _customerData.Find(cst => string.Equals(cst.Name, name));
            if (amount <= customer.Balance)
            {
                customer.Balance = customer.Balance - amount;
            }
            else
            {
                customer.Balance = 0;
            }
        }

        public void StoreMoney(string name, int amount)
        {
            CustomersData customer = _customerData.Find(cst => string.Equals(cst.Name, name));
            customer.Balance = customer.Balance + amount;
        }

        public void CheckBalance(string name)
        {
            CustomersData customer = _customerData.Find(cst => string.Equals(cst.Name, name));
            Debug.Log($"{name}: {customer.Balance}");
        }
    }
}
