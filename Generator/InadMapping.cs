

namespace Generator
{

    public class InadMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Inad>
    {
        public InadMapping()
            : this("dbo")
        {
        }

        public InadMapping(string schema)
        {
            ToTable("INAD", schema);
            HasKey(x => new { x.Inad001, x.Inad010 });

            Property(x => x.Inad001).HasColumnName(@"INAD001").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Inad010).HasColumnName(@"INAD010").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Inad020).HasColumnName(@"INAD020").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
            Property(x => x.Inad030).HasColumnName(@"INAD030").HasColumnType("decimal").IsRequired().HasPrecision(9,6);
        }
    }

}
