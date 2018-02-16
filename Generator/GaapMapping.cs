

namespace Generator
{

    public class GaapMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Gaap>
    {
        public GaapMapping()
            : this("dbo")
        {
        }

        public GaapMapping(string schema)
        {
            ToTable("GAAP", schema);
            HasKey(x => x.Gaap001);

            Property(x => x.Gaap001).HasColumnName(@"GAAP001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Gaap010).HasColumnName(@"GAAP010").HasColumnType("smallint").IsRequired();
            Property(x => x.Gaap015).HasColumnName(@"GAAP015").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Gaap020).HasColumnName(@"GAAP020").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap030).HasColumnName(@"GAAP030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap032).HasColumnName(@"GAAP032").HasColumnType("datetime").IsRequired();
            Property(x => x.Gaap040).HasColumnName(@"GAAP040").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap045).HasColumnName(@"GAAP045").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap050).HasColumnName(@"GAAP050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap060).HasColumnName(@"GAAP060").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap070).HasColumnName(@"GAAP070").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap080).HasColumnName(@"GAAP080").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap090).HasColumnName(@"GAAP090").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Gaap120).HasColumnName(@"GAAP120").HasColumnType("int").IsRequired();
            Property(x => x.Gaap140).HasColumnName(@"GAAP140").HasColumnType("datetime").IsRequired();
        }
    }

}
