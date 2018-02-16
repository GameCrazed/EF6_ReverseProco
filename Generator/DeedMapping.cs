

namespace Generator
{

    public class DeedMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Deed>
    {
        public DeedMapping()
            : this("dbo")
        {
        }

        public DeedMapping(string schema)
        {
            ToTable("DEED", schema);
            HasKey(x => x.Deed001);

            Property(x => x.Deed001).HasColumnName(@"DEED001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Deed003).HasColumnName(@"DEED003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Deed030).HasColumnName(@"DEED030").HasColumnType("int").IsRequired();
            Property(x => x.Deed035).HasColumnName(@"DEED035").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(15);
            Property(x => x.Deed040).HasColumnName(@"DEED040").HasColumnType("datetime").IsRequired();
            Property(x => x.Deed045).HasColumnName(@"DEED045").HasColumnType("datetime").IsRequired();
            Property(x => x.Deed050).HasColumnName(@"DEED050").HasColumnType("int").IsRequired();
            Property(x => x.Deed055).HasColumnName(@"DEED055").HasColumnType("datetime").IsRequired();
            Property(x => x.Deed150).HasColumnName(@"DEED150").HasColumnType("datetime").IsRequired();
            Property(x => x.Deed500).HasColumnName(@"DEED500").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Deed032).HasColumnName(@"DEED032").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Deed037).HasColumnName(@"DEED037").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Deed039).HasColumnName(@"DEED039").HasColumnType("datetime").IsRequired();
            Property(x => x.Deed033).HasColumnName(@"DEED033").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
