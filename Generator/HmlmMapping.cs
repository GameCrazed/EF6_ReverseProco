

namespace Generator
{

    public class HmlmMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Hmlm>
    {
        public HmlmMapping()
            : this("dbo")
        {
        }

        public HmlmMapping(string schema)
        {
            ToTable("HMLM", schema);
            HasKey(x => x.Hmlm999);

            Property(x => x.Hmlm010).HasColumnName(@"HMLM010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7);
            Property(x => x.Hmlm020).HasColumnName(@"HMLM020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Hmlm030).HasColumnName(@"HMLM030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.Hmlm040).HasColumnName(@"HMLM040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Hmlm050).HasColumnName(@"HMLM050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Hmlm060).HasColumnName(@"HMLM060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Hmlm070).HasColumnName(@"HMLM070").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Hmlm080).HasColumnName(@"HMLM080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Hmlm090).HasColumnName(@"HMLM090").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Hmlm100).HasColumnName(@"HMLM100").HasColumnType("datetime").IsRequired();
            Property(x => x.Hmlm110).HasColumnName(@"HMLM110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Hmlm999).HasColumnName(@"HMLM999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
