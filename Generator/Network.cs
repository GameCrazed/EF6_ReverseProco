

namespace Generator
{

    // The table '_networks' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class Network
    {
        public string NetworkName { get; set; }
        public string NetworkContactName { get; set; }
        public string NetworkEmailContactAddress40ForBaCs41 { get; set; }
        public string Telephone { get; set; }
        public string NetworkBankPayee { get; set; }
        public string NetworkBankSortCode { get; set; }
        public string NetworkBankAccountNumber { get; set; }
        public string NetworkAddress1 { get; set; }
        public string NetworkAddress2 { get; set; }
        public string NetworkAddress3 { get; set; }
        public string NetworkTown47City { get; set; }
        public string NetworkCounty { get; set; }
        public string NetworkPostcode { get; set; }
        public System.DateTime? DateRegistered { get; set; }
        public System.DateTime? AnnualCheckDate { get; set; }
        public string Completed63 { get; set; }
        public string ToBToBeSent63 { get; set; }
    }

}
