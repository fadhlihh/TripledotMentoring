using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class AssetImportGrouper : AssetPostprocessor
{
    static void OnPostprocessAllAssets
    (
        string[] importedAssets,
        string[] deletedAssets,
        string[] movedAssets,
        string[] movedFromAssetPaths
    )
    {
        Dictionary<string, List<string>> _groupAssets = new Dictionary<string, List<string>>();
        foreach (string path in importedAssets)
        {
            string extension = Path.GetExtension(path).ToLower();
            if (string.Equals(extension, ".fbx"))
            {
                string fileName = Path.GetFileNameWithoutExtension(path);
                int dashIndex = fileName.IndexOf("-");

                string prefix = fileName;

                if (dashIndex > 0 && dashIndex < fileName.Length)
                {
                    prefix = fileName.Substring(0, dashIndex);
                }

                if (!_groupAssets.ContainsKey(prefix))
                {
                    _groupAssets[prefix] = new List<string>();
                }

                _groupAssets[prefix].Add(path);
            }

        }

        foreach (var asset in _groupAssets)
        {
            string groupName = asset.Key;
            List<string> paths = asset.Value;

            if (paths.Count > 1)
            {
                GameObject groupObject = new GameObject(groupName);

                foreach (string path in paths)
                {
                    GameObject fbxObject = AssetDatabase.LoadAssetAtPath<GameObject>(path);
                    if (fbxObject != null)
                    {
                        GameObject childObject = PrefabUtility.InstantiatePrefab(fbxObject) as GameObject;
                        string childName = Path.GetFileNameWithoutExtension(path).Replace(groupName + "-", "");
                        childObject.name = childName;
                        childObject.transform.SetParent(groupObject.transform, false);
                    }
                }
                string savePath = "Assets/Prefabs/" + groupName + ".prefab";
                Directory.CreateDirectory(Path.GetDirectoryName(savePath));
                PrefabUtility.SaveAsPrefabAsset(groupObject, savePath);

                Object.DestroyImmediate(groupObject);
            }
        }
    }
}
