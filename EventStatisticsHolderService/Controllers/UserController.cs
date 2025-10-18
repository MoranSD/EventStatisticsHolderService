using EventStatisticsHolderService.Domain.Abstractions;
using EventStatisticsHolderService.Domain.Models;
using EventStatisticsHolderService.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EventStatisticsHolderService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGameProjectsRepository gameProjectRepository;

        public UserController(IGameProjectsRepository gameProjectRepository)
        {
            this.gameProjectRepository = gameProjectRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGameProject([FromBody] CreateGameProjectDto createDto)
        {
            if (createDto == null)
                return BadRequest("Create data is empty");

            var gameProject = new GameProject()
            {
                Id = Guid.NewGuid(),
                Name = createDto.name,
                GameSessions = []
            };

            await gameProjectRepository.Create(gameProject);
            return Ok(gameProject.Id);
        }
    }
}
