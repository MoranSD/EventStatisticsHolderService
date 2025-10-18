namespace EventStatisticsHolderService.Domain.Models
{
    public class GameProject
    {
        public Guid Id { get; }
        public User Owner { get; }
        public string Name { get;}
        public ICollection<GameSession> GameSessions { get; }

        public GameProject(Guid id, User owner, string name, ICollection<GameSession> gameSessions)
        {
            Id = id;
            Owner = owner;
            Name = name;
            GameSessions = gameSessions;
        }
    }
}
