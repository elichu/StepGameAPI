using System.ComponentModel.DataAnnotations;

namespace StepGameAPI.Dto
{
    public record CreatePlayerDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
