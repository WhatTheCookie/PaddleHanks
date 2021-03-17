using System;
using System.Collections.Generic;
using UnityEngine;

namespace PaddleHanks.WeightedRandom.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// Abstract class for all weighting holders, add this to your scriptable object to have a list of weighted objects
    /// </summary>
    public abstract class Weighting<T> : ScriptableObject where T : WeightedObject
    {
        [SerializeField] public List<T> objects = new List<T>();
        [NonSerialized] public float totalWeight;

        /// <summary>
        /// Get the total weight of all objects
        /// </summary>
        public void OnEnable()
        {
            var objectsTotal = 0f;
            foreach (var items in objects)
            {
                objectsTotal += items.weight;
                items.cumulative = objectsTotal;
            }
            totalWeight = objectsTotal;
            SecondEnable();
        }

        protected virtual void SecondEnable()
        {
            //break;
        }
    }
}
