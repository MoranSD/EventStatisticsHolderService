using EventStatisticsHolderService.DataAccess.Configurations;
using EventStatisticsHolderService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EventStatisticsHolderService.DataAccess
{
    public class GameEventsDbContext(DbContextOptions<GameEventsDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<GameProject> GameProjects { get; set; }
        public DbSet<GameSession> GameSessions { get; set; }
        public DbSet<GameEvent> GameEvents { get; set; }

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
