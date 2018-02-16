

namespace Generator
{

    public class BrokerNetworkData
    {
        public int NetworkId { get; set; }
        public string NetworkName { get; set; }
        public string NetworkContactName { get; set; }
        public string NetworkContactEmail { get; set; }
        public string NetworkContactTelephone { get; set; }
        public string NetworkBankPayee { get; set; }
        public string NetworkBankSortCode { get; set; }
        public string NetworkBankAccountNumber { get; set; }
        public string NetworkAddress1 { get; set; }
        public string NetworkAddress2 { get; set; }
        public string NetworkAddress3 { get; set; }
        public string NetworkTownCity { get; set; }
        public string NetworkCounty { get; set; }
        public string NetworkPostcode { get; set; }
        public System.DateTime? NetworkDateRegistered { get; set; }
        public System.DateTime? NetworkLastAnnualCheck { get; set; }
        public string NetworkCompleted { get; set; }
        public string NetworkToBToBeSent { get; set; }

        public BrokerNetworkData()
        {
            NetworkName = "";
            NetworkContactName = "";
            NetworkContactEmail = "";
            NetworkContactTelephone = "";
            NetworkBankPayee = "";
            NetworkBankSortCode = "";
            NetworkBankAccountNumber = "";
            NetworkAddress1 = "";
            NetworkAddress2 = "";
            NetworkAddress3 = "";
            NetworkTownCity = "";
            NetworkCounty = "";
            NetworkPostcode = "";
            NetworkCompleted = "";
            NetworkToBToBeSent = "";
        }
    }

}
