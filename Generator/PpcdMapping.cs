

namespace Generator
{

    public class PpcdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ppcd>
    {
        public PpcdMapping()
            : this("dbo")
        {
        }

        public PpcdMapping(string schema)
        {
            ToTable("PPCD", schema);
            HasKey(x => new { x.Ppcd001, x.Ppcd005 });

            Property(x => x.Ppcd001).HasColumnName(@"PPCD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ppcd005).HasColumnName(@"PPCD005").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Ppcd010).HasColumnName(@"PPCD010").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ppcd020).HasColumnName(@"PPCD020").HasColumnType("datetime").IsRequired();
            Property(x => x.Ppcd030).HasColumnName(@"PPCD030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Ppcd040).HasColumnName(@"PPCD040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Ppcd050).HasColumnName(@"PPCD050").HasColumnType("smallint").IsRequired();
            Property(x => x.Ppcd060).HasColumnName(@"PPCD060").HasColumnType("datetime").IsRequired();
            Property(x => x.Ppcd070).HasColumnName(@"PPCD070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Ppcd080).HasColumnName(@"PPCD080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
