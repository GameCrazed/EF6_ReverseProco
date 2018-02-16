

namespace Generator
{

    public class TrxrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Trxr>
    {
        public TrxrMapping()
            : this("dbo")
        {
        }

        public TrxrMapping(string schema)
        {
            ToTable("TRXR", schema);
            HasKey(x => x.Trxr999);

            Property(x => x.Trxr010).HasColumnName(@"TRXR010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Trxr020).HasColumnName(@"TRXR020").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Trxr030).HasColumnName(@"TRXR030").HasColumnType("smallint").IsRequired();
            Property(x => x.Trxr040).HasColumnName(@"TRXR040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(60);
            Property(x => x.Trxr050).HasColumnName(@"TRXR050").HasColumnType("smallint").IsRequired();
            Property(x => x.Trxr060).HasColumnName(@"TRXR060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Trxr999).HasColumnName(@"TRXR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
