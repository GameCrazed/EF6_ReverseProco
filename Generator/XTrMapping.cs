

namespace Generator
{

    public class XTrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<XTr>
    {
        public XTrMapping()
            : this("dbo")
        {
        }

        public XTrMapping(string schema)
        {
            ToTable("X__TR", schema);
            HasKey(x => new { x.XTr010, x.XTr020 });

            Property(x => x.XTr130).HasColumnName(@"X__TR130").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.XTr120).HasColumnName(@"X__TR120").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XTr110).HasColumnName(@"X__TR110").HasColumnType("tinyint").IsRequired();
            Property(x => x.XTr090).HasColumnName(@"X__TR090").HasColumnType("int").IsRequired();
            Property(x => x.XTr080).HasColumnName(@"X__TR080").HasColumnType("int").IsRequired();
            Property(x => x.XTr070).HasColumnName(@"X__TR070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.XTr060).HasColumnName(@"X__TR060").HasColumnType("datetime").IsRequired();
            Property(x => x.XTr050).HasColumnName(@"X__TR050").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.XTr040).HasColumnName(@"X__TR040").HasColumnType("smallint").IsRequired();
            Property(x => x.XTr030).HasColumnName(@"X__TR030").HasColumnType("datetime").IsRequired();
            Property(x => x.XTr020).HasColumnName(@"X__TR020").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XTr010).HasColumnName(@"X__TR010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.XTr140).HasColumnName(@"X__TR140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(8);
            Property(x => x.XTr150).HasColumnName(@"X__TR150").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.XTr160).HasColumnName(@"X__TR160").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(11);
            Property(x => x.XTr180).HasColumnName(@"X__TR180").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.XTr190).HasColumnName(@"X__TR190").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
            Property(x => x.XTrdtm).HasColumnName(@"X__TRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
