using System;
using PaddleHanks.WeightedRandom.Script;

namespace PaddleHanks.IslandEvents.Script
{
    [Serializable]
    public class WeightedIslandEvent : WeightedObject
    {
        public IslandEvent islandEvent = new IslandEvent();
    }

}