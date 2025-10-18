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
        public async Task<IActionResult> CreateGameProject([FromBody] CreateGameProjectDto dto)
        {
            if (dto == null)
                return BadRequest("Create data is empty");

            var gameProject = new GameProject(Guid.NewGuid(), dto.UserId, dto.Name, []);

            await gameProjectRepository.Create(gameProject);
            return Ok(gameProject.Id);
        }
    }
}
