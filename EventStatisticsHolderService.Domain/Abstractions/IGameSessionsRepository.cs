using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameSessionsRepository
    {
        Task Create(GameSession gameSession);
        Task<List<GameSession>> GetAll(Guid gameProjectId);
        Task Update(Guid id, DateTime endTime);
        Task Delete(Guid id);
    }
}
