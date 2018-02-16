

namespace Generator
{

    public class QtrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Qtr>
    {
        public QtrMapping()
            : this("dbo")
        {
        }

        public QtrMapping(string schema)
        {
            ToTable("QTRS", schema);
            HasKey(x => x.Qtrs000);

            Property(x => x.Qtrs000).HasColumnName(@"QTRS000").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Qtrs001).HasColumnName(@"QTRS001").HasColumnType("int").IsRequired();
            Property(x => x.Qtrs003).HasColumnName(@"QTRS003").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Qtrs004).HasColumnName(@"QTRS004").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Qtrs005).HasColumnName(@"QTRS005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Qtrs006).HasColumnName(@"QTRS006").HasColumnType("int").IsRequired();
            Property(x => x.Qtrs010).HasColumnName(@"QTRS010").HasColumnType("int").IsRequired();
            Property(x => x.Qtrs015).HasColumnName(@"QTRS015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Qtrs020).HasColumnName(@"QTRS020").HasColumnType("int").IsRequired();
            Property(x => x.Qtrs030).HasColumnName(@"QTRS030").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Qtrs031).HasColumnName(@"QTRS031").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Qtrs035).HasColumnName(@"QTRS035").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qtrs050).HasColumnName(@"QTRS050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qtrs055).HasColumnName(@"QTRS055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Qtrs060).HasColumnName(@"QTRS060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qtrs080).HasColumnName(@"QTRS080").HasColumnType("datetime").IsRequired();
            Property(x => x.Qtrs090).HasColumnName(@"QTRS090").HasColumnType("int").IsRequired();
            Property(x => x.Qtrs100).HasColumnName(@"QTRS100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Qtrs500).HasColumnName(@"QTRS500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Qtrs550).HasColumnName(@"QTRS550").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Qtrsdtm).HasColumnName(@"QTRSDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
