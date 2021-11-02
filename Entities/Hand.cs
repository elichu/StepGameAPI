using StepGameAPI.Entities;

namespace StepGameAPI.Models
{
    public class Hand
    {
        private List<MoveElement> PlayerHand = new();

        //hard coded for now, assume non null
        private int[] MoveSettings = { 6, 3, 2, 4 };
        public Guid Id { get; set; }
       
        
        public List<MoveElement> CreateHand()
        {
            for (int i = 0; i < MoveSettings.Length; i++)
            {
                for (int j = 0; j < MoveSettings[i]; j++)
                {
                    MoveType move = (MoveType)Enum.GetValues(typeof(MoveType)).GetValue(i);
                    MoveElement moveElement = new MoveElement();

                    moveElement.MoveName = move.ToString();
                    moveElement.Move = move;
                    moveElement.Value = 0;

                    PlayerHand.Add(moveElement);
                }
            }
            return PlayerHand;
        }
    }
}
