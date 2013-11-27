using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieApp.Models.Mapping
{
    public class ActorMap : EntityTypeConfiguration<Actor>
    {
        public ActorMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Actors");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");

            // Relationships
            this.HasMany(t => t.Features)
                .WithMany(t => t.Actors1)
                .Map(m =>
                    {
                        m.ToTable("FeatureActorsLookup");
                        m.MapLeftKey("actor_id");
                        m.MapRightKey("movie_id");
                    });


        }
    }
}
