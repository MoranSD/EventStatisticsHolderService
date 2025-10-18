using EventStatisticsHolderService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventStatisticsHolderService.DataAccess.Configurations
{
    public class GameEventConfiguration : IEntityTypeConfiguration<GameEventEntity>
    {
        private const int MAX_EVENT_NAME_LENGTH = 16;

        public void Configure(EntityTypeBuilder<GameEventEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .HasOne(e => e.GameSession)
                .WithMany(s => s.GameEvents)
                .HasForeignKey(e => e.GameSessionId);

            builder
                .Property(e => e.Name)
                .HasMaxLength(MAX_EVENT_NAME_LENGTH)
                .IsRequired();
        }
    }
}
