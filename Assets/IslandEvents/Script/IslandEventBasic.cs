using UnityEngine;

namespace PaddleHanks.IslandEvents.Script
{
    [CreateAssetMenu(fileName = "IslandEventBasic", menuName = "ScriptableObjects/IslandEvents/IslandEventBasic")]
    public class IslandEventBasic : ScriptableObject, IIslandEvents
    {
        public string EventToOccur { get; set; }
        private readonly IslandEvent _islandEvent = new IslandEvent();
        private void OnEnable()
        {
            EventToOccur = _islandEvent.textToShow;
        }
    }
}