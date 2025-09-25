using UnityEngine;

namespace TrainingTripledot.Sesi4
{
    public enum PersonID
    {
        Person_001 = 0,
        Person_002 = 1
    }

    [CreateAssetMenu(fileName = "New Person", menuName = "Person/PersonData")]
    public class Person : ScriptableObject
    {
        public PersonID ID;
        public string Name;
        public string Role;
    }
}
