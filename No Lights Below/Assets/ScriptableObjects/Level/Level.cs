using ScriptableObjects.SerializableClass;
using UnityEngine;

namespace ScriptableObjects
{
    
    [CreateAssetMenu(fileName = "Level", menuName = "Scriptable Objects/Level")]
    public class Level : ScriptableObject
    {
        [Header("Base Information")]
        public string levelName;  // Renamed to avoid conflict with Unity's name property
        public string description;
    
        [Tooltip("The higher the rarity, the more often it can be chosen as the active level. Setting to 0 prevents it from being spawned")]
        public int rarityLevel;

        [Tooltip("Can the level be chosen by the default level system")]
        public bool canBeChosen = true;

        [Header("Monster")]
        [Tooltip("Each monster spawn will chip away at the maximum strength. The higher this number, the more monsters there will be")]
        public int maximumStrength;  // Fixed typo

        [Tooltip("This monster will only spawn once and in the boss room only")]
        public Monster bossMonster;
    
        [Tooltip("Manually define each monster spawn with relevant info")]
        
        public MonsterPair[] monsterPairs;

        [Header("LootTable")]
        [Tooltip("Define loot-related data here")]
        public int lootTableId;  // Renamed placeholder field for clarity
    }


}
