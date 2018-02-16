

namespace Generator
{

    public class BrokerBdmDataDeprecated
    {
        public int BdmId { get; set; }
        public string BrokerCompanyShortName { get; set; }
        public string BrokerAgentForename { get; set; }
        public string BrokerAgentSurname { get; set; }
        public string BdmName { get; set; }
        public bool? ErClubMember { get; set; }
        public bool? PremierClubMember { get; set; }
        public System.DateTime? Created { get; set; }
        public byte[] Updated { get; private set; }
        public string CreatedBy { get; set; }
        public int IsFieldBased { get; set; }

        public BrokerBdmDataDeprecated()
        {
            BdmName = "";
            ErClubMember = false;
            PremierClubMember = false;
            Created = System.DateTime.Now;
            CreatedBy = "suser_sname()";
            IsFieldBased = 0;
        }
    }

}
