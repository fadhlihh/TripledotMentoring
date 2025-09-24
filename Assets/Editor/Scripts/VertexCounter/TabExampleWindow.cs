using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class TabExampleWindow : EditorWindow
{
    private int _tabIndex = 0;

    [MenuItem("Tools/Tab Example")]
    public static void ShowWindow()
    {
        TabExampleWindow window = GetWindow<TabExampleWindow>();
        window.Show();
    }

    private void OnGUI()
    {
        _tabIndex = GUILayout.Toolbar(_tabIndex, new GUIContent[]
        {
            new GUIContent("Overview"),
            new GUIContent("Details"),
            new GUIContent("Settings"),
        });

        switch (_tabIndex)
        {
            case 0:
                EditorGUILayout.LabelField("Overview Window", EditorStyles.boldLabel);
                break;
            case 1:
                EditorGUILayout.LabelField("Details Window", EditorStyles.boldLabel);
                break;
            case 2:
                EditorGUILayout.LabelField("Settings Window", EditorStyles.boldLabel);
                break;
        }
    }
}
