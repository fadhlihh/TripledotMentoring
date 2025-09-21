using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ClampIntValueAttribute))]
public class ClampIntValueDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        ClampIntValueAttribute clampAttribute = attribute as ClampIntValueAttribute;

        if (property.propertyType == SerializedPropertyType.Integer)
        {
            property.intValue = EditorGUI.IntField(position, label, property.intValue);
            property.intValue = Mathf.Clamp(property.intValue, clampAttribute.MinValue, clampAttribute.MaxValue);
        }
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.Integer)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
        return 0;
    }
}