

namespace Generator
{

    public class RectMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Rect>
    {
        public RectMapping()
            : this("dbo")
        {
        }

        public RectMapping(string schema)
        {
            ToTable("RECT", schema);
            HasKey(x => new { x.Rect001, x.Rect005 });

            Property(x => x.Rect001).HasColumnName(@"RECT001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rect005).HasColumnName(@"RECT005").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Rect010).HasColumnName(@"RECT010").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Rect020).HasColumnName(@"RECT020").HasColumnType("datetime").IsRequired();
            Property(x => x.Rect030).HasColumnName(@"RECT030").HasColumnType("datetime").IsRequired();
            Property(x => x.Rect040).HasColumnName(@"RECT040").HasColumnType("int").IsRequired();
            Property(x => x.Rect050).HasColumnName(@"RECT050").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(4000);
        }
    }

}
