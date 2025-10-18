using EventStatisticsHolderService.DataAccess.Entities;
using EventStatisticsHolderService.Domain.Abstractions;
using EventStatisticsHolderService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EventStatisticsHolderService.DataAccess.Repositories
{
    public class GameEventsRepository : IGameEventsRepository
    {
        private readonly GameEventsDbContext dbContext;

        public GameEventsRepository(GameEventsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(GameEvent gameEvent)
        {
            await dbContext.AddAsync(gameEvent);
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<GameEvent>> GetAll(Guid sessionId)
        {
            return await GetBySession(sessionId)
                .AsNoTracking()
                .Select(x => new GameEvent(x.Id, x.GameSessionId, x.Name, x.Content, x.CreateDate))
                .ToListAsync();
        }

        public async Task DeleteAll(Guid sessionId)
        {
            await GetBySession(sessionId).ExecuteDeleteAsync();
        }

        private IQueryable<GameEventEntity> GetBySession(Guid sessionId)
        {
            return dbContext.GameEvents
                .Where(x => x.GameSessionId == sessionId);
        }
    }
}
