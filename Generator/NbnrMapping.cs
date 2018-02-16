

namespace Generator
{

    public class NbnrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbnr>
    {
        public NbnrMapping()
            : this("dbo")
        {
        }

        public NbnrMapping(string schema)
        {
            ToTable("NBNR", schema);
            HasKey(x => x.Nbnr999);

            Property(x => x.Nbnr000).HasColumnName(@"NBNR000").HasColumnType("int").IsRequired();
            Property(x => x.Nbnr001).HasColumnName(@"NBNR001").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbnr010).HasColumnName(@"NBNR010").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbnr020).HasColumnName(@"NBNR020").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbnr030).HasColumnName(@"NBNR030").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbnr040).HasColumnName(@"NBNR040").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbnr060).HasColumnName(@"NBNR060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbnr999).HasColumnName(@"NBNR999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
