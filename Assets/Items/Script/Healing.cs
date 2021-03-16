using UnityEngine;

namespace PaddleHanks.Items.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Base class for all healing items.
    /// </summary>
    [CreateAssetMenu(fileName = "Healing",menuName = "ScriptableObjects/Items/Healing")]
    public class Healing : Item
    {
        [Tooltip("How much health the healing item should heal.")]
        public float amountOfHealthToHeal;
    }
}