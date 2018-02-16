

namespace Generator
{

    public class EaStatus
    {
        public int StatusId { get; set; }
        public int ApplicationId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string StatusCode { get; set; }
        public string UserName { get; set; }
        public System.DateTime? DateModified { get; set; }
        public string IpAddress { get; set; }
    }

}
