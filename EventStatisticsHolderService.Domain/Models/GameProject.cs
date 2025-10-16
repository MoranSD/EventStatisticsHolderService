namespace EventStatisticsHolderService.Domain.Models
{
    public class GameProject
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public User Owner { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public ICollection<GameSession> GameSessions { get; set; } = [];
    }
}
