using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Character))]
public class CharacterEditor : Editor
{
    private SerializedProperty _nameProp;
    private SerializedProperty _healthProp;
    private SerializedProperty _maxHealthProp;
    private SerializedProperty _canCombatProp;
    private SerializedProperty _physicalProp;
    private SerializedProperty _dexterityProp;
    private SerializedProperty _intelligenceProp;
    private SerializedProperty _luckProp;

    private void OnEnable()
    {
        _nameProp = serializedObject.FindProperty("_name");
        _healthProp = serializedObject.FindProperty("_health");
        _maxHealthProp = serializedObject.FindProperty("_maxHealth");
        _canCombatProp = serializedObject.FindProperty("_canCombat");
        _physicalProp = serializedObject.FindProperty("_physical");
        _dexterityProp = serializedObject.FindProperty("_dexterity");
        _intelligenceProp = serializedObject.FindProperty("_intelligence");
        _luckProp = serializedObject.FindProperty("_luck");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        DrawTitle();
        EditorGUILayout.Space(10);
        EditorGUILayout.PropertyField(_nameProp);
        EditorGUILayout.Space(10);
        EditorGUILayout.BeginHorizontal();
        EditorGUIUtility.labelWidth = 80;
        EditorGUILayout.PropertyField(_healthProp);
        GUILayout.Space(30);
        EditorGUIUtility.labelWidth = 100;
        EditorGUILayout.PropertyField(_maxHealthProp);
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Space(5);
        Rect progressBarRect = GUILayoutUtility.GetRect(20, 20);
        float progressValue = (float)_healthProp.intValue / (float)_maxHealthProp.intValue;
        EditorGUI.ProgressBar(progressBarRect, progressValue, $"{_healthProp.intValue} / {_maxHealthProp.intValue}");
        EditorGUILayout.Space(10);
        EditorGUILayout.PropertyField(_canCombatProp);
        if (_canCombatProp.boolValue == true)
        {
            EditorGUILayout.Space(10);
            EditorGUILayout.LabelField("Combat Attribute", EditorStyles.boldLabel);
            EditorGUILayout.Space(5);
            EditorGUI.indentLevel++;
            EditorGUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = 50;
            EditorGUILayout.PropertyField(_physicalProp, new GUIContent("ATK"));
            GUILayout.Space(15);
            EditorGUIUtility.labelWidth = 50;
            EditorGUILayout.PropertyField(_dexterityProp, new GUIContent("DEX"));
            GUILayout.Space(15);
            EditorGUIUtility.labelWidth = 50;
            EditorGUILayout.PropertyField(_intelligenceProp, new GUIContent("INT"));
            EditorGUILayout.EndHorizontal();
            EditorGUI.indentLevel--;
        }
        EditorGUILayout.Space(10);
        EditorGUILayout.IntSlider(_luckProp, 0, 100);
        serializedObject.ApplyModifiedProperties();
    }

    private void DrawTitle()
    {
        EditorGUILayout.Space(10);
        Rect titleRect = GUILayoutUtility.GetRect(60, 60);
        titleRect.xMin += 80;
        titleRect.xMax -= 80;
        EditorGUI.DrawRect(titleRect, Color.springGreen);
        GUIStyle titleStyle = new GUIStyle();
        titleStyle.fontSize = 30;
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.alignment = TextAnchor.MiddleCenter;
        titleStyle.normal.textColor = Color.white;
        EditorGUI.LabelField(titleRect, "Character", titleStyle);
    }
}
