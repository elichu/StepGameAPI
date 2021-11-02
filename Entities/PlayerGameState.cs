using StepGameAPI.Models;

namespace StepGameAPI.Entities
{
    public class PlayerGameState
    {
        public int Id { get; set; }
        public Player? player;
        public bool TurnMade { get; set; }
        public int Score { get; set; }
        public bool IsInGame { get; set; }
        public MoveAction MoveAction { get; set; }
        public MoveElement LastMoveAction { get; set; }
        public PlayerGameState() { }
        public PlayerGameState(Player player)
        {
            this.player = player;
            this.MoveAction = new MoveAction(this);
        }
        public void MadeTurn()
        {
            TurnMade = !TurnMade;
        }
        public void AddScore(int points)
        {
            Score += points;
        }

        //shoudl GameState add the enemy instead
        //is the enemy relative to the player or game?
        public void SetEnemy(MoveElement moveElement, PlayerGameState enemyState)
        {
            MoveAction.SetEnemy(enemyState);
        }
        public void Move(MoveElement moveElement)
        {
            MoveAction.Move(moveElement);
            LastMoveAction = moveElement;
        }

    }
}
