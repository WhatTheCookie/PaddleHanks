using System;
using System.Collections;
using PaddleHanks.Attributes.Script;

namespace PaddleHanks.GameController.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Abstract class for each GameState.
    /// </summary>
    public abstract class GameState
    {
        private StateMachine _stateMachine;
        
        protected GameState(StateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }

        /// <summary>
        /// Change state to the given state.
        /// </summary>
        /// <param name="gameState">State to change to.</param>
        /// <returns></returns>
        protected IEnumerator ChangeState(GameState gameState)
        {
            _stateMachine.SetState(gameState);
            yield break;
        }

        #region Behaviours
        public virtual IEnumerator Start()
        {
            yield break;
        }

        public virtual IEnumerator Play()
        {
            yield break;
        }

        public virtual IEnumerator End()
        {
            yield break;
        }

        #endregion
    }

    public class IslandSurvival : GameState
    {
        public IslandSurvival(StateMachine stateMachine) : base(stateMachine)
        {
        }
        
        
    }

    public class IslandSurvivalFirst : GameState
    {
        public IslandSurvivalFirst(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override IEnumerator Start()
        {
            //GameValues.Instance.attributes = new PlayerAttributes();
            yield break;
        }
    }
}