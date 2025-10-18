namespace EventStatisticsHolderService.Domain.Models
{
    public class GameEvent
    {
        public Guid Id { get; }
        public Guid GameSessionId { get; }
        public string Name { get; }
        public string Content { get; }
        public DateTime CreateDate { get; }

        public GameEvent(Guid id, Guid gameSessionId, string name, string content, DateTime createDate)
        {
            Id = id;
            GameSessionId = gameSessionId;
            Name = name;
            Content = content;
            CreateDate = createDate;
        }
    }
}
