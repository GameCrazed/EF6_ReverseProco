

namespace Generator
{

    public class EaMessageholder
    {
        public int MessageHolderId { get; set; }
        public string Code { get; set; }
        public System.DateTime FromDate { get; set; }
        public string Descrption { get; set; }
        public byte[] Data { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string FkMessageTypeRef { get; set; }
    }

}
