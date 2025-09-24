using UnityEditor;
using UnityEngine;

public class VertexCounter : EditorWindow
{
    private enum TargetPlatform
    {
        MobileMidRange,
        PCMidRange
    }

    private TargetPlatform _targetPlatform;
    private float totalVertices;
    private float totalTris;
    private float vertexLimit = 600;
    private float trisLimit = 300;

    [MenuItem("Tools/Vertex Counter")]
    public static void ShowWindow()
    {
        VertexCounter window = GetWindow<VertexCounter>();
        window.Show();
    }

    private void OnEnable()
    {
        Selection.selectionChanged += CalculateVertices;
        CalculateVertices();
    }

    private void OnDisable()
    {
        Selection.selectionChanged -= CalculateVertices;
    }

    private void CalculateVertices()
    {
        totalVertices = 0;
        totalTris = 0;
        GameObject[] selectedGameObject = Selection.gameObjects;
        foreach (GameObject obj in selectedGameObject)
        {
            MeshFilter[] meshFilters = obj.GetComponentsInChildren<MeshFilter>();
            foreach (MeshFilter meshFilter in meshFilters)
            {
                Mesh mesh = meshFilter.sharedMesh;
                if (mesh)
                {
                    totalVertices += mesh.vertexCount;
                    totalTris += mesh.triangles.Length / 3;
                }
            }

            SkinnedMeshRenderer[] skinnedMeshRenderers = obj.GetComponentsInChildren<SkinnedMeshRenderer>();
            foreach (SkinnedMeshRenderer skinnedMeshRenderer in skinnedMeshRenderers)
            {
                Mesh mesh = skinnedMeshRenderer.sharedMesh;
                if (mesh)
                {
                    totalVertices += mesh.vertexCount;
                    totalTris += mesh.triangles.Length / 3;
                }
            }
        }
        Repaint();
    }

    private void OnGUI()
    {
        switch (_targetPlatform)
        {
            case TargetPlatform.MobileMidRange:
                vertexLimit = 600;
                trisLimit = 300;
                break;
            case TargetPlatform.PCMidRange:
                vertexLimit = 18000;
                trisLimit = 8000;
                break;
            default:
                vertexLimit = 600;
                trisLimit = 300;
                break;
        }
        EditorGUILayout.Space(20);
        DrawTitle("Vertex Counter", 50, 50, Color.white);
        EditorGUILayout.Space(20);
        EditorGUIUtility.labelWidth = 100;
        _targetPlatform = (TargetPlatform)EditorGUILayout.EnumPopup("Target Platform", _targetPlatform);
        EditorGUILayout.Space(20);
        DrawProgressBar("Vertices", totalVertices / 1000, vertexLimit, 30, 10);
        DrawProgressBar("Triangles", totalTris / 1000, trisLimit, 30, 10);
    }

    private void DrawTitle(string title, float height, float sideSpacing, Color backgroundColor)
    {
        Rect titleRect = GUILayoutUtility.GetRect(height, height);
        titleRect.xMin += sideSpacing;
        titleRect.xMax -= sideSpacing;
        EditorGUI.DrawRect(titleRect, backgroundColor);
        GUIStyle titleStyle = new GUIStyle();
        titleStyle.fontSize = 30;
        titleStyle.fontStyle = FontStyle.Bold;
        titleStyle.alignment = TextAnchor.MiddleCenter;
        titleStyle.normal.textColor = Color.black;
        EditorGUI.LabelField(titleRect, title, titleStyle);
    }

    private void DrawProgressBar(string label, float value, float limitValue, float height, float sideSpacing)
    {
        EditorGUILayout.LabelField(label, EditorStyles.boldLabel);
        Rect backgroundRect = GUILayoutUtility.GetRect(height, height);
        backgroundRect.xMin += sideSpacing;
        backgroundRect.xMax -= sideSpacing;
        EditorGUI.DrawRect(backgroundRect, Color.black);
        Rect fillRect = backgroundRect;
        fillRect.width *= (value / limitValue);
        EditorGUI.DrawRect(fillRect, Color.springGreen);
        GUIStyle labelStyle = new GUIStyle();
        labelStyle.fontSize = 18;
        labelStyle.fontStyle = FontStyle.Bold;
        labelStyle.alignment = TextAnchor.MiddleCenter;
        labelStyle.normal.textColor = Color.white;
        EditorGUI.LabelField(backgroundRect, $"{value}k/{limitValue}k", labelStyle);
    }
}
