namespace EventStatisticsHolderService.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public ICollection<GameProject> GameProjects { get; set; } = [];
    }
}
