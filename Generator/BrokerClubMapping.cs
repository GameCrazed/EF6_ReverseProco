

namespace Generator
{

    public class BrokerClubMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BrokerClub>
    {
        public BrokerClubMapping()
            : this("dbo")
        {
        }

        public BrokerClubMapping(string schema)
        {
            ToTable("BrokerClubs", schema);
            HasKey(x => x.BrokerClubId);

            Property(x => x.BrokerClubId).HasColumnName(@"BrokerClubId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.SageReference).HasColumnName(@"SageReference").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Bonus).HasColumnName(@"Bonus").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.FirstCaseMarketingCommission).HasColumnName(@"FirstCaseMarketingCommission").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
            Property(x => x.PackagerMortgageId).HasColumnName(@"PackagerMortgageId").HasColumnType("int").IsRequired();
            Property(x => x.MarketingCommission).HasColumnName(@"MarketingCommission").HasColumnType("decimal").IsRequired().HasPrecision(18,2);
        }
    }

}
