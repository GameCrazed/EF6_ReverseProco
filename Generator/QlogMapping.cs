

namespace Generator
{

    public class QlogMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Qlog>
    {
        public QlogMapping()
            : this("dbo")
        {
        }

        public QlogMapping(string schema)
        {
            ToTable("QLOG", schema);
            HasKey(x => x.Qlog001);

            Property(x => x.Qlog001).HasColumnName(@"QLOG001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Qlog005).HasColumnName(@"QLOG005").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Qlog010).HasColumnName(@"QLOG010").HasColumnType("datetime").IsRequired();
            Property(x => x.Qlog015).HasColumnName(@"QLOG015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Qlog020).HasColumnName(@"QLOG020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Qlog025).HasColumnName(@"QLOG025").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Qlog030).HasColumnName(@"QLOG030").HasColumnType("int").IsRequired();
            Property(x => x.Qlog035).HasColumnName(@"QLOG035").HasColumnType("int").IsRequired();
            Property(x => x.Qlog036).HasColumnName(@"QLOG036").HasColumnType("int").IsRequired();
            Property(x => x.Qlog037).HasColumnName(@"QLOG037").HasColumnType("int").IsRequired();
            Property(x => x.Qlog040).HasColumnName(@"QLOG040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Qlog045).HasColumnName(@"QLOG045").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Qlog050).HasColumnName(@"QLOG050").HasColumnType("int").IsRequired();
            Property(x => x.Qlog055).HasColumnName(@"QLOG055").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Qlog060).HasColumnName(@"QLOG060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Qlog1001).HasColumnName(@"QLOG1001").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qlog1002).HasColumnName(@"QLOG1002").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qlog1101).HasColumnName(@"QLOG1101").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qlog1102).HasColumnName(@"QLOG1102").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qlog1201).HasColumnName(@"QLOG1201").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qlog1202).HasColumnName(@"QLOG1202").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qlog1301).HasColumnName(@"QLOG1301").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qlog1302).HasColumnName(@"QLOG1302").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Qlog2001).HasColumnName(@"QLOG2001").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Qlog2002).HasColumnName(@"QLOG2002").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Qlog2101).HasColumnName(@"QLOG2101").HasColumnType("datetime").IsRequired();
            Property(x => x.Qlog2102).HasColumnName(@"QLOG2102").HasColumnType("datetime").IsRequired();
            Property(x => x.Qlog500).HasColumnName(@"QLOG500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Qlogdtm).HasColumnName(@"QLOGDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
