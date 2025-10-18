namespace EventStatisticsHolderService.Domain.Models
{
    public class GameProject
    {
        public Guid Id { get; }
        public Guid OwnerId { get; }
        public string Name { get;}
        public List<Guid> GameSessionIds { get; }

        public GameProject(Guid id, Guid ownerId, string name, List<Guid> gameSessionIds)
        {
            Id = id;
            OwnerId = ownerId;
            Name = name;
            GameSessionIds = gameSessionIds;
        }
    }
}
