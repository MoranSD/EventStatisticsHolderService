namespace EventStatisticsHolderService.Domain.Models
{
    public class User
    {
        public Guid Id { get; }
        public List<Guid> GameProjectIds { get; }

        public User(Guid id, List<Guid> gameProjectIds)
        {
            Id = id;
            GameProjectIds = gameProjectIds;
        }
    }
}
