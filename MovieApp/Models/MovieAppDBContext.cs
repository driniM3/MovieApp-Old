using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MovieApp.Models.Mapping;

namespace MovieApp.Models
{
    public partial class MovieAppDBContext : DbContext
    {
        static MovieAppDBContext()
        {
            Database.SetInitializer<MovieAppDBContext>(null);
        }

        public MovieAppDBContext()
            : base("Name=MovieAppDBContext")
        {
        }

        public DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C__RefactorLogMap());
            modelBuilder.Configurations.Add(new ActorMap());
            modelBuilder.Configurations.Add(new EpisodeMap());
            modelBuilder.Configurations.Add(new FeatureMap());
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new TypeMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
            modelBuilder.Configurations.Add(new webpages_MembershipMap());
            modelBuilder.Configurations.Add(new webpages_OAuthMembershipMap());
            modelBuilder.Configurations.Add(new webpages_RolesMap());
        }
    }
}
