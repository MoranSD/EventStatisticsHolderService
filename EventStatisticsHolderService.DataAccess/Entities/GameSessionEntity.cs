namespace EventStatisticsHolderService.DataAccess.Entities
{
    public class GameSessionEntity
    {
        public Guid Id { get; set; }
        public Guid GameProjectId { get; set; }
        public GameProjectEntity GameProject { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public ICollection<GameEventEntity> GameEvents { get; set; } = [];
    }
}
