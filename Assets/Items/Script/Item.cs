using UnityEngine;

namespace PaddleHanks.Items.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Abstract class for all items
    /// </summary>
    public abstract class Item : ScriptableObject
    {
        [Tooltip("The items name.")]
        public string itemName;
        [Tooltip("What the item should spawn in the game as.")]
        public GameObject itemPrefab;
    }
}