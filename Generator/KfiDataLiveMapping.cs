

namespace Generator
{

    public class KfiDataLiveMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<KfiDataLive>
    {
        public KfiDataLiveMapping()
            : this("dbo")
        {
        }

        public KfiDataLiveMapping(string schema)
        {
            ToTable("kfiDataLIVE", schema);
            HasKey(x => new { x.Kfiid, x.IssueBy, x.Brokerref, x.PlanRef, x.KfiDate, x.CcjNumber, x.CcjValue, x.IvaDetails, x.BankruptcyDetails, x.NetLoanAmount, x.FeesToBeAdded, x.FeesToBePaid, x.ValuationFee, x.ApplicationFee, x.ApplicationFeeAddedFlag, x.AcceptanceFee, x.AcceptanceFeeAddedFlag, x.CompletionFee, x.CompletionFeeAddedFlag, x.LasiFee, x.LasiFeeAddedFlag, x.FundTransferFee, x.FundTransferFeeAddedFlag, x.OtherCompletionFee, x.LoanRedemptionFee, x.SolicitorFee, x.SolicitorFeeAddedFlag, x.AdvisorFee, x.AdvisorFeeAddedFlag, x.PropertyValue, x.AprRate, x.GrossLoanAmount, x.TotalAllFees, x.PackagerMortgageId });

            Property(x => x.Kfiid).HasColumnName(@"kfiid").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IssueBy).HasColumnName(@"issueBy").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SubBrokerRef).HasColumnName(@"subBrokerRef").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.Brokerref).HasColumnName(@"brokerref").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PlanRef).HasColumnName(@"planRef").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PlanName).HasColumnName(@"planName").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PlanFunderRef).HasColumnName(@"planFunderRef").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Funder).HasColumnName(@"funder").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.BrokerFirm).HasColumnName(@"brokerFirm").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BrokerAgentForename).HasColumnName(@"brokerAgentForename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentSurname).HasColumnName(@"brokerAgentSurname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerCareOf).HasColumnName(@"brokerCareOf").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerStreet).HasColumnName(@"brokerStreet").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerDistrict).HasColumnName(@"brokerDistrict").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerTown).HasColumnName(@"brokerTown").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.BrokerCounty).HasColumnName(@"brokerCounty").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BrokerPostCode).HasColumnName(@"brokerPostCode").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BrokerFcaNumber).HasColumnName(@"brokerFCANumber").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.LoanPurpose).HasColumnName(@"loanPurpose").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(30);
            Property(x => x.KfiDate).HasColumnName(@"kfiDate").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KfiExpiryDate).HasColumnName(@"kfiExpiryDate").HasColumnType("datetime").IsOptional();
            Property(x => x.KfiType).HasColumnName(@"kfiType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(35);
            Property(x => x.FullCustomerName).HasColumnName(@"fullCustomerName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.C1Title).HasColumnName(@"c1Title").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.C1Forename).HasColumnName(@"c1Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C1Surname).HasColumnName(@"c1Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C1Dob).HasColumnName(@"c1DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.C1Gender).HasColumnName(@"c1Gender").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.C2Title).HasColumnName(@"c2Title").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.C2Forename).HasColumnName(@"c2Forename").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(5);
            Property(x => x.C2Surname).HasColumnName(@"c2Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.C2Dob).HasColumnName(@"c2DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.PropertyType).HasColumnName(@"propertyType").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.PropertyConstruction).HasColumnName(@"propertyConstruction").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.PropertyMainResidence).HasColumnName(@"propertyMainResidence").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.PropertyPrivateDwelling).HasColumnName(@"propertyPrivateDwelling").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.UkResident).HasColumnName(@"ukResident").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.CcjNumber).HasColumnName(@"ccjNumber").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CcjValue).HasColumnName(@"ccjValue").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IvaDetails).HasColumnName(@"ivaDetails").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BankruptcyDetails).HasColumnName(@"bankruptcyDetails").HasColumnType("tinyint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NetLoanAmount).HasColumnName(@"netLoanAmount").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FeesToBeAdded).HasColumnName(@"feesToBeAdded").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FeesToBePaid).HasColumnName(@"feesToBePaid").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ValuationFee).HasColumnName(@"valuationFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ApplicationFee).HasColumnName(@"applicationFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ApplicationFeeAddedFlag).HasColumnName(@"applicationFeeAddedFlag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AcceptanceFee).HasColumnName(@"acceptanceFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AcceptanceFeeAddedFlag).HasColumnName(@"acceptanceFeeAddedFlag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompletionFee).HasColumnName(@"completionFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompletionFeeAddedFlag).HasColumnName(@"completionFeeAddedFlag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LasiFee).HasColumnName(@"lasiFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LasiFeeAddedFlag).HasColumnName(@"lasiFeeAddedFlag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FundTransferFee).HasColumnName(@"fundTransferFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FundTransferFeeAddedFlag).HasColumnName(@"fundTransferFeeAddedFlag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OtherCompletionFee).HasColumnName(@"otherCompletionFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LoanRedemptionFee).HasColumnName(@"loanRedemptionFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SolicitorFee).HasColumnName(@"solicitorFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SolicitorFeeAddedFlag).HasColumnName(@"solicitorFeeAddedFlag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AdvisorFee).HasColumnName(@"advisorFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AdvisorFeeAddedFlag).HasColumnName(@"advisorFeeAddedFlag").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PropertyValue).HasColumnName(@"propertyValue").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AprRate).HasColumnName(@"aprRate").HasColumnType("decimal").IsRequired().HasPrecision(9,6).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.GrossLoanAmount).HasColumnName(@"grossLoanAmount").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TotalAllFees).HasColumnName(@"totalAllFees").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AcceptanceDate).HasColumnName(@"acceptanceDate").HasColumnType("datetime").IsOptional();
            Property(x => x.AppRecvDate).HasColumnName(@"appRecvDate").HasColumnType("datetime").IsOptional();
            Property(x => x.InternalRefNumber).HasColumnName(@"Internal Ref Number").HasColumnType("int").IsOptional();
            Property(x => x.PackagerMortgageId).HasColumnName(@"PackagerMortgageId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
