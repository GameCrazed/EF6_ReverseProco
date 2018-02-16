

namespace Generator
{

    public class NbsiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbsi>
    {
        public NbsiMapping()
            : this("dbo")
        {
        }

        public NbsiMapping(string schema)
        {
            ToTable("NBSI", schema);
            HasKey(x => x.Nbsi999);

            Property(x => x.Nbsi000).HasColumnName(@"NBSI000").HasColumnType("int").IsRequired();
            Property(x => x.Nbsi001).HasColumnName(@"NBSI001").HasColumnType("int").IsRequired();
            Property(x => x.Nbsi020).HasColumnName(@"NBSI020").HasColumnType("int").IsRequired();
            Property(x => x.Nbsi030).HasColumnName(@"NBSI030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbsi040).HasColumnName(@"NBSI040").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbsi999).HasColumnName(@"NBSI999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
