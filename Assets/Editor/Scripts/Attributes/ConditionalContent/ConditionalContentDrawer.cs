using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ConditionalContentAttribute))]
public class ConditionalContentDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        ConditionalContentAttribute conditionalAttribute = attribute as ConditionalContentAttribute;
        SerializedProperty conditionProp = property.serializedObject.FindProperty(conditionalAttribute.Name);
        if (conditionProp != null && conditionProp.propertyType == SerializedPropertyType.Boolean)
        {
            if (conditionProp.boolValue)
            {
                EditorGUI.PropertyField(position, property);
            }
        }
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        ConditionalContentAttribute conditionalAttribute = attribute as ConditionalContentAttribute;
        SerializedProperty conditionProp = property.serializedObject.FindProperty(conditionalAttribute.Name);
        if (conditionProp != null && conditionProp.propertyType == SerializedPropertyType.Boolean && conditionProp.boolValue)
        {
            return EditorGUI.GetPropertyHeight(property, label, true);
        }
        return 0f;
    }
}
