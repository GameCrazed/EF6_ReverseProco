

namespace Generator
{

    public class CurrMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Curr>
    {
        public CurrMapping()
            : this("dbo")
        {
        }

        public CurrMapping(string schema)
        {
            ToTable("CURR", schema);
            HasKey(x => x.Curr040);

            Property(x => x.Curr040).HasColumnName(@"CURR040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Curr060).HasColumnName(@"CURR060").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Curr070).HasColumnName(@"CURR070").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Curr080).HasColumnName(@"CURR080").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Curr090).HasColumnName(@"CURR090").HasColumnType("tinyint").IsRequired();
            Property(x => x.Curr100).HasColumnName(@"CURR100").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(3);
            Property(x => x.Curr110).HasColumnName(@"CURR110").HasColumnType("decimal").IsRequired().HasPrecision(19,8);
            Property(x => x.Curr120).HasColumnName(@"CURR120").HasColumnType("smallint").IsRequired();
            Property(x => x.Curr130).HasColumnName(@"CURR130").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Curr140).HasColumnName(@"CURR140").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Curr150).HasColumnName(@"CURR150").HasColumnType("datetime").IsRequired();
            Property(x => x.Curr160).HasColumnName(@"CURR160").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Curr170).HasColumnName(@"CURR170").HasColumnType("datetime").IsRequired();
            Property(x => x.Curr050).HasColumnName(@"CURR050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Currdtm).HasColumnName(@"CURRDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
