

namespace Generator
{

    public class XDiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XDi>
    {
        public XDiMapping()
            : this("dbo")
        {
        }

        public XDiMapping(string schema)
        {
            ToTable("X__DI", schema);
            HasKey(x => x.XDi999);

            Property(x => x.XDi011).HasColumnName(@"X__DI011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.XDi008).HasColumnName(@"X__DI008").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XDi006).HasColumnName(@"X__DI006").HasColumnType("smallint").IsRequired();
            Property(x => x.XDi005).HasColumnName(@"X__DI005").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.XDi004).HasColumnName(@"X__DI004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.XDi003).HasColumnName(@"X__DI003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XDi009).HasColumnName(@"X__DI009").HasColumnType("datetime").IsRequired();
            Property(x => x.XDi002).HasColumnName(@"X__DI002").HasColumnType("int").IsRequired();
            Property(x => x.XDi007).HasColumnName(@"X__DI007").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XDi001).HasColumnName(@"X__DI001").HasColumnType("datetime").IsRequired();
            Property(x => x.XDi013).HasColumnName(@"X__DI013").HasColumnType("int").IsRequired();
            Property(x => x.XDi999).HasColumnName(@"X__DI999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.XDidtm).HasColumnName(@"X__DIDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.XDi150).HasColumnName(@"X__DI150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
        }
    }

}
