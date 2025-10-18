namespace EventStatisticsHolderService.DataAccess.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public ICollection<GameProjectEntity> GameProjects { get; set; } = [];
    }
}
