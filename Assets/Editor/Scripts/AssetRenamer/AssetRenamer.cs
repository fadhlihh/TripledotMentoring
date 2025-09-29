using UnityEngine;
using UnityEditor;
using System.IO;

public class AssetRenamer : EditorWindow
{
    private string _prefix;
    private string _find;
    private string _replace;
    private string _suffix;

    [MenuItem("Tools/Asset Renamer")]
    public static void ShowMenu()
    {
        AssetRenamer window = GetWindow<AssetRenamer>();
        window.Show();
    }

    private void OnGUI()
    {
        EditorGUILayout.LabelField("Assets Batch Renamer", EditorStyles.boldLabel);
        Object[] selectedAssets = Selection.objects;
        if (selectedAssets.Length <= 0)
        {
            EditorGUILayout.HelpBox("Please select 1 or more asset to rename", MessageType.Error);
        }
        _prefix = EditorGUILayout.TextField("Prefix", _prefix);
        _find = EditorGUILayout.TextField("Find", _find);
        _replace = EditorGUILayout.TextField("Replace", _replace);
        _suffix = EditorGUILayout.TextField("Suffix", _suffix);
        if (GUILayout.Button("Rename All"))
        {
            Rename(selectedAssets);
        }
    }

    private void Rename(Object[] objectToRename)
    {
        if (objectToRename.Length <= 0)
        {
            EditorUtility.DisplayDialog("Rename Failed", "No asset selected to be renamed. Please select 1 or more assets!", "OK");
        }
        else
        {
            foreach (Object asset in objectToRename)
            {
                string path = AssetDatabase.GetAssetPath(asset);
                string fileName = Path.GetFileNameWithoutExtension(path);
                if (!string.IsNullOrEmpty(_find))
                {
                    fileName = fileName.Replace(_find, _replace);
                }
                string newFileName = $"{_prefix}{fileName}{_suffix}";
                string error = AssetDatabase.RenameAsset(path, newFileName);
                if (!string.IsNullOrEmpty(error))
                {
                    Debug.LogError($"Failed to rename {path}: {error}");
                }
            }
            AssetDatabase.SaveAssets();
        }
    }
}
