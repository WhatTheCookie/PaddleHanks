using UnityEngine;

namespace PaddleHanks.Items.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Base class for all food.
    /// </summary>
    [CreateAssetMenu(fileName = "Food",menuName = "ScriptableObjects/Items/Food")]
    public class Food : Item
    {
        [Tooltip("How much hunger the food should replenish.")]
        public float amountOfHungerToReplenish;
    }
}