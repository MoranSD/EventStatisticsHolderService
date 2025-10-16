using EventStatisticsHolderService.Domain.Abstractions;
using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.DataAccess.Repositories
{
    public class GameSessionRepository : IGameSessionRepository
    {
        public Task<Guid> Create(GameSession gameSession)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GameSession> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GameSession>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Guid> SetEndTime(Guid id, DateTime endTime)
        {
            throw new NotImplementedException();
        }
    }
}
