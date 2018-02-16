

namespace Generator
{

    public class TsauMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Tsau>
    {
        public TsauMapping()
            : this("dbo")
        {
        }

        public TsauMapping(string schema)
        {
            ToTable("TSAU", schema);
            HasKey(x => new { x.Tsau005, x.Tsau010 });

            Property(x => x.Tsau005).HasColumnName(@"TSAU005").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tsau010).HasColumnName(@"TSAU010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Tsau020).HasColumnName(@"TSAU020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Tsau022).HasColumnName(@"TSAU022").HasColumnType("datetime").IsRequired();
            Property(x => x.Tsau030).HasColumnName(@"TSAU030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Tsau032).HasColumnName(@"TSAU032").HasColumnType("datetime").IsRequired();
            Property(x => x.Tsau040).HasColumnName(@"TSAU040").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);
        }
    }

}
