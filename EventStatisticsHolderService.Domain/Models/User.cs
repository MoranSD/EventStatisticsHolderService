namespace EventStatisticsHolderService.Domain.Models
{
    public class User
    {
        public Guid Id { get; }
        public ICollection<GameProject> GameProjects { get; }

        public User(Guid id, ICollection<GameProject> gameProjects)
        {
            Id = id;
            GameProjects = gameProjects;
        }
    }
}
