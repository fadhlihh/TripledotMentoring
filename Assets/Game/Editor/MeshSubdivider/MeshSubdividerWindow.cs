using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MeshSubdividerWindow : EditorWindow
{
    [SerializeField]
    private int[] _xSplits = new int[] { 0, 1 };
    [SerializeField]
    private int[] _ySplits = new int[] { 0, 1 };

    private SerializedObject _serializedObj;
    private SerializedProperty _xSplitsProp;
    private SerializedProperty _ySplitsProp;

    private Mesh _generatedMesh;

    [MenuItem("Tools/Mesh Subdivider")]
    public static void ShowWindow()
    {
        GetWindow<MeshSubdividerWindow>();
    }

    private void OnEnable()
    {
        _serializedObj = new SerializedObject(this);
        _xSplitsProp = _serializedObj.FindProperty("_xSplits");
        _ySplitsProp = _serializedObj.FindProperty("_ySplits");
    }

    private void OnGUI()
    {
        _serializedObj.Update();

        if (Selection.activeGameObject == null)
        {
            EditorGUILayout.HelpBox("No object selected to subdivide!", MessageType.Error);
        }

        GUILayout.Label("Mesh Subdivider");

        if (_xSplits.Length < 2 || _ySplits.Length < 2)
        {
            EditorGUILayout.HelpBox("xSplits and ySplits need at least 2 values.", MessageType.Error);
        }


        EditorGUILayout.PropertyField(_xSplitsProp, true);
        EditorGUILayout.PropertyField(_ySplitsProp, true);

        _serializedObj.ApplyModifiedProperties();


        if (GUILayout.Button("Subdivide Selected Mesh"))
        {
            SubdivideAndReplaceMesh();
        }

        GUILayout.Space(10);

        if (GUILayout.Button("Save Mesh as Asset"))
        {
            SaveMeshAsAsset();
        }
    }

    private void SubdivideAndReplaceMesh()
    {
        if (_xSplits.Length < 2 || _ySplits.Length < 2)
        {
            Debug.LogError("xSplits and ySplits need at least 2 values!");
            return;
        }

        if (Selection.activeGameObject == null)
        {
            Debug.LogError("Please select object to subdivide!");
            return;
        }

        Mesh mesh = new Mesh();

        List<Vector3> vertices = new List<Vector3>();
        List<Vector2> uv = new List<Vector2>();
        List<int> triangles = new List<int>();

        float totalWidth = _xSplits[_xSplits.Length - 1];
        float totalHeight = _ySplits[_ySplits.Length - 1];

        for (int y = 0; y < _ySplits.Length; y++)
        {
            for (int x = 0; x < _xSplits.Length; x++)
            {
                float xPosition = (float)_xSplits[x] / totalWidth;
                float yPosition = (float)_ySplits[y] / totalHeight;

                vertices.Add(new Vector3(xPosition, yPosition, 0));
                uv.Add(new Vector2(xPosition, yPosition));
            }
        }

        int xCount = _xSplits.Length;
        for (int y = 0; y < _ySplits.Length - 1; y++)
        {
            for (int x = 0; x < _xSplits.Length - 1; x++)
            {
                int v0 = y * xCount + x;
                int v1 = v0 + 1;
                int v2 = v0 + xCount;
                int v3 = v2 + 1;

                triangles.Add(v0);
                triangles.Add(v2);
                triangles.Add(v1);

                triangles.Add(v1);
                triangles.Add(v2);
                triangles.Add(v3);
            }
        }
        mesh.SetVertices(vertices);
        mesh.SetUVs(0, uv);
        mesh.SetTriangles(triangles, 0);
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        _generatedMesh = mesh;

        if (Selection.activeGameObject != null)
        {
            _generatedMesh.name = $"{Selection.activeGameObject.name}_Subdivide";
            MeshFilter meshFilter = Selection.activeGameObject.GetComponent<MeshFilter>();
            if (meshFilter != null)
            {
                meshFilter.sharedMesh = _generatedMesh;
            }
            MeshCollider meshCollider = Selection.activeGameObject.GetComponent<MeshCollider>();
            if (meshCollider != null)
            {
                meshCollider.sharedMesh = _generatedMesh;
            }
        }

        Debug.Log("Mesh generated and assigned!");
    }

    private void SaveMeshAsAsset()
    {
        if (_generatedMesh == null)
        {
            Debug.LogError("No generated mesh to save!");
            return;
        }

        string path = EditorUtility.SaveFilePanelInProject(
            "Save Mesh Asset",
            _generatedMesh.name,
            "asset",
            "Choose file location to save the mesh"
        );

        if (string.IsNullOrEmpty(path))
            return; // user cancel

        AssetDatabase.CreateAsset(Object.Instantiate(_generatedMesh), path);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log($"Mesh saved at {path}");
    }
}
