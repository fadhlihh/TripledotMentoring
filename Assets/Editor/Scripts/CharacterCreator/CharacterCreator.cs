using UnityEditor;
using UnityEngine;

public class CharacterCreator
{
    [MenuItem("GameObject/Character/My Character", priority = 7)]
    public static void CreateCharacter()
    {
        GameObject obj = new GameObject("Character");
        Undo.RegisterCreatedObjectUndo(obj, "Create Character");
        obj.AddComponent<Character>();
        Selection.activeGameObject = obj;
    }
}
