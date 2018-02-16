

namespace Generator
{

    public class DtirMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Dtir>
    {
        public DtirMapping()
            : this("dbo")
        {
        }

        public DtirMapping(string schema)
        {
            ToTable("DTIR", schema);
            HasKey(x => x.Dtir000);

            Property(x => x.Dtir000).HasColumnName(@"DTIR000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Dtir001).HasColumnName(@"DTIR001").HasColumnType("int").IsRequired();
            Property(x => x.Dtir010).HasColumnName(@"DTIR010").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Dtir020).HasColumnName(@"DTIR020").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Dtir025).HasColumnName(@"DTIR025").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Dtir030).HasColumnName(@"DTIR030").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(80);
            Property(x => x.Dtir060).HasColumnName(@"DTIR060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Dtir070).HasColumnName(@"DTIR070").HasColumnType("datetime").IsRequired();
        }
    }

}
