using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieApp.Models.Mapping
{
    public class StatusMap : EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Statuses");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
