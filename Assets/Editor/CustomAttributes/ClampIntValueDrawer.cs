using UnityEditor;
using UnityEngine;

namespace TrainingTripledot
{
    [CustomPropertyDrawer(typeof(ClampIntValueAttribute))]
    public class ClampIntValueDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ClampIntValueAttribute clampIntValueAttribute = attribute as ClampIntValueAttribute;
            property.intValue = EditorGUI.IntField(position, label, property.intValue);
            property.intValue = Mathf.Clamp(property.intValue, clampIntValueAttribute.MinValue, clampIntValueAttribute.MaxValue);
        }
    }
}
