using UnityEngine;

namespace TrainingTripledot
{
    public class Customer : MonoBehaviour
    {
        [SerializeField]
        private string _name;
        [SerializeField]
        private Bank _bank;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _bank.CreateAccount(_name);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _bank.WithdrawMoney(_name, 10000);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _bank.StoreMoney(_name, 10000);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                _bank.CheckBalance(_name);
            }
        }
    }
}
