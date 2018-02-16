

namespace Generator
{

    public class ParcMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Parc>
    {
        public ParcMapping()
            : this("dbo")
        {
        }

        public ParcMapping(string schema)
        {
            ToTable("PARC", schema);
            HasKey(x => x.Parc000);

            Property(x => x.Parc000).HasColumnName(@"PARC000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Parc010).HasColumnName(@"PARC010").HasColumnType("smallint").IsRequired();
            Property(x => x.Parc020).HasColumnName(@"PARC020").HasColumnType("int").IsRequired();
            Property(x => x.Parc030).HasColumnName(@"PARC030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Parc040).HasColumnName(@"PARC040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Parc050).HasColumnName(@"PARC050").HasColumnType("int").IsRequired();
            Property(x => x.Parc400).HasColumnName(@"PARC400").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Parc410).HasColumnName(@"PARC410").HasColumnType("tinyint").IsRequired();
            Property(x => x.Parc420).HasColumnName(@"PARC420").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Parc430).HasColumnName(@"PARC430").HasColumnType("datetime").IsRequired();
            Property(x => x.Parc490).HasColumnName(@"PARC490").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Parc060).HasColumnName(@"PARC060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Parc100).HasColumnName(@"PARC100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Parc110).HasColumnName(@"PARC110").HasColumnType("datetime").IsRequired();
            Property(x => x.Parc440).HasColumnName(@"PARC440").HasColumnType("datetime").IsRequired();
            Property(x => x.Parc450).HasColumnName(@"PARC450").HasColumnType("datetime").IsRequired();
            Property(x => x.Parc460).HasColumnName(@"PARC460").HasColumnType("datetime").IsRequired();
            Property(x => x.Parc470).HasColumnName(@"PARC470").HasColumnType("datetime").IsRequired();
        }
    }

}
