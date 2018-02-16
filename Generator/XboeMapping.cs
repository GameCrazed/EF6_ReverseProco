

namespace Generator
{

    public class XboeMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Xboe>
    {
        public XboeMapping()
            : this("dbo")
        {
        }

        public XboeMapping(string schema)
        {
            ToTable("XBOE", schema);
            HasKey(x => x.Xboe010);

            Property(x => x.Xboe010).HasColumnName(@"XBOE010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Xboe020).HasColumnName(@"XBOE020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Xboe030).HasColumnName(@"XBOE030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xboe040).HasColumnName(@"XBOE040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xboe050).HasColumnName(@"XBOE050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Xboedtm).HasColumnName(@"XBOEDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.Xboe001).HasColumnName(@"XBOE001").HasColumnType("int").IsRequired();
            Property(x => x.Xboe015).HasColumnName(@"XBOE015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Xboe060).HasColumnName(@"XBOE060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Xboe070).HasColumnName(@"XBOE070").HasColumnType("tinyint").IsRequired();
            Property(x => x.Xboe080).HasColumnName(@"XBOE080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Xboe090).HasColumnName(@"XBOE090").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.Xboe100).HasColumnName(@"XBOE100").HasColumnType("tinyint").IsRequired();
            Property(x => x.Xboe110).HasColumnName(@"XBOE110").HasColumnType("tinyint").IsRequired();
            Property(x => x.Xboe120).HasColumnName(@"XBOE120").HasColumnType("tinyint").IsRequired();
            Property(x => x.Xboe900).HasColumnName(@"XBOE900").HasColumnType("int").IsRequired();
            Property(x => x.Xboe200).HasColumnName(@"XBOE200").HasColumnType("tinyint").IsRequired();
            Property(x => x.Xboe210).HasColumnName(@"XBOE210").HasColumnType("int").IsRequired();
            Property(x => x.Xboe220).HasColumnName(@"XBOE220").HasColumnType("datetime").IsRequired();
        }
    }

}
