using ScriptableObjects.SerializableClass;
using UnityEngine;

namespace ScriptableObjects
{
    
    
    [CreateAssetMenu(fileName = "Monster", menuName = "Scriptable Objects/Monster")]
    public class Monster : ScriptableObject
    {
        public string name;
        public string description;
        public int strength;
        public GameObject prefab;
        
        [Header("Loot Table")]
        public LootTablePair[] lootTable;
        



    }
}