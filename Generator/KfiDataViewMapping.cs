

namespace Generator
{

    public class KfiDataViewMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<KfiDataView>
    {
        public KfiDataViewMapping()
            : this("dbo")
        {
        }

        public KfiDataViewMapping(string schema)
        {
            ToTable("kfiDataView", schema);
            HasKey(x => new { x.Kfiid, x.IssueBy, x.Brokerref, x.PlanRef, x.KfiDate, x.CcjNumber, x.CcjValue, x.IvaDetails, x.BankruptcyDetails, x.NetLoanAmount, x.FeesToBeAdded, x.FeesToBePaid, x.ValuationFee, x.ApplicationFee, x.ApplicationFeeAddedFlag, x.AcceptanceFee, x.AcceptanceFeeAddedFlag, x.CompletionFee, x.CompletionFeeAddedFlag, x.LasiFee, x.LasiFeeAddedFlag, x.FundTransferFee, x.FundTransferFeeAddedFlag, x.OtherCompletionFee, x.LoanRedemptionFee, x.SolicitorFee, x.SolicitorFeeAddedFlag, x.AdvisorFee, x.AdvisorFeeAddedFlag, x.PropertyValue, x.AprRate, x.GrossLoanAmount, x.TotalAllFees, x.PackagerMortgageId, x.FriendlyName, x.BdmName, x.IsFieldBased });

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
            Property(x => x.InternalRefNumber1).HasColumnName(@"Internal Ref Number").HasColumnType("int").IsOptional();
            Property(x => x.PackagerMortgageId).HasColumnName(@"PackagerMortgageId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FriendlyName).HasColumnName(@"friendlyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BdmName).HasColumnName(@"bdmName").HasColumnType("nvarchar(max)").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RowNumClientBroker).HasColumnName(@"rowNumClientBroker").HasColumnType("bigint").IsOptional();
            Property(x => x.RowNumClient).HasColumnName(@"rowNumClient").HasColumnType("bigint").IsOptional();
            Property(x => x.RowNumClientMonth).HasColumnName(@"rowNumClientMonth").HasColumnType("bigint").IsOptional();
            Property(x => x.RowNumClientWeek).HasColumnName(@"rowNumClientWeek").HasColumnType("bigint").IsOptional();
            Property(x => x.RowNumClientMonthApp).HasColumnName(@"rowNumClientMonthApp").HasColumnType("bigint").IsOptional();
            Property(x => x.RowNumClientWeekApp).HasColumnName(@"rowNumClientWeekApp").HasColumnType("bigint").IsOptional();
            Property(x => x.AppType).HasColumnName(@"appType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(11);
            Property(x => x.Division).HasColumnName(@"Division").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(2);
            Property(x => x.KfiNumber).HasColumnName(@"kfiNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PolicyNumber).HasColumnName(@"policyNumber").HasColumnType("int").IsOptional();
            Property(x => x.AccountNo).HasColumnName(@"accountNo").HasColumnType("int").IsOptional();
            Property(x => x.CustomerRef).HasColumnName(@"customerRef").HasColumnType("int").IsOptional();
            Property(x => x.AcctRef).HasColumnName(@"acctRef").HasColumnType("int").IsOptional();
            Property(x => x.DateKfiCreated).HasColumnName(@"dateKFICreated").HasColumnType("datetime").IsOptional();
            Property(x => x.KfiWeek).HasColumnName(@"kfiWeek").HasColumnType("float").IsOptional();
            Property(x => x.KfiMonth).HasColumnName(@"kfiMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.DateAppReceived).HasColumnName(@"dateAppReceived").HasColumnType("datetime").IsOptional();
            Property(x => x.AppWeek).HasColumnName(@"appWeek").HasColumnType("float").IsOptional();
            Property(x => x.AppMonth).HasColumnName(@"appMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferIssuedDate).HasColumnName(@"offerIssuedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferWeek).HasColumnName(@"offerWeek").HasColumnType("float").IsOptional();
            Property(x => x.OfferMonth).HasColumnName(@"offerMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.AnticipatedCompletionDate).HasColumnName(@"anticipatedCompletionDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ActualCompletionDate).HasColumnName(@"actualCompletionDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CompWeek).HasColumnName(@"compWeek").HasColumnType("float").IsOptional();
            Property(x => x.CompMonth).HasColumnName(@"compMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.SingleOrJointApplication).HasColumnName(@"singleOrJointApplication").HasColumnType("int").IsOptional();
            Property(x => x.Life1Title).HasColumnName(@"life1Title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Life1Forename).HasColumnName(@"life1Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life1Surname).HasColumnName(@"life1Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life1Dob).HasColumnName(@"life1DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.Life1Sex).HasColumnName(@"life1Sex").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.MaritalStatusLife1).HasColumnName(@"maritalStatusLife1").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Life2Title).HasColumnName(@"life2Title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Life2Forename).HasColumnName(@"life2Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life2Surname).HasColumnName(@"life2Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life2Dob).HasColumnName(@"life2DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.Life2Sex).HasColumnName(@"life2Sex").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.MaritalStatusLife2).HasColumnName(@"maritalStatusLife2").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.EstimatedPropertyValue).HasColumnName(@"estimatedPropertyValue").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.SurveyorsPropertyValue).HasColumnName(@"surveyorsPropertyValue").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.DateOfSurveyorsPropertyValue).HasColumnName(@"dateOfSurveyorsPropertyValue").HasColumnType("datetime").IsOptional();
            Property(x => x.ValuationMethod).HasColumnName(@"valuationMethod").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.InitialLoanAmountRequested).HasColumnName(@"initialLoanAmountRequested").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ArrangementFeeAddedToLoan).HasColumnName(@"arrangementFeeAddedToLoan").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.ArrangementFee).HasColumnName(@"arrangementFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.InitialLoanRequestedIncFeesAdded).HasColumnName(@"initialLoanRequestedIncFeesAdded").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.CurrentRetentionBalance).HasColumnName(@"currentRetentionBalance").HasColumnType("decimal").IsOptional().HasPrecision(8,2);
            Property(x => x.ActualLoanReleasedOnCompletion).HasColumnName(@"actualLoanReleasedOnCompletion").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RetentionBalanceReleased).HasColumnName(@"retentionBalanceReleased").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.TotalLoanReleasedToCustomer).HasColumnName(@"totalLoanReleasedToCustomer").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.MaximumDrawdownLimit).HasColumnName(@"maximumDrawdownLimit").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ChosenDrawdownLimit).HasColumnName(@"chosenDrawdownLimit").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.DrawdownFacilityAvailableAtCompletion).HasColumnName(@"drawdownFacilityAvailableAtCompletion").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees).HasColumnName(@"TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.DrawdownsMade).HasColumnName(@"drawdownsMade").HasColumnType("int").IsOptional();
            Property(x => x.DrawdownAmountTaken).HasColumnName(@"drawdownAmountTaken").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RemainingDrawdownFacility).HasColumnName(@"remainingDrawdownFacility").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.Region).HasColumnName(@"Region").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Street).HasColumnName(@"Street").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.District).HasColumnName(@"District").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Town).HasColumnName(@"Town").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.County).HasColumnName(@"County").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Postcode).HasColumnName(@"Postcode").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.EstLtv).HasColumnName(@"estLTV").HasColumnType("decimal").IsOptional().HasPrecision(12,6);
            Property(x => x.ActualLtv).HasColumnName(@"actualLTV").HasColumnType("decimal").IsOptional().HasPrecision(12,6);
            Property(x => x.FcaNumber).HasColumnName(@"fcaNumber").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.InterestRate).HasColumnName(@"interestRate").HasColumnType("decimal").IsOptional().HasPrecision(13,10);
            Property(x => x.FreeVal).HasColumnName(@"freeVal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.RefundOfValuationFee).HasColumnName(@"refundOfValuationFee").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.Commission).HasColumnName(@"commission").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.AdviceFee).HasColumnName(@"adviceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ContributionToAdviceFee).HasColumnName(@"contributionToAdviceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ContributionToLegalFee).HasColumnName(@"contributionToLegalFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.StatusChangeDate).HasColumnName(@"statusChangeDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Rejectionreasona).HasColumnName(@"REJECTIONREASONA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Rejectionreasonb).HasColumnName(@"REJECTIONREASONB").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.BrokerClub).HasColumnName(@"brokerClub").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.DaysOld).HasColumnName(@"daysOld").HasColumnType("int").IsOptional();
            Property(x => x.UploadedBy).HasColumnName(@"uploadedBy").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.Underwriter).HasColumnName(@"underwriter").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(4);
            Property(x => x.InternalRefNumber).HasColumnName(@"internalRefNumber").HasColumnType("int").IsOptional();
            Property(x => x.WithdrawnDate).HasColumnName(@"withdrawnDate").HasColumnType("datetime").IsOptional();
            Property(x => x.RejectedDate).HasColumnName(@"rejectedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.InterestAppliedToDate).HasColumnName(@"interestAppliedToDate").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.InterestDueToBeApplied).HasColumnName(@"interestDueToBeApplied").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RedemptionsToDate).HasColumnName(@"redemptionsToDate").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.AccountStatus).HasColumnName(@"accountStatus").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(63);
            Property(x => x.AccountClosureDate).HasColumnName(@"accountClosureDate").HasColumnType("datetime").IsOptional();
            Property(x => x.BrokerAgentRef).HasColumnName(@"brokerAgentRef").HasColumnType("int").IsOptional();
            Property(x => x.PartialPostcode).HasColumnName(@"partialPostcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
            Property(x => x.OfficialRegion).HasColumnName(@"officialRegion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(24);
            Property(x => x.Life1Age).HasColumnName(@"life1Age").HasColumnType("int").IsOptional();
            Property(x => x.Life2Age).HasColumnName(@"life2Age").HasColumnType("int").IsOptional();
            Property(x => x.YoungestAge).HasColumnName(@"youngestAge").HasColumnType("int").IsOptional();
            Property(x => x.IsFieldBased).HasColumnName(@"IsFieldBased").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RowNumFirst).HasColumnName(@"rowNumFirst").HasColumnType("bigint").IsOptional();
        }
    }

}
