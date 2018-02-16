

namespace Generator
{

    public class SiteMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Site>
    {
        public SiteMapping()
            : this("dbo")
        {
        }

        public SiteMapping(string schema)
        {
            ToTable("SITE", schema);
            HasKey(x => x.Site010);

            Property(x => x.Site010).HasColumnName(@"SITE010").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Site020).HasColumnName(@"SITE020").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Site030).HasColumnName(@"SITE030").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Site040).HasColumnName(@"SITE040").HasColumnType("tinyint").IsRequired();
            Property(x => x.Numkey).HasColumnName(@"Numkey").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Sitedtm).HasColumnName(@"SITEDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
