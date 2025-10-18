namespace EventStatisticsHolderService.Domain.Models
{
    public class GameProject
    {
        public Guid Id { get; }
        public Guid UserId { get; }
        public string Name { get;}
        public List<Guid> GameSessionIds { get; }

        public GameProject(Guid id, Guid userId, string name, List<Guid> gameSessionIds)
        {
            Id = id;
            UserId = userId;
            Name = name;
            GameSessionIds = gameSessionIds;
        }
    }
}
