

namespace Generator
{

    public class PwarMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Pwar>
    {
        public PwarMapping()
            : this("dbo")
        {
        }

        public PwarMapping(string schema)
        {
            ToTable("PWAR", schema);
            HasKey(x => x.Pwar001);

            Property(x => x.Pwar001).HasColumnName(@"PWAR001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pwar010).HasColumnName(@"PWAR010").HasColumnType("int").IsRequired();
            Property(x => x.Pwar020).HasColumnName(@"PWAR020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Pwar053).HasColumnName(@"PWAR053").HasColumnType("smallint").IsRequired();
            Property(x => x.Pwar055).HasColumnName(@"PWAR055").HasColumnType("int").IsRequired();
            Property(x => x.Pwar064).HasColumnName(@"PWAR064").HasColumnType("int").IsRequired();
            Property(x => x.Pwar090).HasColumnName(@"PWAR090").HasColumnType("int").IsRequired();
            Property(x => x.Pwar100).HasColumnName(@"PWAR100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pwar110).HasColumnName(@"PWAR110").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pwar120).HasColumnName(@"PWAR120").HasColumnType("int").IsRequired();
            Property(x => x.Pwar200).HasColumnName(@"PWAR200").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Pwar210).HasColumnName(@"PWAR210").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Pwar220).HasColumnName(@"PWAR220").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pwar230).HasColumnName(@"PWAR230").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pwar240).HasColumnName(@"PWAR240").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pwar250).HasColumnName(@"PWAR250").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pwar260).HasColumnName(@"PWAR260").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pwar290).HasColumnName(@"PWAR290").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Pwar295).HasColumnName(@"PWAR295").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.Pwar140).HasColumnName(@"PWAR140").HasColumnType("datetime").IsRequired();
            Property(x => x.Pwar300).HasColumnName(@"PWAR300").HasColumnType("int").IsRequired();
            Property(x => x.Pwar310).HasColumnName(@"PWAR310").HasColumnType("datetime").IsRequired();
        }
    }

}
