namespace EventStatisticsHolderService.Domain.Models
{
    public class GameSession
    {
        public Guid Id { get; }
        public Guid GameProjectId { get; }
        public DateTime StartTime { get; }
        public DateTime? EndTime { get; private set; }
        public List<Guid> GameEventIds { get; }

        public GameSession(Guid id, Guid gameProjectId, DateTime startTime, List<Guid> gameEventIds)
        {
            Id = id;
            GameProjectId = gameProjectId;
            StartTime = startTime;
            GameEventIds = gameEventIds;
        }

        public GameSession(Guid id, Guid gameProjectId, DateTime startTime, DateTime endTime, List<Guid> gameEventIds) :
            this(id, gameProjectId, startTime, gameEventIds)
        {
            EndTime = endTime;
        }

        public void SetEndTime(DateTime endTime)
        {
            EndTime = endTime;
        }
    }
}
