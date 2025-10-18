namespace EventStatisticsHolderService.Domain.Models
{
    public class GameSession
    {
        public Guid Id { get; }
        public GameProject GameProject { get; }
        public DateTime StartTime { get; }
        public DateTime? EndTime { get; private set; }
        public ICollection<GameEvent> GameEvents { get; }

        public GameSession(Guid id, GameProject gameProject, DateTime startTime, ICollection<GameEvent> gameEvents)
        {
            Id = id;
            GameProject = gameProject;
            StartTime = startTime;
            GameEvents = gameEvents;
        }

        public GameSession(Guid id, GameProject gameProject, DateTime startTime, DateTime endTime, ICollection<GameEvent> gameEvents) :
            this(id, gameProject, startTime, gameEvents)
        {
            EndTime = endTime;
        }

        public void SetEndTime(DateTime endTime)
        {
            EndTime = endTime;
        }
    }
}
