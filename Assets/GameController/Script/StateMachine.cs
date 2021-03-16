using System;
using UnityEngine;

namespace PaddleHanks.GameController.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// State machine to control the entire game
    /// </summary>
    public class StateMachine : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        public void SetState(GameState gameState)
        {
            StartCoroutine(gameState.Start());
        }
    }
}
