using UnityEditor;
using UnityEngine;

namespace TrainingTripledot
{
    [CustomPropertyDrawer(typeof(ClampIntValueAttribute))]
    public class SeparatorDrawer : DecoratorDrawer
    {
        public override void OnGUI(Rect position)
        {
            SeparatorAttribute separatorAttribute = attribute as SeparatorAttribute;
            Rect separatorRect = new Rect
            (
                position.x,
                position.y + separatorAttribute.Spacing,
                position.width,
                position.height + separatorAttribute.Thickness
            );
            separatorRect.xMax += 50;
            separatorRect.xMin -= 50;
            EditorGUI.DrawRect(separatorRect, Color.white);
        }

        public override float GetHeight()
        {
            SeparatorAttribute separatorAttribute = attribute as SeparatorAttribute;
            return separatorAttribute.Spacing + separatorAttribute.Thickness + separatorAttribute.Spacing;
        }
    }
}
