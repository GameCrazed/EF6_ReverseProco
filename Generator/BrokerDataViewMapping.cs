

namespace Generator
{

    public class BrokerDataViewMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BrokerDataView>
    {
        public BrokerDataViewMapping()
            : this("dbo")
        {
        }

        public BrokerDataViewMapping(string schema)
        {
            ToTable("brokerDataView", schema);
            HasKey(x => new { x.BdmName, x.CompanyType });

            Property(x => x.OpenOrClosed).HasColumnName(@"openOrClosed").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerCompanyShortName).HasColumnName(@"brokerCompanyShortName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FcaNumber).HasColumnName(@"fcaNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Postcode).HasColumnName(@"postcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.AgencyNumber).HasColumnName(@"agencyNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CompanyNameAsItAppearsOnTheKfiAndOffer).HasColumnName(@"companyNameAsItAppearsOnTheKFIAndOffer").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Address1).HasColumnName(@"address1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Address2).HasColumnName(@"address2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Address3).HasColumnName(@"address3").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Address4).HasColumnName(@"address4").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.CommissionBand).HasColumnName(@"commissionBand").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CommissionPercentage).HasColumnName(@"commissionPercentage").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ProductFiltersCurrentlyAssigned).HasColumnName(@"productFiltersCurrentlyAssigned").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokersBankSortCode).HasColumnName(@"brokersBankSortCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokersBankAccountNumber).HasColumnName(@"brokersBankAccountNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DirectlyAuthorisedFirmFcaNumber).HasColumnName(@"directlyAuthorisedFirmFCANumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DirectlyAuthorised).HasColumnName(@"directlyAuthorised").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ClubMembers).HasColumnName(@"clubMembers").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentForename).HasColumnName(@"brokerAgentForename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentSurname).HasColumnName(@"brokerAgentSurname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BdmName).HasColumnName(@"bdmName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyType).HasColumnName(@"companyType").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(7).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NetworkName).HasColumnName(@"networkName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.BrokerBankPayee).HasColumnName(@"brokerBankPayee").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.ErClubMember).HasColumnName(@"erClubMember").HasColumnType("bit").IsOptional();
            Property(x => x.PremierClubMember).HasColumnName(@"premierClubMember").HasColumnType("bit").IsOptional();
            Property(x => x.BdmId).HasColumnName(@"bdmID").HasColumnType("int").IsOptional();
        }
    }

}
