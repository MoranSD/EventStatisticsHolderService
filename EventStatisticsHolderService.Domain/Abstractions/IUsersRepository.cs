using EventStatisticsHolderService.Domain.Models;

namespace EventStatisticsHolderService.Domain.Abstractions
{
    public interface IUsersRepository
    {
        Task<User?> Get(Guid id);
    }
}
