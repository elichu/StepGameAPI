using StepGameAPI.Models;

namespace StepGameAPI.Entities
{
    public class GameState
    {
        private Player Player1;
        private Player Player2;

        private PlayerGameState Player1State;
        private PlayerGameState Player2State;

        public int Turns { get; set; }
        public int TurnsLeft { get; set; }

        public GameState()
        {
            Player1 = new Player();
            Player2 = new Player();

            Player1State = new PlayerGameState(Player1);
            Player2State = new PlayerGameState(Player2);
        }
        public Player GetWinner()
        {
            return Player1State.Score > Player2State.Score ? Player1 : Player2;
        }


    }
}
