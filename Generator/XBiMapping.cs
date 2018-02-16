

namespace Generator
{

    public class XBiMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XBi>
    {
        public XBiMapping()
            : this("dbo")
        {
        }

        public XBiMapping(string schema)
        {
            ToTable("X__BI", schema);
            HasKey(x => x.XBi040);

            Property(x => x.XBi120).HasColumnName(@"X__BI120").HasColumnType("int").IsRequired();
            Property(x => x.XBi150).HasColumnName(@"X__BI150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.XBi030).HasColumnName(@"X__BI030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.XBi140).HasColumnName(@"X__BI140").HasColumnType("int").IsRequired();
            Property(x => x.XBi020).HasColumnName(@"X__BI020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.XBi040).HasColumnName(@"X__BI040").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XBi050).HasColumnName(@"X__BI050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XBi060).HasColumnName(@"X__BI060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XBi070).HasColumnName(@"X__BI070").HasColumnType("datetime").IsRequired();
            Property(x => x.XBi080).HasColumnName(@"X__BI080").HasColumnType("datetime").IsRequired();
            Property(x => x.XBi130).HasColumnName(@"X__BI130").HasColumnType("int").IsRequired();
            Property(x => x.XBi100).HasColumnName(@"X__BI100").HasColumnType("datetime").IsRequired();
            Property(x => x.XBi110).HasColumnName(@"X__BI110").HasColumnType("tinyint").IsRequired();
            Property(x => x.XBi160).HasColumnName(@"X__BI160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.XBi170).HasColumnName(@"X__BI170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.XBidtm).HasColumnName(@"X__BIDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.XBi200).HasColumnName(@"X__BI200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.XBi210).HasColumnName(@"X__BI210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XBi075).HasColumnName(@"X__BI075").HasColumnType("int").IsRequired();
        }
    }

}
