using PaddleHanks.WeightedRandom.Script;
using UnityEngine;

namespace PaddleHanks.IslandEvents.Script
{
    [CreateAssetMenu(fileName = "IslandEventRandom", menuName = "ScriptableObjects/IslandEvents/IslandEventRandom")]
    public class IslandEventRandom : Weighting<WeightedIslandEvent>, IIslandEvents
    {
        public string EventToOccur { get; set; }
        protected override void SecondEnable()
        {
            var randomWeighting = new RandomWeighting<WeightedIslandEvent>();
            var randomObject = randomWeighting.GetRandomObject(this);
            EventToOccur = randomObject.islandEvent.textToShow;
        }

    }
}