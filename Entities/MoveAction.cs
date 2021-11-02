using StepGameAPI.Models;

namespace StepGameAPI.Entities
{
    public class MoveAction
    {
        public GameState GameState { get; set; }
        public PlayerGameState PlayerState { get; set; }
        public PlayerGameState EnemyState { get; set; }
        public MoveAction(PlayerGameState playerState)
        {
            this.PlayerState = playerState;
        }
        public MoveAction(GameState gameState, PlayerGameState playerState)
        {
            this.GameState = gameState;
            this.PlayerState = playerState;       
        }
        public void SetEnemy(PlayerGameState enemyState)
        {
            this.EnemyState = enemyState;
        }
        private void MoveStep1()
        {
            PlayerState.AddScore(1);
        }
        private void MoveStep2()
        {
            PlayerState.AddScore(2);
        }

        private void Attack1(PlayerGameState playerState)
        {
            EnemyState.AddScore(-1);
        }
        private void Defend1(PlayerGameState playerState)
        {
            playerState.AddScore(0);
        }
        public bool Move(MoveElement moveElement)
        {
            switch (moveElement.Move)
            {
                case MoveType.Step1:
                case MoveType.Step2:
                case MoveType.Attack1:
                case MoveType.Defend1:

            default:
                return false;
                break;
            }
                return true;
        }
    }
}
