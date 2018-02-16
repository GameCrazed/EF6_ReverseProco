

namespace Generator
{

    public class MSsubscriptionAgent
    {
        public int Id { get; set; }
        public string Publisher { get; set; }
        public string PublisherDb { get; set; }
        public string Publication { get; set; }
        public int SubscriptionType { get; set; }
        public string QueueId { get; set; }
        public byte UpdateMode { get; set; }
        public bool FailoverMode { get; set; }
        public int Spid { get; set; }
        public System.DateTime LoginTime { get; set; }
        public bool AllowSubscriptionCopy { get; set; }
        public int AttachState { get; set; }
        public byte[] AttachVersion { get; set; }
        public int? LastSyncStatus { get; set; }
        public string LastSyncSummary { get; set; }
        public System.DateTime? LastSyncTime { get; set; }
        public string QueueServer { get; set; }

        public MSsubscriptionAgent()
        {
            UpdateMode = 0;
            FailoverMode = false;
            AllowSubscriptionCopy = false;
            AttachState = 0;
        }
    }

}
