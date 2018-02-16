

namespace Generator
{

    public class MSreplicationSubscription
    {
        public string Publisher { get; set; }
        public string PublisherDb { get; set; }
        public string Publication { get; set; }
        public bool IndependentAgent { get; set; }
        public int SubscriptionType { get; set; }
        public string DistributionAgent { get; set; }
        public System.DateTime Time { get; set; }
        public string Description { get; set; }
        public byte[] TransactionTimestamp { get; set; }
        public byte UpdateMode { get; set; }
        public byte[] AgentId { get; set; }
        public byte[] SubscriptionGuid { get; set; }
        public byte[] Subid { get; set; }
        public bool ImmediateSync { get; set; }

        public MSreplicationSubscription()
        {
            ImmediateSync = true;
        }
    }

}
