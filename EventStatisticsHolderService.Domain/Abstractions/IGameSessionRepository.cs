using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameSessionRepository
    {
        Task<Guid> Create(GameSession gameSession);
        Task<List<GameSession>> GetAll();
        Task<GameSession> Get(Guid id);
        Task<Guid> SetEndTime(Guid id, DateTime endTime);
        Task<Guid> Delete(Guid id);
    }
}
