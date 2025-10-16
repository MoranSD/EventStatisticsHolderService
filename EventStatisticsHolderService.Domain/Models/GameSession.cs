namespace EventStatisticsHolderService.Domain.Models
{
    public class GameSession
    {
        public Guid Id { get; set; }
        public Guid GameProjectId { get; set; }
        public GameProject GameProject { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<GameEvent> GameEvents { get; set; } = [];
    }
}
