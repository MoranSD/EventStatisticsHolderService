using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameEventsRepository
    {
        Task Create(GameEvent gameEvent);
        Task<List<GameEvent>> GetAll(Guid sessionId);
        Task DeleteAll(Guid sessionId);
    }
}
