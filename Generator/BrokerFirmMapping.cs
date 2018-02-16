

namespace Generator
{

    public class BrokerFirmMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BrokerFirm>
    {
        public BrokerFirmMapping()
            : this("dbo")
        {
        }

        public BrokerFirmMapping(string schema)
        {
            ToTable("BrokerFirms", schema);
            HasKey(x => x.BrokerFirmId);

            Property(x => x.BrokerFirmId).HasColumnName(@"BrokerFirmId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MarketingCommission).HasColumnName(@"MarketingCommission").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.FirstCaseMarketingCommission).HasColumnName(@"FirstCaseMarketingCommission").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.Tier).HasColumnName(@"Tier").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
        }
    }

}
