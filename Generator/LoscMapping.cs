

namespace Generator
{

    public class LoscMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Losc>
    {
        public LoscMapping()
            : this("dbo")
        {
        }

        public LoscMapping(string schema)
        {
            ToTable("LOSC", schema);
            HasKey(x => x.Losc999);

            Property(x => x.Losc001).HasColumnName(@"LOSC001").HasColumnType("int").IsRequired();
            Property(x => x.Losc010).HasColumnName(@"LOSC010").HasColumnType("int").IsRequired();
            Property(x => x.Losc100).HasColumnName(@"LOSC100").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Losc200).HasColumnName(@"LOSC200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Losc210).HasColumnName(@"LOSC210").HasColumnType("tinyint").IsRequired();
            Property(x => x.Losc220).HasColumnName(@"LOSC220").HasColumnType("tinyint").IsRequired();
            Property(x => x.Losc300).HasColumnName(@"LOSC300").HasColumnType("int").IsRequired();
            Property(x => x.Losc400).HasColumnName(@"LOSC400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Losc410).HasColumnName(@"LOSC410").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Losc420).HasColumnName(@"LOSC420").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Losc450).HasColumnName(@"LOSC450").HasColumnType("datetime").IsRequired();
            Property(x => x.Losc500).HasColumnName(@"LOSC500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Losc999).HasColumnName(@"LOSC999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Losc402).HasColumnName(@"LOSC402").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Losc600).HasColumnName(@"LOSC600").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Losc610).HasColumnName(@"LOSC610").HasColumnType("tinyint").IsRequired();
        }
    }

}
