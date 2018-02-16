

namespace Generator
{

    public class DocMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Doc>
    {
        public DocMapping()
            : this("dbo")
        {
        }

        public DocMapping(string schema)
        {
            ToTable("DOCS", schema);
            HasKey(x => new { x.Docs010, x.Docs020 });

            Property(x => x.Docs010).HasColumnName(@"DOCS010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Docs020).HasColumnName(@"DOCS020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Docs030).HasColumnName(@"DOCS030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Docs035).HasColumnName(@"DOCS035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(12);
            Property(x => x.Docs050).HasColumnName(@"DOCS050").HasColumnType("int").IsRequired();
            Property(x => x.Docs040).HasColumnName(@"DOCS040").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Docs060).HasColumnName(@"DOCS060").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Docsdtm).HasColumnName(@"DOCSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Docs070).HasColumnName(@"DOCS070").HasColumnType("int").IsRequired();
        }
    }

}
