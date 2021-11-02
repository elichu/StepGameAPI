using StepGameAPI.Entities;
using StepGameAPI.Models;

namespace StepGameAPI.Repos
{
    public class GameRepository
    {

        private readonly List<PlayerGameState> playerGameStates = new()
        {
            new PlayerGameState
            {
                Id = 1,
                TurnMade = true,
                Score = 0,
                IsInGame = true
            }
        };

        private readonly List<Player> players = new()
        {
            new Player { Id = 1, Name = "Player1"},
            new Player { Id = 2, Name = "Player2" }
        };

        public IEnumerable<Player> GetPlayers()
        {
            return players;
        }
        public Player GetPlayer(int id)
        {
            return players.Where(player => player.Id == id).SingleOrDefault();
        }

        public void CreatePlayer(Player player)
        {
            players.Add(player);
        }
        public void UpdatePlayer(Player player)
        {
            var index = players.FindIndex(player => player.Id == player.Id);
            players[index] = player;
        }

        public int GetScore(PlayerGameState playerGameState)
        {
            return playerGameState.Score;
        }

        //public void UpdateTurnsRemaining(int value)
        //{
        //    gameState.TurnsLeft = value;

        //}
        //public int GetTurnsRemaining()
        //{
        //    return gameState.TurnsLeft;

        //}
        public PlayerGameState GetPlayerGameState(int id)
        {
            return playerGameStates.Where(playerGameState => playerGameState.Id == id).SingleOrDefault();
        }
    }
}
