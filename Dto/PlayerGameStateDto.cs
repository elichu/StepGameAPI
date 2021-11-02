using StepGameAPI.Entities;

namespace StepGameAPI.Dto
{
    public record PlayerGameStateDto
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public MoveElement LastMoveAction { get; set; }
        public bool IsInGame { get; set; }
        public bool TurnMade { get; set; }
    }
}
