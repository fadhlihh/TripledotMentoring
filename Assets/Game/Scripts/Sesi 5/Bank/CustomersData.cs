using UnityEngine;

namespace TrainingTripledot
{
    [System.Serializable]
    public class CustomersData
    {
        public string Name;
        public int Balance;

        public CustomersData(string name)
        {
            this.Name = name;
        }
    }
}
