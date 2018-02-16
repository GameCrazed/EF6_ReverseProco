

namespace Generator
{

    public class DocumentMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Document>
    {
        public DocumentMapping()
            : this("dbo")
        {
        }

        public DocumentMapping(string schema)
        {
            ToTable("Documents", schema);
            HasKey(x => x.DocumentId);

            Property(x => x.DocumentId).HasColumnName(@"DocumentId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FileName).HasColumnName(@"FileName").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.BinaryData).HasColumnName(@"BinaryData").HasColumnType("varbinary(max)").IsOptional();
            Property(x => x.Created).HasColumnName(@"Created").HasColumnType("datetime").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar(max)").IsOptional();
        }
    }

}
