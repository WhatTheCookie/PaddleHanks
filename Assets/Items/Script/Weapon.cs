using UnityEngine;

namespace PaddleHanks.Items.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Class for all weapons
    /// </summary>
    [CreateAssetMenu(fileName = "Weapon",menuName = "ScriptableObjects/Items/Weapon")]
    public class Weapon : Item
    {
        [Tooltip("The damage the item should give enemies.")]
        public float damage;
    }
}
