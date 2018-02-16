

namespace Generator
{

    public class XEdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XEd>
    {
        public XEdMapping()
            : this("dbo")
        {
        }

        public XEdMapping(string schema)
        {
            ToTable("X__ED", schema);
            HasKey(x => x.XEd001);

            Property(x => x.XEd020).HasColumnName(@"X__ED020").HasColumnType("smallint").IsRequired();
            Property(x => x.XEd022).HasColumnName(@"X__ED022").HasColumnType("tinyint").IsRequired();
            Property(x => x.XEd114).HasColumnName(@"X__ED114").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XEd112).HasColumnName(@"X__ED112").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(19);
            Property(x => x.XEd110).HasColumnName(@"X__ED110").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(19);
            Property(x => x.XEd013).HasColumnName(@"X__ED013").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XEd009).HasColumnName(@"X__ED009").HasColumnType("smallint").IsRequired();
            Property(x => x.XEd005).HasColumnName(@"X__ED005").HasColumnType("smallint").IsRequired();
            Property(x => x.XEd004).HasColumnName(@"X__ED004").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.XEd002).HasColumnName(@"X__ED002").HasColumnType("int").IsRequired();
            Property(x => x.XEd001).HasColumnName(@"X__ED001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XEd021).HasColumnName(@"X__ED021").HasColumnType("tinyint").IsRequired();
            Property(x => x.XEd116).HasColumnName(@"X__ED116").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.XEddtm).HasColumnName(@"X__EDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.XEd900).HasColumnName(@"X__ED900").HasColumnType("tinyint").IsRequired();
        }
    }

}
