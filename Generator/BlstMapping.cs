

namespace Generator
{

    public class BlstMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Blst>
    {
        public BlstMapping()
            : this("dbo")
        {
        }

        public BlstMapping(string schema)
        {
            ToTable("BLST", schema);
            HasKey(x => x.Blst001);

            Property(x => x.Blst001).HasColumnName(@"BLST001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Blst010).HasColumnName(@"BLST010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Blst020).HasColumnName(@"BLST020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Blst030).HasColumnName(@"BLST030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Blst035).HasColumnName(@"BLST035").HasColumnType("datetime").IsRequired();
            Property(x => x.Blst040).HasColumnName(@"BLST040").HasColumnType("datetime").IsRequired();
            Property(x => x.Blst050).HasColumnName(@"BLST050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(150);
            Property(x => x.Blst060).HasColumnName(@"BLST060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
        }
    }

}
