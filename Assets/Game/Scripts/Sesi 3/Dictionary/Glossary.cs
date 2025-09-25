using System.Collections.Generic;
using UnityEngine;

namespace TrainingTripledot.Sesi3
{
    public class Glossary : MonoBehaviour
    {
        [SerializeField]
        private Keyword _keyword;

        private Dictionary<Keyword, string> _dataStructureDictionary = new Dictionary<Keyword, string>();
        private void Start()
        {
            _dataStructureDictionary.Add(Keyword.Object, "Wrap different types of data together, with reference type");
            _dataStructureDictionary.Add(Keyword.Struct, "Wrap different types of data together, with value type");
            _dataStructureDictionary.Add(Keyword.Array, "A collection of values with a fixed number of items/elements.");
            _dataStructureDictionary.Add(Keyword.List, "A collection of values with a dynamic number of items/elements.");
            _dataStructureDictionary.Add(Keyword.Queue, "A data structure that follows the First In, First Out (FIFO) principle.");
            _dataStructureDictionary.Add(Keyword.Stack, "A data structure that follows the Last In, First Out (LIFO) principle.");
            _dataStructureDictionary.Add(Keyword.Dictionary, "A data structure that stores key-value pairs, where each key is unique and used to access its corresponding value.");
        }

        private void Update()
        {
            bool isSpaceDetected = Input.GetKeyDown(KeyCode.Space);
            if (isSpaceDetected)
            {
                Debug.Log(_dataStructureDictionary[_keyword]);
            }
        }
    }
}
