

namespace Generator
{

    public class MandMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Mand>
    {
        public MandMapping()
            : this("dbo")
        {
        }

        public MandMapping(string schema)
        {
            ToTable("MAND", schema);
            HasKey(x => x.Mand000);

            Property(x => x.Mand000).HasColumnName(@"MAND000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Mand010).HasColumnName(@"MAND010").HasColumnType("int").IsRequired();
            Property(x => x.Mand020).HasColumnName(@"MAND020").HasColumnType("int").IsRequired();
            Property(x => x.Mand030).HasColumnName(@"MAND030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Mand031).HasColumnName(@"MAND031").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Mand032).HasColumnName(@"MAND032").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Mand040).HasColumnName(@"MAND040").HasColumnType("int").IsRequired();
            Property(x => x.Mand050).HasColumnName(@"MAND050").HasColumnType("datetime").IsRequired();
        }
    }

}
