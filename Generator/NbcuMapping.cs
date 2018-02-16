

namespace Generator
{

    public class NbcuMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbcu>
    {
        public NbcuMapping()
            : this("dbo")
        {
        }

        public NbcuMapping(string schema)
        {
            ToTable("NBCU", schema);
            HasKey(x => x.Nbcu999);

            Property(x => x.Nbcu001).HasColumnName(@"NBCU001").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu010).HasColumnName(@"NBCU010").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu015).HasColumnName(@"NBCU015").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu016).HasColumnName(@"NBCU016").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu020).HasColumnName(@"NBCU020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Nbcu060).HasColumnName(@"NBCU060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbcu065).HasColumnName(@"NBCU065").HasColumnType("datetime").IsRequired();
            Property(x => x.Nbcu070).HasColumnName(@"NBCU070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbcu112).HasColumnName(@"NBCU112").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Nbcu120).HasColumnName(@"NBCU120").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Nbcu130).HasColumnName(@"NBCU130").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu210).HasColumnName(@"NBCU210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbcu220).HasColumnName(@"NBCU220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbcu230).HasColumnName(@"NBCU230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbcu250).HasColumnName(@"NBCU250").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu267).HasColumnName(@"NBCU267").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbcu270).HasColumnName(@"NBCU270").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbcu290).HasColumnName(@"NBCU290").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu400).HasColumnName(@"NBCU400").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu999).HasColumnName(@"NBCU999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbcu280).HasColumnName(@"NBCU280").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbcu275).HasColumnName(@"NBCU275").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Nbcu140).HasColumnName(@"NBCU140").HasColumnType("smallint").IsRequired();
            Property(x => x.Nbcu285).HasColumnName(@"NBCU285").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu002).HasColumnName(@"NBCU002").HasColumnType("int").IsRequired();
            Property(x => x.Nbcu995).HasColumnName(@"NBCU995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
