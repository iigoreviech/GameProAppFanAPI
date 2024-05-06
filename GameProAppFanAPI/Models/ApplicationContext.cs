using Microsoft.EntityFrameworkCore;

namespace GameProAppFanAPI.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>().HasOne(p => p.TeamOne).WithMany(q => q.Matches1).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Match>().HasOne(p => p.TeamTwo).WithMany(q => q.Matches2).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<TeamComposition>().HasOne(p => p.Team).WithMany(q => q.TeamCompositions).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<TeamComposition>().HasKey(u => new { u.TeamId, u.ParticipantId });
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<TournamentType> TournamentTypes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<TeamComposition> TeamCompositions { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<MatchStage> MatchStages { get; set; }
        public DbSet<GameRole> GameRoles { get; set; }
        public DbSet<Fan> Fans { get; set; }
        public DbSet<Country> Countries { get; set; }
}
}
