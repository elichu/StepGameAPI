namespace StepGameAPI.Models
{
    public record Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //all players have the same deck/hand
        public Hand Hand = new Hand();

    }
}
