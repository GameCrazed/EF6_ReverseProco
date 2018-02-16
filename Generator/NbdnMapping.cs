

namespace Generator
{

    public class NbdnMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbdn>
    {
        public NbdnMapping()
            : this("dbo")
        {
        }

        public NbdnMapping(string schema)
        {
            ToTable("NBDN", schema);
            HasKey(x => x.Nbdn999);

            Property(x => x.Nbdn000).HasColumnName(@"NBDN000").HasColumnType("int").IsRequired();
            Property(x => x.Nbdn001).HasColumnName(@"NBDN001").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbdn020).HasColumnName(@"NBDN020").HasColumnType("int").IsRequired();
            Property(x => x.Nbdn999).HasColumnName(@"NBDN999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
