using ScriptableObjects;
using UnityEditor;
using UnityEngine;

public class Level_CreateMenu : Editor
{
    [MenuItem("Assets/Create/ScriptableObjects/Level")]
    public static void CreateMonsterDataWithCustomOption()
    {
        // Create a new instance of MonsterData
        Level newLevel = ScriptableObject.CreateInstance<Level>();

        // Save the created instance to a file
        AssetDatabase.CreateAsset(newLevel, "Assets/NewLevelData.asset");
        AssetDatabase.SaveAssets();

        // Select the newly created asset in the Project window
        Selection.activeObject = newLevel;
    }
}