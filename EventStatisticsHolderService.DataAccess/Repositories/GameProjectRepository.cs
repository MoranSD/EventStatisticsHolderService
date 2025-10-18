using EventStatisticsHolderService.DataAccess.Entities;
using EventStatisticsHolderService.Domain.Abstractions;
using EventStatisticsHolderService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EventStatisticsHolderService.DataAccess.Repositories
{
    public class GameProjectRepository : IGameProjectRepository
    {
        private readonly GameEventsDbContext dbContext;

        public GameProjectRepository(GameEventsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(GameProject gameProject)
        {
            var gameProjectEntity = new GameProjectEntity()
            {
                Id = gameProject.Id,
                OwnerId = gameProject.Owner.Id,
                Name = gameProject.Name
            };

            await dbContext.GameProjects.AddAsync(gameProjectEntity);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<GameProject>> GetAll()
        {
            return await dbContext.GameProjects.ToListAsync();
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
