using System.Collections.Generic;
using UnityEngine;

namespace TrainingTripledot.Sesi5
{
    [CreateAssetMenu(fileName = "New Item Database", menuName = "Item/Item Database")]
    public class ItemDatabase : ScriptableObject
    {
        public List<Item> Items = new List<Item>();
    }
}
