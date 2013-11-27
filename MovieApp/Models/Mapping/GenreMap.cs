using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieApp.Models.Mapping
{
    public class GenreMap : EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Genres");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");

            // Relationships
            this.HasMany(t => t.Features)
                .WithMany(t => t.Genres)
                .Map(m =>
                    {
                        m.ToTable("FeatureGenresLookup");
                        m.MapLeftKey("genre_id");
                        m.MapRightKey("movie_id");
                    });


        }
    }
}
