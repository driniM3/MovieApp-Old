using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieApp.Models.Mapping
{
    public class FeatureMap : EntityTypeConfiguration<Feature>
    {
        public FeatureMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.title)
                .HasMaxLength(100);

            this.Property(t => t.run_time)
                .HasMaxLength(50);

            this.Property(t => t.genre)
                .HasMaxLength(100);

            this.Property(t => t.director)
                .HasMaxLength(100);

            this.Property(t => t.actors)
                .HasMaxLength(500);

            this.Property(t => t.plot)
                .HasMaxLength(500);

            this.Property(t => t.poster_url)
                .HasMaxLength(500);

            this.Property(t => t.imdb_id)
                .HasMaxLength(10);

            this.Property(t => t.file_path)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Features");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.my_status_id).HasColumnName("my_status_id");
            this.Property(t => t.feature_status_id).HasColumnName("feature_status_id");
            this.Property(t => t.type_id).HasColumnName("type_id");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.year).HasColumnName("year");
            this.Property(t => t.run_time).HasColumnName("run_time");
            this.Property(t => t.genre).HasColumnName("genre");
            this.Property(t => t.director).HasColumnName("director");
            this.Property(t => t.actors).HasColumnName("actors");
            this.Property(t => t.plot).HasColumnName("plot");
            this.Property(t => t.poster_url).HasColumnName("poster_url");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.imdb_id).HasColumnName("imdb_id");
            this.Property(t => t.my_rating).HasColumnName("my_rating");
            this.Property(t => t.on_disk).HasColumnName("on_disk");
            this.Property(t => t.file_path).HasColumnName("file_path");

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.Features)
                .HasForeignKey(d => d.feature_status_id);
            this.HasRequired(t => t.Status1)
                .WithMany(t => t.Features1)
                .HasForeignKey(d => d.my_status_id);
            this.HasRequired(t => t.Type)
                .WithMany(t => t.Features)
                .HasForeignKey(d => d.type_id);

        }
    }
}
