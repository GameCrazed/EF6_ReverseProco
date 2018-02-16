

namespace Generator
{

    public class MSsnapshotdeliveryprogress
    {
        public string SessionToken { get; set; }
        public int ProgressTokenHash { get; set; }
        public string ProgressToken { get; set; }
        public System.DateTime? ProgressTimestamp { get; set; }

        public MSsnapshotdeliveryprogress()
        {
            ProgressTimestamp = System.DateTime.Now;
        }
    }

}
