using StepGameAPI.Dto;
using StepGameAPI.Entities;
using StepGameAPI.Models;

namespace StepGameAPI
{
    public static class Extensions
    {
        public static PlayerDto AsDto(this Player player)
        {
            return new PlayerDto 
            {   Id = player.Id, 
                Name = player.Name
            };

        }

        public static PlayerGameStateDto AsDto(this PlayerGameState playerGameState)
        {
            return new PlayerGameStateDto
            {
                Id = playerGameState.Id,
                TurnMade = playerGameState.TurnMade,
                Score = playerGameState.Score,
                IsInGame = playerGameState.IsInGame
            };

        }
    }
}
