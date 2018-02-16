

namespace Generator
{

    public class BrokerFirm
    {
        public int BrokerFirmId { get; set; }
        public decimal MarketingCommission { get; set; }
        public decimal FirstCaseMarketingCommission { get; set; }
        public decimal Tier { get; set; }

        public BrokerFirm()
        {
            FirstCaseMarketingCommission = 0m;
            Tier = 0m;
        }
    }

}
