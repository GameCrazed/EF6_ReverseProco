

namespace Generator
{

    public class NbphMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbph>
    {
        public NbphMapping()
            : this("dbo")
        {
        }

        public NbphMapping(string schema)
        {
            ToTable("NBPH", schema);
            HasKey(x => x.Nbph999);

            Property(x => x.Nbph001).HasColumnName(@"NBPH001").HasColumnType("int").IsRequired();
            Property(x => x.Nbph002).HasColumnName(@"NBPH002").HasColumnType("int").IsRequired();
            Property(x => x.Nbph010).HasColumnName(@"NBPH010").HasColumnType("int").IsRequired();
            Property(x => x.Nbph020).HasColumnName(@"NBPH020").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbph030).HasColumnName(@"NBPH030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbph040).HasColumnName(@"NBPH040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbph050).HasColumnName(@"NBPH050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Nbph060).HasColumnName(@"NBPH060").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbph070).HasColumnName(@"NBPH070").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbph080).HasColumnName(@"NBPH080").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbph090).HasColumnName(@"NBPH090").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbph100).HasColumnName(@"NBPH100").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbph110).HasColumnName(@"NBPH110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbph200).HasColumnName(@"NBPH200").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbph999).HasColumnName(@"NBPH999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbph995).HasColumnName(@"NBPH995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
