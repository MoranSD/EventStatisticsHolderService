namespace EventStatisticsHolderService.DataAccess.Entities
{
    public class GameEventEntity
    {
        public Guid Id { get; set; }
        public Guid GameSessionId { get; set; }
        public GameSessionEntity GameSession { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Content { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }
    }
}
