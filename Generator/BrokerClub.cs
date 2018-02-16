

namespace Generator
{

    public class BrokerClub
    {
        public int BrokerClubId { get; set; }
        public string Name { get; set; }
        public string SageReference { get; set; }
        public decimal Bonus { get; set; }
        public decimal FirstCaseMarketingCommission { get; set; }
        public int PackagerMortgageId { get; set; }
        public decimal MarketingCommission { get; set; }

        public virtual System.Collections.Generic.ICollection<AgentClubMembership> AgentClubMemberships { get; set; }

        public BrokerClub()
        {
            FirstCaseMarketingCommission = 0m;
            PackagerMortgageId = 0;
            MarketingCommission = 0m;
            AgentClubMemberships = new System.Collections.Generic.List<AgentClubMembership>();
        }
    }

}
