

namespace Generator
{

    public class NbhoMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbho>
    {
        public NbhoMapping()
            : this("dbo")
        {
        }

        public NbhoMapping(string schema)
        {
            ToTable("NBHO", schema);
            HasKey(x => x.Nbho999);

            Property(x => x.Nbho000).HasColumnName(@"NBHO000").HasColumnType("int").IsRequired();
            Property(x => x.Nbho001).HasColumnName(@"NBHO001").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbho010).HasColumnName(@"NBHO010").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbho020).HasColumnName(@"NBHO020").HasColumnType("int").IsRequired();
            Property(x => x.Nbho999).HasColumnName(@"NBHO999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
