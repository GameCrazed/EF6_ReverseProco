

namespace Generator
{

    public class NbdvMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbdv>
    {
        public NbdvMapping()
            : this("dbo")
        {
        }

        public NbdvMapping(string schema)
        {
            ToTable("NBDV", schema);
            HasKey(x => x.Nbdv001);

            Property(x => x.Nbdv001).HasColumnName(@"NBDV001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Nbdv050).HasColumnName(@"NBDV050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdv110).HasColumnName(@"NBDV110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdv185).HasColumnName(@"NBDV185").HasColumnType("int").IsRequired();
            Property(x => x.Nbdv188).HasColumnName(@"NBDV188").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdv210).HasColumnName(@"NBDV210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbdv220).HasColumnName(@"NBDV220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Nbdv600).HasColumnName(@"NBDV600").HasColumnType("int").IsRequired();
            Property(x => x.Nbdv610).HasColumnName(@"NBDV610").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
