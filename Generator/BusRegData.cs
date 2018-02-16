

namespace Generator
{

    // The table 'busRegData' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BusRegData
    {
        public string AppType { get; set; }
        public string Division { get; set; }
        public string KfiNumber { get; set; }
        public string PolicyNumber { get; set; }
        public string AccountNo { get; set; }
        public string CustomerRef { get; set; }
        public string AcctRef { get; set; }
        public System.DateTime? DateKfiCreated { get; set; }
        public System.DateTime? KfiMonth { get; set; }
        public System.DateTime? DateAppReceived { get; set; }
        public System.DateTime? AppMonth { get; set; }
        public System.DateTime? OfferIssuedDate { get; set; }
        public System.DateTime? OfferMonth { get; set; }
        public System.DateTime? AnticipatedCompletionDate { get; set; }
        public System.DateTime? ActualCompletionDate { get; set; }
        public System.DateTime? CompMonth { get; set; }
        public string SingleOrJointApplication { get; set; }
        public string Life1Title { get; set; }
        public string Life1Forename { get; set; }
        public string Life1Surname { get; set; }
        public System.DateTime? Life1Dob { get; set; }
        public string Life1Sex { get; set; }
        public string MaritalStatusLife1 { get; set; }
        public string Life2Title { get; set; }
        public string Life2Forename { get; set; }
        public string Life2Surname { get; set; }
        public System.DateTime? Life2Dob { get; set; }
        public string Life2Sex { get; set; }
        public string MaritalStatusLife2 { get; set; }
        public decimal? EstimatedPropertyValue { get; set; }
        public decimal? SurveyorsPropertyValue { get; set; }
        public System.DateTime? DateOfSurveyorsPropertyValue { get; set; }
        public string ValuationMethod { get; set; }
        public decimal? InitialLoanAmountRequested { get; set; }
        public string ArrangementFeeAddedToLoan { get; set; }
        public decimal? ArrangementFee { get; set; }
        public decimal? InitialLoanRequestedIncFeesAdded { get; set; }
        public decimal? CurrentRetentionBalance { get; set; }
        public decimal? ActualLoanReleasedOnCompletion { get; set; }
        public decimal? RetentionBalanceReleased { get; set; }
        public decimal? TotalLoanReleasedToCustomer { get; set; }
        public decimal? MaximumDrawdownLimit { get; set; }
        public decimal? ChosenDrawdownLimit { get; set; }
        public decimal? DrawdownFacilityAvailableAtCompletion { get; set; }
        public decimal? TotalFacilityAllocatedToCustomerIncludingRetentionsExcludingFees { get; set; }
        public int? DrawdownsMade { get; set; }
        public decimal? DrawdownAmountTaken { get; set; }
        public decimal? RemainingDrawdownFacility { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public double? EstLtv { get; set; }
        public double? ActualLtv { get; set; }
        public string BrokerFirm { get; set; }
        public string FcaNumber { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double? InterestRate { get; set; }
        public decimal? ValuationFee { get; set; }
        public string FreeVal { get; set; }
        public string RefundOfValuationFee { get; set; }
        public decimal? Commission { get; set; }
        public decimal? AdviceFee { get; set; }
        public decimal? ContributionToAdviceFee { get; set; }
        public decimal? ContributionToLegalFee { get; set; }
        public string Status { get; set; }
        public System.DateTime? StatusChangeDate { get; set; }
        public string Rejectionreasona { get; set; }
        public string Rejectionreasonb { get; set; }
        public string BrokerRef { get; set; }
        public string BrokerFirmNew { get; set; }
        public string BrokerCareOf { get; set; }
        public string BrokerStreet { get; set; }
        public string BrokerDistrict { get; set; }
        public string BrokerTown { get; set; }
        public string BrokerCounty { get; set; }
        public string BrokerPostCode { get; set; }
        public string BrokerClub { get; set; }
        public string DaysOld { get; set; }
        public string UploadedBy { get; set; }
        public string Underwriter { get; set; }
        public string InternalRefNumber { get; set; }
        public System.DateTime? WithdrawnDate { get; set; }
        public System.DateTime? RejectedDate { get; set; }
        public decimal? InterestAppliedToDate { get; set; }
        public decimal? InterestDueToBeApplied { get; set; }
        public decimal? RedemptionsToDate { get; set; }
        public string AccountStatus { get; set; }
        public System.DateTime? AccountClosureDate { get; set; }
        public string BrokerAgentRef { get; set; }
        public string BrokerAgentForename { get; set; }
        public string BrokerAgentSurname { get; set; }
    }

}
