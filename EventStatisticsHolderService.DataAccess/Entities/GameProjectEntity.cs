namespace EventStatisticsHolderService.DataAccess.Entities
{
    public class GameProjectEntity
    {
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public UserEntity Owner { get; set; } = null!;
        public string Name { get; set; } = null!;
        public ICollection<GameSessionEntity> GameSessions { get; set; } = [];
    }
}
