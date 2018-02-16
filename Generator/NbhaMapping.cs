

namespace Generator
{

    public class NbhaMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbha>
    {
        public NbhaMapping()
            : this("dbo")
        {
        }

        public NbhaMapping(string schema)
        {
            ToTable("NBHA", schema);
            HasKey(x => x.Nbha999);

            Property(x => x.Nbha000).HasColumnName(@"NBHA000").HasColumnType("int").IsRequired();
            Property(x => x.Nbha001).HasColumnName(@"NBHA001").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbha010).HasColumnName(@"NBHA010").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbha020).HasColumnName(@"NBHA020").HasColumnType("int").IsRequired();
            Property(x => x.Nbha999).HasColumnName(@"NBHA999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
