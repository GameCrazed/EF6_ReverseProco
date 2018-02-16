

namespace Generator
{

    public class XBhMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XBh>
    {
        public XBhMapping()
            : this("dbo")
        {
        }

        public XBhMapping(string schema)
        {
            ToTable("X__BH", schema);
            HasKey(x => x.XBh040);

            Property(x => x.XBh040).HasColumnName(@"X__BH040").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XBh060).HasColumnName(@"X__BH060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XBh050).HasColumnName(@"X__BH050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XBh020).HasColumnName(@"X__BH020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.XBh030).HasColumnName(@"X__BH030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.XBh170).HasColumnName(@"X__BH170").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.XBh160).HasColumnName(@"X__BH160").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.XBh150).HasColumnName(@"X__BH150").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.XBh140).HasColumnName(@"X__BH140").HasColumnType("int").IsRequired();
            Property(x => x.XBh130).HasColumnName(@"X__BH130").HasColumnType("int").IsRequired();
            Property(x => x.XBh120).HasColumnName(@"X__BH120").HasColumnType("int").IsRequired();
            Property(x => x.XBh110).HasColumnName(@"X__BH110").HasColumnType("tinyint").IsRequired();
            Property(x => x.XBh100).HasColumnName(@"X__BH100").HasColumnType("datetime").IsRequired();
            Property(x => x.XBh080).HasColumnName(@"X__BH080").HasColumnType("datetime").IsRequired();
            Property(x => x.XBh070).HasColumnName(@"X__BH070").HasColumnType("datetime").IsRequired();
            Property(x => x.XBhdtm).HasColumnName(@"X__BHDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
            Property(x => x.XBh090).HasColumnName(@"X__BH090").HasColumnType("datetime").IsRequired();
            Property(x => x.XBh200).HasColumnName(@"X__BH200").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.XBh210).HasColumnName(@"X__BH210").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XBh061).HasColumnName(@"X__BH061").HasColumnType("tinyint").IsRequired();
            Property(x => x.XBh075).HasColumnName(@"X__BH075").HasColumnType("int").IsRequired();
            Property(x => x.XBh220).HasColumnName(@"X__BH220").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.XBh215).HasColumnName(@"X__BH215").HasColumnType("tinyint").IsRequired();
        }
    }

}
