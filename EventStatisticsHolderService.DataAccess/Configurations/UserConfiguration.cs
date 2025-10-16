using EventStatisticsHolderService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventStatisticsHolderService.DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .HasMany(u => u.GameProjects)
                .WithOne(p => p.Owner)
                .HasForeignKey(p => p.OwnerId);
        }
    }
}
