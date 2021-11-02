using Microsoft.AspNetCore.Mvc;
using StepGameAPI.Dto;
using StepGameAPI.Models;
using StepGameAPI.Repos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StepGameAPI.Controllers
{

   // [Route("api/[controller]")]
    [Route("players")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly GameRepository repository;

        public PlayersController(GameRepository repository)
        {
            this.repository = repository;
        }
        // GET /players
        [HttpGet]
        public IEnumerable<PlayerDto> GetPlayers()
        {
            var players = repository.GetPlayers().Select(item => item.AsDto());
            return players;
        }

        // GET /players/{id}
        [HttpGet("{id}")]
        public ActionResult<PlayerDto> GetPlayer(int id)
        {
            var players = repository.GetPlayer(id);

            if (players is null)
            {
                return NotFound();
            }

            return players.AsDto();
        }

        // POST /players
        [HttpPost]
        public ActionResult<PlayerDto> CreatePlayer(CreatePlayerDto playerDto)
        {
            Player player = new Player()
            {
                Id = playerDto.Id,
                Name = playerDto.Name
            };

            repository.CreatePlayer(player);
            return CreatedAtAction(nameof(GetPlayer), new {Id = player.Id}, player.AsDto());
        }

        // PUT /items/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePlayer(int id, UpdatePlayerDto playerDto)
        {
            var existingPlayer = repository.GetPlayer(id);

            if (existingPlayer is null)
            {
                return NotFound();
            }

            Player updatePlayer = existingPlayer with
            {
                Name = playerDto.Name
            };

            repository.UpdatePlayer(updatePlayer);

            return NoContent();
        }

    }
}
