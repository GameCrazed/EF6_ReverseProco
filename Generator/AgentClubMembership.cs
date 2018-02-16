

namespace Generator
{

    public class AgentClubMembership
    {
        public int PhoebusContactId { get; set; }
        public int BrokerClubId { get; set; }


        public virtual BrokerClub BrokerClub { get; set; }
    }

}
