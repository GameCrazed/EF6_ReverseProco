

namespace Generator
{

    public class NbhhMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbhh>
    {
        public NbhhMapping()
            : this("dbo")
        {
        }

        public NbhhMapping(string schema)
        {
            ToTable("NBHH", schema);
            HasKey(x => x.Nbhh999);

            Property(x => x.Nbhh001).HasColumnName(@"NBHH001").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbhh010).HasColumnName(@"NBHH010").HasColumnType("int").IsRequired();
            Property(x => x.Nbhh020).HasColumnName(@"NBHH020").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbhh030).HasColumnName(@"NBHH030").HasColumnType("int").IsRequired();
            Property(x => x.Nbhh040).HasColumnName(@"NBHH040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbhh050).HasColumnName(@"NBHH050").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbhh060).HasColumnName(@"NBHH060").HasColumnType("int").IsRequired();
            Property(x => x.Nbhh999).HasColumnName(@"NBHH999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
