

namespace Generator
{

    public class NbdtMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Nbdt>
    {
        public NbdtMapping()
            : this("dbo")
        {
        }

        public NbdtMapping(string schema)
        {
            ToTable("NBDT", schema);
            HasKey(x => x.Nbdt999);

            Property(x => x.Nbdt001).HasColumnName(@"NBDT001").HasColumnType("int").IsRequired();
            Property(x => x.Nbdt002).HasColumnName(@"NBDT002").HasColumnType("int").IsRequired();
            Property(x => x.Nbdt104).HasColumnName(@"NBDT104").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbdt105).HasColumnName(@"NBDT105").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Nbdt150).HasColumnName(@"NBDT150").HasColumnType("int").IsRequired();
            Property(x => x.Nbdt200).HasColumnName(@"NBDT200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Nbdt300).HasColumnName(@"NBDT300").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Nbdt301).HasColumnName(@"NBDT301").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdt310).HasColumnName(@"NBDT310").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdt315).HasColumnName(@"NBDT315").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbdt350).HasColumnName(@"NBDT350").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbdt360).HasColumnName(@"NBDT360").HasColumnType("tinyint").IsRequired();
            Property(x => x.Nbdt420).HasColumnName(@"NBDT420").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdt422).HasColumnName(@"NBDT422").HasColumnType("int").IsRequired();
            Property(x => x.Nbdt424).HasColumnName(@"NBDT424").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Nbdt428).HasColumnName(@"NBDT428").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Nbdt450).HasColumnName(@"NBDT450").HasColumnType("int").IsRequired();
            Property(x => x.Nbdt455).HasColumnName(@"NBDT455").HasColumnType("int").IsRequired();
            Property(x => x.Nbdt460).HasColumnName(@"NBDT460").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbdt470).HasColumnName(@"NBDT470").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbdt670).HasColumnName(@"NBDT670").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Nbdt999).HasColumnName(@"NBDT999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Nbdt995).HasColumnName(@"NBDT995").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
        }
    }

}
