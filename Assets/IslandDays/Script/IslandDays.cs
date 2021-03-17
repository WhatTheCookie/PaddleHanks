using System;
using System.Collections.Generic;
using System.Linq;
using PaddleHanks.IslandEvents.Script;
using UnityEngine;

namespace PaddleHanks.IslandDays.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// class for all island days, which holds the events that will happen that day
    /// </summary>
    [CreateAssetMenu(fileName = "IslandDay", menuName = "ScriptableObjects/IslandDay/IslandDay")]
    public class IslandDay : ScriptableObject
    {
        public int dayNumber;
        public IEnumerable<IIslandEvents> daysEvents = new List<IIslandEvents>();

        private void OnEnable()
        {
            var myEvents = daysEvents.ToList();
            Debug.Log(myEvents[0].EventToOccur);
        }
    }
}