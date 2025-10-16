namespace EventStatisticsHolderService.Domain.Models
{
    public class GameEvent
    {
        public Guid Id { get; set; }
        public Guid GameSessionId { get; set; }
        public GameSession GameSession { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
    }
}
