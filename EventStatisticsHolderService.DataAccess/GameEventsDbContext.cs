using EventStatisticsHolderService.DataAccess.Configurations;
using EventStatisticsHolderService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventStatisticsHolderService.DataAccess
{
    public class GameEventsDbContext(DbContextOptions<GameEventsDbContext> options) : DbContext(options)
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<GameProjectEntity> GameProjects { get; set; }
        public DbSet<GameSessionEntity> GameSessions { get; set; }
        public DbSet<GameEventEntity> GameEvents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new GameProjectConfiguration());
            modelBuilder.ApplyConfiguration(new GameSessionConfiguration());
            modelBuilder.ApplyConfiguration(new GameEventConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
