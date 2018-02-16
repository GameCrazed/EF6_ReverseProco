

namespace Generator
{

    public class KfiDataMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<KfiData>
    {
        public KfiDataMapping()
            : this("dbo")
        {
        }

        public KfiDataMapping(string schema)
        {
            ToTable("kfiData", schema);
            HasKey(x => x.PackagerMortgageId);

            Property(x => x.Kfiid).HasColumnName(@"kfiid").HasColumnType("int").IsOptional();
            Property(x => x.IssueBy).HasColumnName(@"issueBy").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SubBrokerRef).HasColumnName(@"subBrokerRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Brokerref).HasColumnName(@"brokerref").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PlanRef).HasColumnName(@"planRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PlanName).HasColumnName(@"planName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.PlanFunderRef).HasColumnName(@"planFunderRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Funder).HasColumnName(@"funder").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerFirm).HasColumnName(@"brokerFirm").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BrokerAgentForename).HasColumnName(@"brokerAgentForename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentSurname).HasColumnName(@"brokerAgentSurname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerCareOf).HasColumnName(@"brokerCareOf").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerStreet).HasColumnName(@"brokerStreet").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BrokerDistrict).HasColumnName(@"brokerDistrict").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerTown).HasColumnName(@"brokerTown").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerCounty).HasColumnName(@"brokerCounty").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerPostCode).HasColumnName(@"brokerPostCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerFcaNumber).HasColumnName(@"brokerFCANumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.LoanPurpose).HasColumnName(@"loanPurpose").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(500);
            Property(x => x.KfiDate).HasColumnName(@"kfiDate").HasColumnType("datetime").IsOptional();
            Property(x => x.KfiExpiryDate).HasColumnName(@"kfiExpiryDate").HasColumnType("datetime").IsOptional();
            Property(x => x.KfiType).HasColumnName(@"kfiType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FullCustomerName).HasColumnName(@"fullCustomerName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.C1Title).HasColumnName(@"c1Title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C1Forename).HasColumnName(@"c1Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C1Surname).HasColumnName(@"c1Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C1Dob).HasColumnName(@"c1DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.C1Gender).HasColumnName(@"c1Gender").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C2Title).HasColumnName(@"c2Title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C2Forename).HasColumnName(@"c2Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C2Surname).HasColumnName(@"c2Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C2Dob).HasColumnName(@"c2DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.PropertyType).HasColumnName(@"propertyType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PropertyConstruction).HasColumnName(@"propertyConstruction").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PropertyMainResidence).HasColumnName(@"propertyMainResidence").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PropertyPrivateDwelling).HasColumnName(@"propertyPrivateDwelling").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.UkResident).HasColumnName(@"ukResident").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CcjNumber).HasColumnName(@"ccjNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CcjValue).HasColumnName(@"ccjValue").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.IvaDetails).HasColumnName(@"ivaDetails").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BankruptcyDetails).HasColumnName(@"bankruptcyDetails").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NetLoanAmount).HasColumnName(@"netLoanAmount").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.FeesToBeAdded).HasColumnName(@"feesToBeAdded").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.FeesToBePaid).HasColumnName(@"feesToBePaid").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ValuationFee).HasColumnName(@"valuationFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ApplicationFee).HasColumnName(@"applicationFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ApplicationFeeAddedFlag).HasColumnName(@"applicationFeeAddedFlag").HasColumnType("bit").IsOptional();
            Property(x => x.AcceptanceFee).HasColumnName(@"acceptanceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.AcceptanceFeeAddedFlag).HasColumnName(@"acceptanceFeeAddedFlag").HasColumnType("bit").IsOptional();
            Property(x => x.CompletionFee).HasColumnName(@"completionFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.CompletionFeeAddedFlag).HasColumnName(@"completionFeeAddedFlag").HasColumnType("bit").IsOptional();
            Property(x => x.LasiFee).HasColumnName(@"lasiFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.LasiFeeAddedFlag).HasColumnName(@"lasiFeeAddedFlag").HasColumnType("bit").IsOptional();
            Property(x => x.FundTransferFee).HasColumnName(@"fundTransferFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.FundTransferFeeAddedFlag).HasColumnName(@"fundTransferFeeAddedFlag").HasColumnType("bit").IsOptional();
            Property(x => x.OtherCompletionFee).HasColumnName(@"otherCompletionFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.LoanRedemptionFee).HasColumnName(@"loanRedemptionFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.SolicitorFee).HasColumnName(@"solicitorFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.SolicitorFeeAddedFlag).HasColumnName(@"solicitorFeeAddedFlag").HasColumnType("bit").IsOptional();
            Property(x => x.AdvisorFee).HasColumnName(@"advisorFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.AdvisorFeeAddedFlag).HasColumnName(@"advisorFeeAddedFlag").HasColumnType("bit").IsOptional();
            Property(x => x.PropertyValue).HasColumnName(@"propertyValue").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.AprRate).HasColumnName(@"aprRate").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.GrossLoanAmount).HasColumnName(@"grossLoanAmount").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.TotalAllFees).HasColumnName(@"totalAllFees").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.AcceptanceDate).HasColumnName(@"acceptanceDate").HasColumnType("datetime").IsOptional();
            Property(x => x.AppRecvDate).HasColumnName(@"appRecvDate").HasColumnType("datetime").IsOptional();
            Property(x => x.InternalRefNumber).HasColumnName(@"Internal Ref Number").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PackagerMortgageId).HasColumnName(@"PackagerMortgageId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
