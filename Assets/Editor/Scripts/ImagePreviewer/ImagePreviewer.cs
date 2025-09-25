using System.IO;
using UnityEditor;
using UnityEngine;

public class ImagePreviewer : EditorWindow
{
    private Texture2D _previewTexture;
    private string path;

    [MenuItem("Tools/Image Previewer")]
    public static void ShowWindow()
    {
        ImagePreviewer window = GetWindow<ImagePreviewer>();
    }

    private void OnGUI()
    {
        EditorGUILayout.BeginHorizontal();
        GUI.enabled = false;
        EditorGUILayout.TextField(path);
        GUI.enabled = true;
        GUILayout.Space(20);
        if (GUILayout.Button("Browse"))
        {
            path = EditorUtility.OpenFilePanel("Select Image", "", "png,jpg,jpeg");
            if (!string.IsNullOrEmpty(path))
            {
                LoadImage(path);
            }
        }
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space(70);

        if (_previewTexture != null)
        {
            Rect previewRect = GUILayoutUtility.GetRect(480, 480);
            previewRect.xMin += 50;
            previewRect.xMin -= 50;
            EditorGUI.DrawPreviewTexture(previewRect, _previewTexture, null, ScaleMode.ScaleToFit);
        }
    }

    public void LoadImage(string path)
    {
        byte[] fileData = File.ReadAllBytes(path);
        _previewTexture = new Texture2D(2, 2);
        _previewTexture.LoadImage(fileData);
    }
}