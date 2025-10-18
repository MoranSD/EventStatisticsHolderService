using EventStatisticsHolderService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventStatisticsHolderService.DataAccess.Configurations
{
    public class GameSessionConfiguration : IEntityTypeConfiguration<GameSessionEntity>
    {
        public void Configure(EntityTypeBuilder<GameSessionEntity> builder)
        {
            builder.HasKey(s => s.Id);

            builder
                .HasOne(s => s.GameProject)
                .WithMany(p => p.GameSessions)
                .HasForeignKey(s => s.GameProjectId);

            builder
                .HasMany(s => s.GameEvents)
                .WithOne(e => e.GameSession)
                .HasForeignKey(e => e.GameSessionId);
        }
    }
}
