using EventStatisticsHolderService.DataAccess.Entities;
using EventStatisticsHolderService.Domain.Abstractions;
using EventStatisticsHolderService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EventStatisticsHolderService.DataAccess.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly GameEventsDbContext dbContext;

        public UsersRepository(GameEventsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<User?> Get(Guid id)
        {
            UserEntity? userEntity = await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (userEntity != null)
            {
                return new User(userEntity.Id, userEntity.GameProjects.Select(x => x.Id).ToList());
            }
            else
            {
                return null;
            }
        }
    }
}
