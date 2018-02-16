

namespace Generator
{

    public class BusRegDataLiveMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BusRegDataLive>
    {
        public BusRegDataLiveMapping()
            : this("dbo")
        {
        }

        public BusRegDataLiveMapping(string schema)
        {
            ToTable("busRegDataLIVE", schema);
            HasKey(x => new { x.AppType, x.Division, x.KfiNumber, x.PolicyNumber, x.AccountNo, x.DateKfiCreated, x.DateAppReceived, x.InitialLoanAmountRequested, x.ArrangementFeeAddedToLoan, x.ArrangementFee, x.RetentionBalanceReleased, x.MaximumDrawdownLimit, x.ChosenDrawdownLimit, x.TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees, x.DrawdownsMade, x.ValuationFee, x.FreeVal, x.RefundOfValuationFee, x.UploadedBy, x.Underwriter, x.InternalRefNumber, x.InterestAppliedToDate, x.RedemptionsToDate, x.AccountStatus });

            Property(x => x.AppType).HasColumnName(@"appType").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(11).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Division).HasColumnName(@"Division").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(2).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KfiNumber).HasColumnName(@"KFINumber").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PolicyNumber).HasColumnName(@"PolicyNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AccountNo).HasColumnName(@"AccountNo").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CustomerRef).HasColumnName(@"customerRef").HasColumnType("int").IsOptional();
            Property(x => x.AcctRef).HasColumnName(@"acctRef").HasColumnType("int").IsOptional();
            Property(x => x.DateKfiCreated).HasColumnName(@"DateKFICreated").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KfiMonth).HasColumnName(@"KFIMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.DateAppReceived).HasColumnName(@"DateAppReceived").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AppMonth).HasColumnName(@"AppMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferIssuedDate).HasColumnName(@"OfferIssuedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.OfferMonth).HasColumnName(@"OfferMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.AnticipatedCompletionDate).HasColumnName(@"AnticipatedCompletionDate").HasColumnType("datetime").IsOptional();
            Property(x => x.ActualCompletionDate).HasColumnName(@"ActualCompletionDate").HasColumnType("datetime").IsOptional();
            Property(x => x.CompMonth).HasColumnName(@"CompMonth").HasColumnType("datetime").IsOptional();
            Property(x => x.SingleOrJointApplication).HasColumnName(@"singleOrJointApplication").HasColumnType("int").IsOptional();
            Property(x => x.Life1Title).HasColumnName(@"Life1Title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Life1Forename).HasColumnName(@"Life1Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life1Surname).HasColumnName(@"Life1Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life1Dob).HasColumnName(@"Life1DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.Life1Sex).HasColumnName(@"Life1Sex").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.MaritalStatusLife1).HasColumnName(@"maritalStatusLife1").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.Life2Title).HasColumnName(@"Life2Title").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Life2Forename).HasColumnName(@"Life2Forename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life2Surname).HasColumnName(@"Life2Surname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Life2Dob).HasColumnName(@"Life2DOB").HasColumnType("datetime").IsOptional();
            Property(x => x.Life2Sex).HasColumnName(@"Life2Sex").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.MaritalStatusLife2).HasColumnName(@"maritalStatusLife2").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.EstimatedPropertyValue).HasColumnName(@"EstimatedPropertyValue").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.SurveyorsPropertyValue).HasColumnName(@"SurveyorsPropertyValue").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.DateOfSurveyorsPropertyValue).HasColumnName(@"DateOfSurveyorsPropertyValue").HasColumnType("datetime").IsOptional();
            Property(x => x.ValuationMethod).HasColumnName(@"valuationMethod").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(8);
            Property(x => x.InitialLoanAmountRequested).HasColumnName(@"InitialLoanAmountRequested").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ArrangementFeeAddedToLoan).HasColumnName(@"ArrangementFeeAddedToLoan").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ArrangementFee).HasColumnName(@"ArrangementFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InitialLoanRequestedIncFeesAdded).HasColumnName(@"InitialLoanRequestedIncFeesAdded").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.CurrentRetentionBalance).HasColumnName(@"CurrentRetentionBalance").HasColumnType("decimal").IsOptional().HasPrecision(8,2);
            Property(x => x.ActualLoanReleasedOnCompletion).HasColumnName(@"ActualLoanReleasedOnCompletion").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RetentionBalanceReleased).HasColumnName(@"RetentionBalanceReleased").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TotalLoanReleasedToCustomer).HasColumnName(@"TotalLoanReleasedToCustomer").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.MaximumDrawdownLimit).HasColumnName(@"MaximumDrawdownLimit").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ChosenDrawdownLimit).HasColumnName(@"ChosenDrawdownLimit").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DrawdownFacilityAvailableAtCompletion).HasColumnName(@"DrawdownFacilityAvailableAtCompletion").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees).HasColumnName(@"TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DrawdownsMade).HasColumnName(@"drawdownsMade").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DrawdownAmountTaken).HasColumnName(@"drawdownAmountTaken").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RemainingDrawdownFacility).HasColumnName(@"RemainingDrawdownFacility").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.Region).HasColumnName(@"Region").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(40);
            Property(x => x.Street).HasColumnName(@"Street").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.District).HasColumnName(@"District").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.Town).HasColumnName(@"Town").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.County).HasColumnName(@"County").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Postcode).HasColumnName(@"Postcode").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Estltv).HasColumnName(@"ESTLTV").HasColumnType("decimal").IsOptional().HasPrecision(12,6);
            Property(x => x.ActualLtv).HasColumnName(@"ActualLTV").HasColumnType("decimal").IsOptional().HasPrecision(12,6);
            Property(x => x.BrokerFirm).HasColumnName(@"BrokerFirm").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.FcaNumber).HasColumnName(@"FCANumber").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(10);
            Property(x => x.ProductCode).HasColumnName(@"ProductCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.ProductName).HasColumnName(@"ProductName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2000);
            Property(x => x.InterestRate).HasColumnName(@"InterestRate").HasColumnType("decimal").IsOptional().HasPrecision(13,10);
            Property(x => x.ValuationFee).HasColumnName(@"ValuationFee").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FreeVal).HasColumnName(@"FreeVal").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RefundOfValuationFee).HasColumnName(@"RefundOfValuationFee").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(5).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Commission).HasColumnName(@"Commission").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.LoanPurpose).HasColumnName(@"LoanPurpose").HasColumnType("smallint").IsOptional();
            Property(x => x.AdviceFee).HasColumnName(@"AdviceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.IsInternalPlan).HasColumnName(@"IsInternalPlan").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(1);
            Property(x => x.ContributionToAdviceFee).HasColumnName(@"ContributionToAdviceFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.ContributionToLegalFee).HasColumnName(@"ContributionToLegalFee").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(15);
            Property(x => x.StatusChangeDate).HasColumnName(@"StatusChangeDate").HasColumnType("datetime").IsOptional();
            Property(x => x.Rejectionreasona).HasColumnName(@"REJECTIONREASONA").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Rejectionreasonb).HasColumnName(@"REJECTIONREASONB").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.BrokerRef).HasColumnName(@"BrokerRef").HasColumnType("int").IsOptional();
            Property(x => x.BrokerFirmNew).HasColumnName(@"BrokerFirmNew").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerCareOf).HasColumnName(@"BrokerCareOf").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerStreet).HasColumnName(@"BrokerStreet").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerDistrict).HasColumnName(@"BrokerDistrict").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(75);
            Property(x => x.BrokerTown).HasColumnName(@"BrokerTown").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.BrokerCounty).HasColumnName(@"BrokerCounty").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BrokerPostcode).HasColumnName(@"BrokerPostcode").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(20);
            Property(x => x.BrokerClub).HasColumnName(@"BrokerClub").HasColumnType("char").IsOptional().IsFixedLength().IsUnicode(false).HasMaxLength(6);
            Property(x => x.DaysOld).HasColumnName(@"DaysOld").HasColumnType("int").IsOptional();
            Property(x => x.UploadedBy).HasColumnName(@"UploadedBy").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Underwriter).HasColumnName(@"Underwriter").HasColumnType("char").IsRequired().IsFixedLength().IsUnicode(false).HasMaxLength(4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InternalRefNumber).HasColumnName(@"InternalRefNumber").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.WithdrawnDate).HasColumnName(@"WithdrawnDate").HasColumnType("datetime").IsOptional();
            Property(x => x.RejectedDate).HasColumnName(@"RejectedDate").HasColumnType("datetime").IsOptional();
            Property(x => x.InterestAppliedToDate).HasColumnName(@"interestAppliedToDate").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.InterestDueToBeApplied).HasColumnName(@"interestDueToBeApplied").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.RedemptionsToDate).HasColumnName(@"redemptionsToDate").HasColumnType("money").IsRequired().HasPrecision(19,4).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AccountStatus).HasColumnName(@"accountStatus").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(63).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AccountClosureDate).HasColumnName(@"accountClosureDate").HasColumnType("datetime").IsOptional();
            Property(x => x.BrokerAgentRef).HasColumnName(@"BrokerAgentRef").HasColumnType("int").IsOptional();
            Property(x => x.BrokerAgentForename).HasColumnName(@"BrokerAgentForename").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.BrokerAgentSurname).HasColumnName(@"BrokerAgentSurname").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
        }
    }

}
