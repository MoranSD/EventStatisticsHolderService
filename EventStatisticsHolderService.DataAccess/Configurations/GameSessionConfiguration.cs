using EventStatisticsHolderService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventStatisticsHolderService.DataAccess.Configurations
{
    public class GameSessionConfiguration : IEntityTypeConfiguration<GameSession>
    {
        public void Configure(EntityTypeBuilder<GameSession> builder)
        {
            builder.HasKey(s => s.Id);

            builder
                .HasOne(s => s.GameProject)
                .WithMany(p => p.GameSessions)
                .HasForeignKey(s => s.GameProjectId);

            builder.Property(s => s.StartTime).IsRequired();

            builder
                .HasMany(s => s.GameEvents)
                .WithOne(e => e.GameSession)
                .HasForeignKey(e => e.GameSessionId);
        }
    }
}
