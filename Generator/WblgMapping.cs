

namespace Generator
{

    public class WblgMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Wblg>
    {
        public WblgMapping()
            : this("dbo")
        {
        }

        public WblgMapping(string schema)
        {
            ToTable("WBLG", schema);
            HasKey(x => new { x.Wblg010, x.Wblg020 });

            Property(x => x.Wblg010).HasColumnName(@"WBLG010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Wblg020).HasColumnName(@"WBLG020").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Wblg030).HasColumnName(@"WBLG030").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Wblg040).HasColumnName(@"WBLG040").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(50);
        }
    }

}
