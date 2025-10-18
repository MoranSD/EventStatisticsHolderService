using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameProjectsRepository
    {
        Task Create(Guid id, Guid ownerId, string name);
        Task<List<GameProject>> GetAll(Guid ownerId);
        Task Update(Guid id, string name);
        Task Delete(Guid id);
    }
}
