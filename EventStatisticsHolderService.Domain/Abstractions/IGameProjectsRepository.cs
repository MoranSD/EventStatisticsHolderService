using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameProjectsRepository
    {
        Task Create(GameProject gameProject);
        Task<List<GameProject>> GetAll(Guid userId);
        Task Update(Guid id, string name);
        Task Delete(Guid id);
    }
}
