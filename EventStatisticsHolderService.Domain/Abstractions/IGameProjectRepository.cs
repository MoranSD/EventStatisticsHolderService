using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameProjectRepository
    {
        Task Create(Guid id, Guid ownerId, string name);
        Task<List<GameProject>> GetAll();
        Task Update(Guid id, string name);
        Task Delete(Guid id);
    }
}
