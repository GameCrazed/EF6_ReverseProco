

namespace Generator
{

    public class PureCommsReport
    {
        public int AccountNumber { get; set; }
        public System.DateTime? CompletionDate { get; set; }
        public string Surname { get; set; }
        public string Postcode { get; set; }
        public decimal? LoanAmount { get; set; }
        public decimal? Commission { get; set; }
        public short? LoanPurpose { get; set; }
        public string IsInternalPlan { get; set; }
        public decimal? Commission37 { get; set; }
        public string BrokerFirm { get; set; }
        public string BrokerAgent { get; set; }
        public string CompanyToPay { get; set; }
        public string PayType { get; set; }
        public string CompletionDateString { get; set; }
        public string CompanySageRef { get; set; }
        public string OriginalBrokerFirm { get; set; }
    }

}
