using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IGameProjectRepository
    {
        Task Create(GameProject gameProject);
        Task<List<GameProject>> GetAll();
        Task<GameProject> Get(Guid id);
        Task Update(Guid id, string name);
        Task Delete(Guid id);
    }
}
