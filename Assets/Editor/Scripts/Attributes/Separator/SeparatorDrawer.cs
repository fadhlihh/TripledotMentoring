using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SeparatorAttribute))]
public class SeparatorDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
        SeparatorAttribute separatorAttribute = attribute as SeparatorAttribute;
        Rect separatorRect = new Rect(
            position.xMin,
            position.yMin + separatorAttribute.Spacing,
            position.width,
            separatorAttribute.Thickness
        );
        EditorGUI.DrawRect(separatorRect, Color.white);
    }

    public override float GetHeight()
    {
        SeparatorAttribute separatorAttribute = attribute as SeparatorAttribute;
        return separatorAttribute.Spacing + separatorAttribute.Thickness + separatorAttribute.Spacing;
    }
}
