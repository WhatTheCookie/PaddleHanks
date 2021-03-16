using PaddleHanks.Attributes.Script;
using UnityEngine;

namespace PaddleHanks.GameController.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Singleton that controls all game values
    /// </summary>
    public class GameValues : MonoBehaviour
    {
        public static GameValues Instance;
        public PlayerAttributesController attributes;
        
        private void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
}