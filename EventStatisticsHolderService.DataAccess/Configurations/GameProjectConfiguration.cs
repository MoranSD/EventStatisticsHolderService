using EventStatisticsHolderService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventStatisticsHolderService.DataAccess.Configurations
{
    public class GameProjectConfiguration : IEntityTypeConfiguration<GameProjectEntity>
    {
        private const int MAX_EVENT_NAME_LENGTH = 24;

        public void Configure(EntityTypeBuilder<GameProjectEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .HasOne(p => p.Owner)
                .WithMany(u => u.GameProjects)
                .HasForeignKey(p => p.OwnerId);

            builder
                .Property(p => p.Name)
                .HasMaxLength(MAX_EVENT_NAME_LENGTH)
                .IsRequired();

            builder
                .HasMany(p => p.GameSessions)
                .WithOne(s => s.GameProject)
                .HasForeignKey(s => s.GameProjectId);
        }
    }
}
