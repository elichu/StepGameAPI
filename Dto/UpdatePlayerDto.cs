using System.ComponentModel.DataAnnotations;

namespace StepGameAPI.Dto
{
    public record UpdatePlayerDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
