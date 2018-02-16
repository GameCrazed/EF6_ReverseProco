

namespace Generator
{

    public class AllDataWorkingMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AllDataWorking>
    {
        public AllDataWorkingMapping()
            : this("dbo")
        {
        }

        public AllDataWorkingMapping(string schema)
        {
            ToTable("allDataWorkings", schema);
            HasKey(x => new { x.Product, x.PaReferenceNumber, x.NewPaReference, x.PegPercentage, x.OnAppRegister, x.RealCount, x.LatestVersion, x.Status, x.Blank, x.Withdrawn, x.Declined, x.Complete, x.CompletionDateSet, x.Offer, x.ApplicationReceived, x.Kfi6030Days, x.Kfi6230Days, x.DateChangeToday, x.LastAction622MonthsAgo, x.FriendlyName, x.BdmName, x.IsFieldBased, x.PackagerMortgageId });

            Property(x => x.Division).HasColumnName(@"Division").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Product).HasColumnName(@"Product").HasColumnType("nvarchar").IsRequired().HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Application92KfiNo46).HasColumnName(@"Application\KFI No.").HasColumnType("int").IsOptional();
            Property(x => x.PaReferenceNumber).HasColumnName(@"PA reference number").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NewPaReference).HasColumnName(@"New PA reference").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(1).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DateSubmitted).HasColumnName(@"Date submitted").HasColumnType("datetime").IsOptional();
            Property(x => x.App1Title).HasColumnName(@"App 1 title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.App1Surname).HasColumnName(@"App 1 surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.App1D46O46B46).HasColumnName(@"App 1 d.o.b.").HasColumnType("datetime").IsOptional();
            Property(x => x.App1Gender).HasColumnName(@"App 1 gender").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.App2Title).HasColumnName(@"App 2 title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.App2Surname).HasColumnName(@"App 2 surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.App2D46O46B46).HasColumnName(@"App 2 d.o.b.").HasColumnType("datetime").IsOptional();
            Property(x => x.App2Gender).HasColumnName(@"App 2 gender").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.LoanAmount).HasColumnName(@"Loan amount").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.BrokerName).HasColumnName(@"Broker name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(101);
            Property(x => x.BrokerFirm1).HasColumnName(@"Broker firm").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8000);
            Property(x => x.Street40Broker41).HasColumnName(@"Street (broker)").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.District).HasColumnName(@"District").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Town).HasColumnName(@"Town").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.County).HasColumnName(@"County").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PostCode).HasColumnName(@"Post code").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FcaNumber1).HasColumnName(@"FCA number").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.LoanProduct).HasColumnName(@"Loan product").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PegPercentage).HasColumnName(@"PEG percentage").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.OnAppRegister).HasColumnName(@"On app register").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RealCount).HasColumnName(@"Real Count").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8000);
            Property(x => x.LatestVersion).HasColumnName(@"Latest version").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProperCount).HasColumnName(@"Proper count").HasColumnType("int").IsOptional();
            Property(x => x.ApplicationDate).HasColumnName(@"Application date").HasColumnType("datetime").IsOptional();
            Property(x => x.ValuationDate).HasColumnName(@"Valuation date").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferDate).HasColumnName(@"Offer date").HasColumnType("datetime").IsOptional();
            Property(x => x.ActualCompletionDate1).HasColumnName(@"Actual completion date").HasColumnType("datetime").IsOptional();
            Property(x => x.DeclinedDate).HasColumnName(@"Declined date").HasColumnType("datetime").IsOptional();
            Property(x => x.WithdrawnDate1).HasColumnName(@"Withdrawn date").HasColumnType("datetime").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Blank).HasColumnName(@"Blank").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Withdrawn).HasColumnName(@"Withdrawn").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Declined).HasColumnName(@"Declined").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Complete).HasColumnName(@"Complete").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CompletionDateSet).HasColumnName(@"Completion date set").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Offer).HasColumnName(@"Offer").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ApplicationReceived).HasColumnName(@"Application received").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kfi6030Days).HasColumnName(@"KFI < 30 days").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Kfi6230Days).HasColumnName(@"KFI > 30 days").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DateChangeToday).HasColumnName(@"Date change today").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.LastAction622MonthsAgo).HasColumnName(@"Last action > 2months ago").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KfiWeek1).HasColumnName(@"KFI week").HasColumnType("float").IsOptional();
            Property(x => x.AppWeek1).HasColumnName(@"App week").HasColumnType("float").IsOptional();
            Property(x => x.OfferWeek1).HasColumnName(@"Offer week").HasColumnType("float").IsOptional();
            Property(x => x.CompletionWeek).HasColumnName(@"Completion week").HasColumnType("float").IsOptional();
            Property(x => x.KfiMonth1).HasColumnName(@"KFI Month").HasColumnType("datetime").IsOptional();
            Property(x => x.AppMonth1).HasColumnName(@"App Month").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferMonth1).HasColumnName(@"Offer Month").HasColumnType("datetime").IsOptional();
            Property(x => x.CompletionMonth).HasColumnName(@"Completion month").HasColumnType("datetime").IsOptional();
            Property(x => x.KfiDays).HasColumnName(@"KFI days").HasColumnType("int").IsOptional();
            Property(x => x.AppDays).HasColumnName(@"App days").HasColumnType("int").IsOptional();
            Property(x => x.OfferDays).HasColumnName(@"Offer days").HasColumnType("int").IsOptional();
            Property(x => x.Underwriter).HasColumnName(@"Underwriter").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.StillToDealWith).HasColumnName(@"Still to deal with").HasColumnType("int").IsOptional();
            Property(x => x.DaysToDealWithApp).HasColumnName(@"Days to deal with App").HasColumnType("int").IsOptional();
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
            Property(x => x.InternalRefNumber1).HasColumnName(@"Internal Ref Number").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FriendlyName).HasColumnName(@"friendlyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BdmName).HasColumnName(@"bdmName").HasColumnType("nvarchar(max)").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RowNumClientBroker).HasColumnName(@"rowNumClientBroker").HasColumnType("bigint").IsOptional();
            Property(x => x.RowNumClient).HasColumnName(@"rowNumClient").HasColumnType("bigint").IsOptional();
            Property(x => x.AppType).HasColumnName(@"appType").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BusregDivision).HasColumnName(@"busregDivision").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.KfiNumber).HasColumnName(@"kfiNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.PolicyNumber).HasColumnName(@"policyNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.AccountNo).HasColumnName(@"accountNo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.CustomerRef).HasColumnName(@"customerRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.AcctRef).HasColumnName(@"acctRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
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
            Property(x => x.SingleOrJointApplication).HasColumnName(@"singleOrJointApplication").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life1Title).HasColumnName(@"life1Title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life1Forename).HasColumnName(@"life1Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life1Surname).HasColumnName(@"life1Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life1Dob).HasColumnName(@"life1DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.Life1Sex).HasColumnName(@"life1Sex").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.MaritalStatusLife1).HasColumnName(@"maritalStatusLife1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life2Title).HasColumnName(@"life2Title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life2Forename).HasColumnName(@"life2Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life2Surname).HasColumnName(@"life2Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life2Dob).HasColumnName(@"life2DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.Life2Sex).HasColumnName(@"life2Sex").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.MaritalStatusLife2).HasColumnName(@"maritalStatusLife2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.EstimatedPropertyValue).HasColumnName(@"estimatedPropertyValue").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.SurveyorsPropertyValue).HasColumnName(@"surveyorsPropertyValue").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.DateOfSurveyorsPropertyValue).HasColumnName(@"dateOfSurveyorsPropertyValue").HasColumnType("datetime").IsOptional();
            Property(x => x.ValuationMethod).HasColumnName(@"valuationMethod").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.InitialLoanAmountRequested).HasColumnName(@"initialLoanAmountRequested").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ArrangementFeeAddedToLoan).HasColumnName(@"arrangementFeeAddedToLoan").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ArrangementFee).HasColumnName(@"arrangementFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.InitialLoanRequestedIncFeesAdded).HasColumnName(@"initialLoanRequestedIncFeesAdded").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.CurrentRetentionBalance).HasColumnName(@"currentRetentionBalance").HasColumnType("money").IsOptional().HasPrecision(19,4);
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
            Property(x => x.ClientRegion).HasColumnName(@"clientRegion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ClientStreet).HasColumnName(@"clientStreet").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ClientDistrict).HasColumnName(@"clientDistrict").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ClientTown).HasColumnName(@"clientTown").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ClientCounty).HasColumnName(@"clientCounty").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.ClientPostcode).HasColumnName(@"clientPostcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.EstLtv).HasColumnName(@"estLTV").HasColumnType("float").IsOptional();
            Property(x => x.ActualLtv).HasColumnName(@"actualLTV").HasColumnType("float").IsOptional();
            Property(x => x.FcaNumber).HasColumnName(@"fcaNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.InterestRate).HasColumnName(@"interestRate").HasColumnType("float").IsOptional();
            Property(x => x.FreeVal).HasColumnName(@"freeVal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.RefundOfValuationFee).HasColumnName(@"refundOfValuationFee").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Commission).HasColumnName(@"commission").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.AdviceFee).HasColumnName(@"adviceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ContributionToAdviceFee).HasColumnName(@"contributionToAdviceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ContributionToLegalFee).HasColumnName(@"contributionToLegalFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.BusregStatus).HasColumnName(@"busregStatus").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.StatusChangeDate).HasColumnName(@"statusChangeDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Rejectionreasona).HasColumnName(@"REJECTIONREASONA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.Rejectionreasonb).HasColumnName(@"REJECTIONREASONB").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);
            Property(x => x.BrokerClub).HasColumnName(@"brokerClub").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DaysOld).HasColumnName(@"daysOld").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.UploadedBy).HasColumnName(@"uploadedBy").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BusregUnderwriter).HasColumnName(@"busregUnderwriter").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.InternalRefNumber).HasColumnName(@"internalRefNumber").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.WithdrawnDate).HasColumnName(@"withdrawnDate").HasColumnType("datetime").IsOptional();
            Property(x => x.RejectedDate).HasColumnName(@"rejectedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.InterestAppliedToDate).HasColumnName(@"interestAppliedToDate").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.InterestDueToBeApplied).HasColumnName(@"interestDueToBeApplied").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RedemptionsToDate).HasColumnName(@"redemptionsToDate").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.AccountStatus).HasColumnName(@"accountStatus").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.AccountClosureDate).HasColumnName(@"accountClosureDate").HasColumnType("datetime").IsOptional();
            Property(x => x.BrokerAgentRef).HasColumnName(@"brokerAgentRef").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.OfficialRegion).HasColumnName(@"officialRegion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(24);
            Property(x => x.Life1Age).HasColumnName(@"life1Age").HasColumnType("int").IsOptional();
            Property(x => x.Life2Age).HasColumnName(@"life2Age").HasColumnType("int").IsOptional();
            Property(x => x.YoungestAge).HasColumnName(@"youngestAge").HasColumnType("int").IsOptional();
            Property(x => x.ProperCountMonth).HasColumnName(@"Proper count month").HasColumnType("int").IsOptional();
            Property(x => x.ProperCountWeek).HasColumnName(@"Proper count week").HasColumnType("int").IsOptional();
            Property(x => x.ProperCountMonthApp).HasColumnName(@"Proper count month App").HasColumnType("int").IsOptional();
            Property(x => x.ProperCountWeekApp).HasColumnName(@"Proper count week App").HasColumnType("int").IsOptional();
            Property(x => x.IsFieldBased).HasColumnName(@"IsFieldBased").HasColumnType("bit").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PackagerMortgageId).HasColumnName(@"PackagerMortgageId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

}
