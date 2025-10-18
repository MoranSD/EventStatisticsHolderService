namespace EventStatisticsHolderService.Domain.Models
{
    public class GameEvent
    {
        public Guid Id { get; }
        public GameSession GameSession { get; }
        public string Name { get; }
        public string Content { get; }
        public DateTime CreateDate { get; }

        public GameEvent(Guid id, GameSession gameSession, string name, string content, DateTime createDate)
        {
            Id = id;
            GameSession = gameSession;
            Name = name;
            Content = content;
            CreateDate = createDate;
        }
    }
}
