using System.IO;
using UnityEditor;
using UnityEngine;

public class CharacterCreatorFromPrefab
{
    private static string _prefabFolder = "Assets/Prefabs";
    private static string _characterName = "Character";

    [MenuItem("Assets/Create/Character")]
    public static void CreateCharacterFromPrefab()
    {
        BrowseFolder();
        CreatePrefab();
    }

    public static void BrowseFolder()
    {
        string path = EditorUtility.OpenFolderPanel("Select Prefab Folder", "Assets", "");
        if (!string.IsNullOrEmpty(path))
        {
            if (path.StartsWith(Application.dataPath))
            {
                _prefabFolder = "Assets" + path.Substring(Application.dataPath.Length);
            }
            else
            {
                EditorUtility.DisplayDialog("Folder not found!", "Please select valid folder path", "OK");
            }
        }
    }

    public static void CreatePrefab()
    {
        Object[] selectedAssets = Selection.objects;

        if (selectedAssets.Length <= 0)
        {
            EditorUtility.DisplayDialog("Folder not found!", "Please select FBX asset with mesh inside", "OK");
        }

        if (!AssetDatabase.IsValidFolder(_prefabFolder))
        {
            Directory.CreateDirectory(_prefabFolder);
            AssetDatabase.Refresh();
        }

        foreach (Object asset in selectedAssets)
        {
            string assetPath = AssetDatabase.GetAssetPath(asset);
            GameObject source = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);

            if (source)
            {
                GameObject instance = Object.Instantiate(source);

                GameObject newInstance = new GameObject(_characterName);
                if (instance.GetComponent<MeshFilter>() || instance.GetComponent<SkinnedMeshRenderer>() && instance.transform.childCount <= 0)
                {
                    instance.transform.SetParent(newInstance.transform);
                }
                else
                {
                    while (instance.transform.childCount > 0)
                    {
                        instance.transform.GetChild(0).SetParent(newInstance.transform, false);
                    }
                    Object.DestroyImmediate(instance);
                }
                string localPath = $"{_prefabFolder}/{_characterName}.prefab";
                localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);
                PrefabUtility.SaveAsPrefabAsset(newInstance, localPath);
                Object.DestroyImmediate(newInstance);
            }
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        EditorUtility.DisplayDialog("Success", $"Created wrapped prefab(s) in {_prefabFolder}", "OK");
    }
}
