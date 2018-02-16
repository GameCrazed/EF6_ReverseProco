

namespace Generator
{

    // The table 'brokerBDMData' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BrokerBdmData
    {
        public int? PhoebusContactId { get; set; }
        public string BrokerCompanyShortName { get; set; }
        public string BrokerAgentForename { get; set; }
        public string BrokerAgentSurname { get; set; }
        public string BdmName { get; set; }
        public int? ErClubMember { get; set; }
        public int? PremierClubMember { get; set; }
        public bool? IsFieldBased { get; set; }
    }

}
