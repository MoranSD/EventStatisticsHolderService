using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameEventsRepository
    {
        Task Create(GameEvent gameEvent);
        Task<List<GameEvent>> GetAll(Guid sessionId);
        Task<List<GameEvent>> Get(Guid sessionId, string name);
        Task DeleteAll(Guid sessionId);
        Task DeleteAll(Guid sessionId, string name);
    }
}
