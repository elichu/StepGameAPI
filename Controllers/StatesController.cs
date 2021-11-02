using Microsoft.AspNetCore.Mvc;
using StepGameAPI.Dto;
using StepGameAPI.Repos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StepGameAPI.Controllers
{

   // [Route("api/[controller]")]
    [Route("states")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly GameRepository repository;

        public StatesController(GameRepository repository)
        {
            this.repository = repository;
        }

        // GET /states/{id}
        [HttpGet("{id}")]
        public ActionResult<PlayerGameStateDto> GetPlayerGameState(int id)
        {
            var playerGameState = repository.GetPlayerGameState(id);

            if (playerGameState is null)
            {
                return NotFound();
            }

            return playerGameState.AsDto();
        }
    }
}
