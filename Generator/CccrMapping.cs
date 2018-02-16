

namespace Generator
{

    public class CccrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cccr>
    {
        public CccrMapping()
            : this("dbo")
        {
        }

        public CccrMapping(string schema)
        {
            ToTable("CCCR", schema);
            HasKey(x => x.Cccr010);

            Property(x => x.Cccr010).HasColumnName(@"CCCR010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(38).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cccr020).HasColumnName(@"CCCR020").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.Cccr030).HasColumnName(@"CCCR030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Cccr040).HasColumnName(@"CCCR040").HasColumnType("datetime").IsRequired();
            Property(x => x.Cccr050).HasColumnName(@"CCCR050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
        }
    }

}
