

namespace Generator
{

    // The table 'brokerData' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BrokerData
    {
        public string OpenOrClosed { get; set; }
        public string BrokerCompanyShortName { get; set; }
        public string FcaNumber { get; set; }
        public string Postcode { get; set; }
        public string AgencyNumber { get; set; }
        public string CompanyNameAsItAppearsOnTheKfiAndOffer { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string CommissionBand { get; set; }
        public string CommissionPercentage { get; set; }
        public string ProductFiltersCurrentlyAssigned { get; set; }
        public string BrokersBankSortCode { get; set; }
        public string BrokersBankAccountNumber { get; set; }
        public string DirectlyAuthorisedFirmFcaNumber { get; set; }
        public string DirectlyAuthorised { get; set; }
        public string ClubMembers { get; set; }
        public string BrokerAgentForename { get; set; }
        public string BrokerAgentSurname { get; set; }
        public int? PhoebusContactId { get; set; }
    }

}
