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
                .ToListAsync();
        }

        public async Task<List<GameEvent>> Get(Guid sessionId, string name)
        {
            return await GetBySession(sessionId)
                .Where(x => x.Name.Contains(name))
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task DeleteAll(Guid sessionId)
        {
            await GetBySession(sessionId)
                .ExecuteDeleteAsync();
        }

        public async Task DeleteAll(Guid sessionId, string name)
        {
            await GetBySession(sessionId)
                .Where(x => x.Name.Contains(name))
                .ExecuteDeleteAsync();
        }

        private IQueryable<GameEvent> GetBySession(Guid sessionId)
        {
            return dbContext.GameEvents.Where(x => x.GameSessionId == sessionId);
        }
    }
}
