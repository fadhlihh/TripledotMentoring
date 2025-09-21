using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(TitleAttribute))]
public class TitleDrawer : DecoratorDrawer
{
    public override void OnGUI(Rect position)
    {
        TitleAttribute titleAttribute = attribute as TitleAttribute;

        Rect titleRect = new Rect(
            position.xMin,
            position.yMin + 15,
            position.width,
            60
        );

        EditorGUI.DrawRect(titleRect, Color.limeGreen);
        GUIStyle style = new GUIStyle();
        style.fontSize = 24;
        style.fontStyle = FontStyle.Bold;
        style.normal.textColor = Color.white;
        style.alignment = TextAnchor.MiddleCenter;
        EditorGUI.LabelField(titleRect, new GUIContent(titleAttribute.Title), style);
    }

    public override float GetHeight()
    {
        return 15 + 60 + 15;
    }
}
