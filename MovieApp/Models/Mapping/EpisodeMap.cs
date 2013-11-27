using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieApp.Models.Mapping
{
    public class EpisodeMap : EntityTypeConfiguration<Episode>
    {
        public EpisodeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.imdb_id)
                .HasMaxLength(10);

            this.Property(t => t.file_path)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Episodes");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.movie_id).HasColumnName("movie_id");
            this.Property(t => t.status_id).HasColumnName("status_id");
            this.Property(t => t.season).HasColumnName("season");
            this.Property(t => t.episode1).HasColumnName("episode");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.plot).HasColumnName("plot");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.imdb_id).HasColumnName("imdb_id");
            this.Property(t => t.my_rating).HasColumnName("my_rating");
            this.Property(t => t.on_disk).HasColumnName("on_disk");
            this.Property(t => t.file_path).HasColumnName("file_path");

            // Relationships
            this.HasRequired(t => t.Feature)
                .WithMany(t => t.Episodes)
                .HasForeignKey(d => d.movie_id);
            this.HasRequired(t => t.Status)
                .WithMany(t => t.Episodes)
                .HasForeignKey(d => d.status_id);

        }
    }
}
