using EventStatisticsHolderService.DataAccess.Entities;
using EventStatisticsHolderService.Domain.Abstractions;
using EventStatisticsHolderService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EventStatisticsHolderService.DataAccess.Repositories
{
    public class GameProjectRepository : IGameProjectsRepository
    {
        private readonly GameEventsDbContext dbContext;

        public GameProjectRepository(GameEventsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(Guid id, Guid ownerId, string name)
        {
            var gameProjectEntity = new GameProjectEntity()
            {
                Id = id,
                OwnerId = ownerId,
                Name = name,
                GameSessions = []
            };

            await dbContext.GameProjects.AddAsync(gameProjectEntity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<GameProject>> GetAll(Guid ownerId)
        {
            return await dbContext.GameProjects
                .Where(x => x.OwnerId == ownerId)
                .AsNoTracking()
                .Select(x => new GameProject(x.Id, x.OwnerId, x.Name, x.GameSessions.Select(x => x.Id).ToList()))
                .ToListAsync();
        }

        public async Task Update(Guid id, string name)
        {
            var gameProject = await dbContext.GameProjects.FirstOrDefaultAsync(x => x.Id == id);

            if (gameProject != null)
            {
                gameProject.Name = name;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(Guid id)
        {
            var gameProject = await dbContext.GameProjects.FirstOrDefaultAsync(x => x.Id == id);

            if (gameProject != null)
            {
                dbContext.GameProjects.Remove(gameProject);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
