﻿using System.Linq;
using UnityEngine;

namespace PaddleHanks.WeightedRandom.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// Abstract class that will get a random weighted object
    /// </summary>
    /// <typeparam name="T">class that inherits from WeightedObject</typeparam>
    public class RandomWeighting<T> where T : WeightedObject
    {
        internal T GetRandomObject(Weighting<T> weightedObject)
        {
            var randomRange = (Random.Range(0f, weightedObject.totalWeight));
            return weightedObject.objects.Last(gottenTip => gottenTip.cumulative - gottenTip.weight <= randomRange);
        }
    }
}
