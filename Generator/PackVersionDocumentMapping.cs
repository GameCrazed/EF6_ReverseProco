

namespace Generator
{

    public class PackVersionDocumentMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PackVersionDocument>
    {
        public PackVersionDocumentMapping()
            : this("dbo")
        {
        }

        public PackVersionDocumentMapping(string schema)
        {
            ToTable("PackVersionDocuments", schema);
            HasKey(x => new { x.PackId, x.VersionId, x.DocumentId });

            Property(x => x.PackId).HasColumnName(@"PackId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.VersionId).HasColumnName(@"VersionId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DocumentId).HasColumnName(@"DocumentId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            HasRequired(a => a.Document).WithMany(b => b.PackVersionDocuments).HasForeignKey(c => c.DocumentId);
            HasRequired(a => a.PackVersion).WithMany(b => b.PackVersionDocuments).HasForeignKey(c => new { c.PackId, c.VersionId });
        }
    }

}
