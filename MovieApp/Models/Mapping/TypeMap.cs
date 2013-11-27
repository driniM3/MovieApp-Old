using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieApp.Models.Mapping
{
    public class TypeMap : EntityTypeConfiguration<Type>
    {
        public TypeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Types");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
