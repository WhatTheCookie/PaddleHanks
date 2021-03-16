using UnityEngine;

namespace PaddleHanks.Items.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Base class for all liquids.
    /// </summary>
    [CreateAssetMenu(fileName = "Liquid",menuName = "ScriptableObjects/Items/Liquid")]
    public class Liquid : Item
    {
        [Tooltip("How much thirst the liquid should replenish.")]
        public float amountOfThirstToReplenish;
    }
}