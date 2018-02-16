

namespace Generator
{

    public class KfiDataLive
    {
        public int Kfiid { get; set; }
        public string IssueBy { get; set; }
        public string SubBrokerRef { get; set; }
        public int Brokerref { get; set; }
        public string PlanRef { get; set; }
        public string PlanName { get; set; }
        public string PlanFunderRef { get; set; }
        public string Funder { get; set; }
        public string BrokerFirm { get; set; }
        public string BrokerAgentForename { get; set; }
        public string BrokerAgentSurname { get; set; }
        public string BrokerCareOf { get; set; }
        public string BrokerStreet { get; set; }
        public string BrokerDistrict { get; set; }
        public string BrokerTown { get; set; }
        public string BrokerCounty { get; set; }
        public string BrokerPostCode { get; set; }
        public string BrokerFcaNumber { get; set; }
        public string LoanPurpose { get; set; }
        public System.DateTime KfiDate { get; set; }
        public System.DateTime? KfiExpiryDate { get; set; }
        public string KfiType { get; set; }
        public string FullCustomerName { get; set; }
        public string C1Title { get; set; }
        public string C1Forename { get; set; }
        public string C1Surname { get; set; }
        public System.DateTime? C1Dob { get; set; }
        public string C1Gender { get; set; }
        public string C2Title { get; set; }
        public string C2Forename { get; set; }
        public string C2Surname { get; set; }
        public System.DateTime? C2Dob { get; set; }
        public string PropertyType { get; set; }
        public string PropertyConstruction { get; set; }
        public string PropertyMainResidence { get; set; }
        public string PropertyPrivateDwelling { get; set; }
        public string UkResident { get; set; }
        public short CcjNumber { get; set; }
        public decimal CcjValue { get; set; }
        public byte IvaDetails { get; set; }
        public byte BankruptcyDetails { get; set; }
        public decimal NetLoanAmount { get; set; }
        public decimal FeesToBeAdded { get; set; }
        public decimal FeesToBePaid { get; set; }
        public decimal ValuationFee { get; set; }
        public decimal ApplicationFee { get; set; }
        public int ApplicationFeeAddedFlag { get; set; }
        public decimal AcceptanceFee { get; set; }
        public int AcceptanceFeeAddedFlag { get; set; }
        public decimal CompletionFee { get; set; }
        public int CompletionFeeAddedFlag { get; set; }
        public decimal LasiFee { get; set; }
        public int LasiFeeAddedFlag { get; set; }
        public decimal FundTransferFee { get; set; }
        public int FundTransferFeeAddedFlag { get; set; }
        public decimal OtherCompletionFee { get; set; }
        public decimal LoanRedemptionFee { get; set; }
        public decimal SolicitorFee { get; set; }
        public int SolicitorFeeAddedFlag { get; set; }
        public decimal AdvisorFee { get; set; }
        public int AdvisorFeeAddedFlag { get; set; }
        public decimal PropertyValue { get; set; }
        public decimal AprRate { get; set; }
        public decimal GrossLoanAmount { get; set; }
        public decimal TotalAllFees { get; set; }
        public System.DateTime? AcceptanceDate { get; set; }
        public System.DateTime? AppRecvDate { get; set; }
        public int? InternalRefNumber { get; set; }
        public int PackagerMortgageId { get; set; }
    }

}
