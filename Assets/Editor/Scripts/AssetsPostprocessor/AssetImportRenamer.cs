using System.IO;
using UnityEditor;
using UnityEngine;

public class AssetImportRenamer : AssetPostprocessor
{
    static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
    {
        foreach (var assetPath in importedAssets)
        {
            string extension = Path.GetExtension(assetPath).ToLower();
            if (string.Equals(extension, ".fbx"))
            {
                string fileName = Path.GetFileNameWithoutExtension(assetPath);
                if (!fileName.StartsWith("Mesh_"))
                {
                    string newName = $"Mesh_{fileName}";
                    string error = AssetDatabase.RenameAsset(assetPath, newName);
                    if (!string.IsNullOrEmpty(error))
                    {
                        Debug.LogError($"Failed to rename {assetPath}: {error}");
                    }
                }
            }
        }
    }
}
