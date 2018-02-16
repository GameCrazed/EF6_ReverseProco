

namespace Generator
{

    public class NbddMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbdd>
    {
        public NbddMapping()
            : this("dbo")
        {
        }

        public NbddMapping(string schema)
        {
            ToTable("NBDD", schema);
            HasKey(x => x.Nbdd999);

            Property(x => x.Nbdd000).HasColumnName(@"NBDD000").HasColumnType("int").IsRequired();
            Property(x => x.Nbdd001).HasColumnName(@"NBDD001").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbdd015).HasColumnName(@"NBDD015").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbdd020).HasColumnName(@"NBDD020").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbdd025).HasColumnName(@"NBDD025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdd045).HasColumnName(@"NBDD045").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbdd999).HasColumnName(@"NBDD999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }

}
