

namespace Generator
{

    public class BusregViewMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BusregView>
    {
        public BusregViewMapping()
            : this("dbo")
        {
        }

        public BusregViewMapping(string schema)
        {
            ToTable("busregView", schema);
            HasKey(x => new { x.AppType, x.Division, x.KfiNumber, x.PolicyNumber, x.AccountNo, x.DateKfiCreated, x.DateAppReceived, x.InitialLoanAmountRequested, x.ArrangementFeeAddedToLoan, x.ArrangementFee, x.RetentionBalanceReleased, x.MaximumDrawdownLimit, x.ChosenDrawdownLimit, x.TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees, x.DrawdownsMade, x.ValuationFee, x.FreeVal, x.RefundOfValuationFee, x.UploadedBy, x.Underwriter, x.InternalRefNumber, x.InterestAppliedToDate, x.RedemptionsToDate, x.AccountStatus, x.FriendlyName, x.BdmName });

            Property(x => x.AppType).HasColumnName(@"appType").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(11).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Division).HasColumnName(@"Division").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KfiNumber).HasColumnName(@"kfiNumber").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PolicyNumber).HasColumnName(@"policyNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AccountNo).HasColumnName(@"accountNo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CustomerRef).HasColumnName(@"customerRef").HasColumnType("int").IsOptional();
            Property(x => x.AcctRef).HasColumnName(@"acctRef").HasColumnType("int").IsOptional();
            Property(x => x.DateKfiCreated).HasColumnName(@"dateKFICreated").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KfiMonth).HasColumnName(@"kfiMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.DateAppReceived).HasColumnName(@"dateAppReceived").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AppMonth).HasColumnName(@"appMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferIssuedDate).HasColumnName(@"offerIssuedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferMonth).HasColumnName(@"offerMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.AnticipatedCompletionDate).HasColumnName(@"anticipatedCompletionDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ActualCompletionDate).HasColumnName(@"actualCompletionDate").HasColumnType("datetime").IsOptional();
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
            Property(x => x.InitialLoanAmountRequested).HasColumnName(@"initialLoanAmountRequested").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ArrangementFeeAddedToLoan).HasColumnName(@"arrangementFeeAddedToLoan").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ArrangementFee).HasColumnName(@"arrangementFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InitialLoanRequestedIncFeesAdded).HasColumnName(@"initialLoanRequestedIncFeesAdded").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.CurrentRetentionBalance).HasColumnName(@"currentRetentionBalance").HasColumnType("decimal").IsOptional().HasPrecision(8,2);
            Property(x => x.ActualLoanReleasedOnCompletion).HasColumnName(@"actualLoanReleasedOnCompletion").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RetentionBalanceReleased).HasColumnName(@"retentionBalanceReleased").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TotalLoanReleasedToCustomer).HasColumnName(@"totalLoanReleasedToCustomer").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.MaximumDrawdownLimit).HasColumnName(@"maximumDrawdownLimit").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ChosenDrawdownLimit).HasColumnName(@"chosenDrawdownLimit").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DrawdownFacilityAvailableAtCompletion).HasColumnName(@"drawdownFacilityAvailableAtCompletion").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees).HasColumnName(@"TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DrawdownsMade).HasColumnName(@"drawdownsMade").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
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
            Property(x => x.BrokerFirm).HasColumnName(@"brokerFirm").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.FcaNumber).HasColumnName(@"fcaNumber").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ProductCode).HasColumnName(@"productCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ProductName).HasColumnName(@"productName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2000);
            Property(x => x.InterestRate).HasColumnName(@"interestRate").HasColumnType("decimal").IsOptional().HasPrecision(13,10);
            Property(x => x.ValuationFee).HasColumnName(@"valuationFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FreeVal).HasColumnName(@"freeVal").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RefundOfValuationFee).HasColumnName(@"refundOfValuationFee").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Commission).HasColumnName(@"commission").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.LoanPurpose).HasColumnName(@"LoanPurpose").HasColumnType("smallint").IsOptional();
            Property(x => x.AdviceFee).HasColumnName(@"adviceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ContributionToAdviceFee).HasColumnName(@"contributionToAdviceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ContributionToLegalFee).HasColumnName(@"contributionToLegalFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.IsInternalPlan).HasColumnName(@"IsInternalPlan").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.StatusChangeDate).HasColumnName(@"statusChangeDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Rejectionreasona).HasColumnName(@"REJECTIONREASONA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Rejectionreasonb).HasColumnName(@"REJECTIONREASONB").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.BrokerRef).HasColumnName(@"brokerRef").HasColumnType("int").IsOptional();
            Property(x => x.BrokerFirmNew).HasColumnName(@"brokerFirmNew").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerCareOf).HasColumnName(@"brokerCareOf").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerStreet).HasColumnName(@"brokerStreet").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerDistrict).HasColumnName(@"brokerDistrict").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerTown).HasColumnName(@"brokerTown").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.BrokerCounty).HasColumnName(@"brokerCounty").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BrokerPostCode).HasColumnName(@"brokerPostCode").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BrokerClub).HasColumnName(@"brokerClub").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.DaysOld).HasColumnName(@"daysOld").HasColumnType("int").IsOptional();
            Property(x => x.UploadedBy).HasColumnName(@"uploadedBy").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Underwriter).HasColumnName(@"underwriter").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InternalRefNumber).HasColumnName(@"internalRefNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WithdrawnDate).HasColumnName(@"withdrawnDate").HasColumnType("datetime").IsOptional();
            Property(x => x.RejectedDate).HasColumnName(@"rejectedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.InterestAppliedToDate).HasColumnName(@"interestAppliedToDate").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InterestDueToBeApplied).HasColumnName(@"interestDueToBeApplied").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RedemptionsToDate).HasColumnName(@"redemptionsToDate").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AccountStatus).HasColumnName(@"accountStatus").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(63).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AccountClosureDate).HasColumnName(@"accountClosureDate").HasColumnType("datetime").IsOptional();
            Property(x => x.BrokerAgentRef).HasColumnName(@"brokerAgentRef").HasColumnType("int").IsOptional();
            Property(x => x.BrokerAgentForename).HasColumnName(@"brokerAgentForename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentSurname).HasColumnName(@"brokerAgentSurname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.FriendlyName).HasColumnName(@"friendlyName").HasColumnType("nvarchar").IsRequired().HasMaxLength(255).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.BdmName).HasColumnName(@"bdmName").HasColumnType("nvarchar(max)").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KfiWeek).HasColumnName(@"kfiWeek").HasColumnType("float").IsOptional();
            Property(x => x.AppWeek).HasColumnName(@"appWeek").HasColumnType("float").IsOptional();
            Property(x => x.OfferWeek).HasColumnName(@"offerWeek").HasColumnType("float").IsOptional();
            Property(x => x.CompWeek).HasColumnName(@"compWeek").HasColumnType("float").IsOptional();
            Property(x => x.PartialPostcode).HasColumnName(@"partialPostcode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(4);
            Property(x => x.OfficialRegion).HasColumnName(@"officialRegion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(24);
            Property(x => x.Life1Age).HasColumnName(@"life1Age").HasColumnType("int").IsOptional();
            Property(x => x.Life2Age).HasColumnName(@"life2Age").HasColumnType("int").IsOptional();
            Property(x => x.YoungestAge).HasColumnName(@"youngestAge").HasColumnType("int").IsOptional();
            Property(x => x.DdLoanAmount).HasColumnName(@"DDLoanAmount").HasColumnType("money").IsOptional().HasPrecision(19,4);
        }
    }

}
