using UnityEngine;

namespace TrainingTripledot.Sesi4
{
    [CreateAssetMenu(fileName = "New Scriptable Object", menuName = "Scriptable Object/Example", order = 0)]
    public class ExampleScriptableObject : ScriptableObject
    {
        public int Number;
        public string Name;
        public bool isActive;
    }
}
