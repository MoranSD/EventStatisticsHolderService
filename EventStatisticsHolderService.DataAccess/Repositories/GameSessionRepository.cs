using EventStatisticsHolderService.DataAccess.Entities;
using EventStatisticsHolderService.Domain.Abstractions;
using EventStatisticsHolderService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EventStatisticsHolderService.DataAccess.Repositories
{
    public class GameSessionRepository : IGameSessionsRepository
    {
        private readonly GameEventsDbContext dbContext;

        public GameSessionRepository(GameEventsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task Create(GameSession gameSession)
        {
            var gameSessionsEntity = new GameSessionEntity()
            {
                Id = gameSession.Id,
                GameProjectId = gameSession.GameProjectId,
                StartTime = gameSession.StartTime,
                EndTime = gameSession.EndTime,
                GameEvents = []
            };

            await dbContext.GameSessions.AddAsync(gameSessionsEntity);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var gameSessionEntity = await dbContext.GameSessions.FirstOrDefaultAsync(s => s.Id == id);

            if (gameSessionEntity != null)
            {
                dbContext.GameSessions.Remove(gameSessionEntity);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<GameSession>> GetAll(Guid gameProjectId)
        {
            return await dbContext.GameSessions
                .Where(x => x.GameProjectId == gameProjectId)
                .AsNoTracking()
                .Select(x => new GameSession(
                    x.Id,
                    x.GameProjectId,
                    x.StartTime,
                    x.EndTime,
                    x.GameEvents.Select(e => e.Id).ToList()
                ))
                .ToListAsync();
        }


        public async Task Update(Guid id, DateTime endTime)
        {
            var gameSessionEntity = await dbContext.GameSessions.FirstOrDefaultAsync(s => s.Id == id);

            if (gameSessionEntity != null)
            {
                gameSessionEntity.EndTime = endTime;
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
