

namespace Generator
{

    public class PackVersionMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PackVersion>
    {
        public PackVersionMapping()
            : this("dbo")
        {
        }

        public PackVersionMapping(string schema)
        {
            ToTable("PackVersions", schema);
            HasKey(x => new { x.PackId, x.VersionId });

            Property(x => x.PackId).HasColumnName(@"PackId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VersionId).HasColumnName(@"VersionId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Created).HasColumnName(@"Created").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsOptional();

            HasRequired(a => a.Pack).WithMany(b => b.PackVersions).HasForeignKey(c => c.PackId);
        }
    }

}
