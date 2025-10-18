using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameSessionsRepository
    {
        Task<Guid> Create(GameSession gameSession);
        Task<List<GameSession>> GetAll();
        Task<Guid> SetEndTime(Guid id, DateTime endTime);
        Task<Guid> Delete(Guid id);
    }
}
