

namespace Generator
{

    public class BrokerDataLiveMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BrokerDataLive>
    {
        public BrokerDataLiveMapping()
            : this("dbo")
        {
        }

        public BrokerDataLiveMapping(string schema)
        {
            ToTable("brokerDataLIVE", schema);
            HasKey(x => new { x.OpenOrClosed, x.FcaNumber, x.AgencyNumber, x.CommissionBand, x.ProductFiltersCurrentlyAssigned, x.DirectlyAuthorisedFirmFcaNumber, x.DirectlyAuthorised, x.ClubMembers });

            Property(x => x.OpenOrClosed).HasColumnName(@"openOrClosed").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BrokerCompanyShortname).HasColumnName(@"brokerCompanyShortname").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.FcaNumber).HasColumnName(@"fcaNumber").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Postcode).HasColumnName(@"postcode").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.AgencyNumber).HasColumnName(@"agencyNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompanyNameAsItAppearsOnTheKfiAndOffer).HasColumnName(@"companyNameAsItAppearsOnTheKFIAndOffer").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Address1).HasColumnName(@"address1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Address2).HasColumnName(@"address2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Address3).HasColumnName(@"address3").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Address4).HasColumnName(@"address4").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.CommissionBand).HasColumnName(@"commissionBand").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CommissionPercentage).HasColumnName(@"CommissionPercentage").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.ProductFiltersCurrentlyAssigned).HasColumnName(@"productFiltersCurrentlyAssigned").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(10).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BrokersBankSortCode).HasColumnName(@"brokersBankSortCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(6);
            Property(x => x.BrokersBankAccountNumber).HasColumnName(@"brokersBankAccountNumber").HasColumnType("int").IsOptional();
            Property(x => x.DirectlyAuthorisedFirmFcaNumber).HasColumnName(@"directlyAuthorisedFirmFCANumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DirectlyAuthorised).HasColumnName(@"directlyAuthorised").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ClubMembers).HasColumnName(@"clubMembers").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BrokerAgentForename).HasColumnName(@"brokerAgentForename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentSurname).HasColumnName(@"brokerAgentSurname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PhoebusContactId).HasColumnName(@"PhoebusContactId").HasColumnType("int").IsOptional();
        }
    }

}
