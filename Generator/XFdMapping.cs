

namespace Generator
{

    public class XFdMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XFd>
    {
        public XFdMapping()
            : this("dbo")
        {
        }

        public XFdMapping(string schema)
        {
            ToTable("X__FD", schema);
            HasKey(x => x.XFd001);

            Property(x => x.XFd029).HasColumnName(@"X__FD029").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XFd027).HasColumnName(@"X__FD027").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd026).HasColumnName(@"X__FD026").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd025).HasColumnName(@"X__FD025").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd024).HasColumnName(@"X__FD024").HasColumnType("smallint").IsRequired();
            Property(x => x.XFd023).HasColumnName(@"X__FD023").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(60);
            Property(x => x.XFd022).HasColumnName(@"X__FD022").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XFd021).HasColumnName(@"X__FD021").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XFd020).HasColumnName(@"X__FD020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XFd019).HasColumnName(@"X__FD019").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XFd018).HasColumnName(@"X__FD018").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd017).HasColumnName(@"X__FD017").HasColumnType("smallint").IsRequired();
            Property(x => x.XFd016).HasColumnName(@"X__FD016").HasColumnType("smallint").IsRequired();
            Property(x => x.XFd014).HasColumnName(@"X__FD014").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.XFd013).HasColumnName(@"X__FD013").HasColumnType("int").IsRequired();
            Property(x => x.XFd012).HasColumnName(@"X__FD012").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd011).HasColumnName(@"X__FD011").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.XFd010).HasColumnName(@"X__FD010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XFd009).HasColumnName(@"X__FD009").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.XFd008).HasColumnName(@"X__FD008").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.XFd007).HasColumnName(@"X__FD007").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd006).HasColumnName(@"X__FD006").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd005).HasColumnName(@"X__FD005").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd004).HasColumnName(@"X__FD004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XFd003).HasColumnName(@"X__FD003").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd002).HasColumnName(@"X__FD002").HasColumnType("smallint").IsRequired();
            Property(x => x.XFd001).HasColumnName(@"X__FD001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(7).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XFd032).HasColumnName(@"X__FD032").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd028).HasColumnName(@"X__FD028").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(300);
            Property(x => x.XFddtm).HasColumnName(@"X__FDDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.XFd033).HasColumnName(@"X__FD033").HasColumnType("datetime").IsRequired();
            Property(x => x.XFd035).HasColumnName(@"X__FD035").HasColumnType("tinyint").IsRequired();
            Property(x => x.XFd040).HasColumnName(@"X__FD040").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
        }
    }

}
