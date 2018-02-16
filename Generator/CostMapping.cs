

namespace Generator
{

    public class CostMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cost>
    {
        public CostMapping()
            : this("dbo")
        {
        }

        public CostMapping(string schema)
        {
            ToTable("COST", schema);
            HasKey(x => x.Cost999);

            Property(x => x.Cost001).HasColumnName(@"COST001").HasColumnType("int").IsRequired();
            Property(x => x.Cost010).HasColumnName(@"COST010").HasColumnType("smallint").IsRequired();
            Property(x => x.Cost020).HasColumnName(@"COST020").HasColumnType("smallint").IsRequired();
            Property(x => x.Cost050).HasColumnName(@"COST050").HasColumnType("money").IsRequired().HasPrecision(19,4);
            Property(x => x.Cost999).HasColumnName(@"COST999").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Cost500).HasColumnName(@"COST500").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Costdtm).HasColumnName(@"COSTDTM").HasColumnType("timestamp").IsOptional().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);
        }
    }

}
