

namespace Generator
{

    public class EaEsignature
    {
        public int ESignatureId { get; set; }
        public int ApplicationId { get; set; }
        public string PinNumber { get; set; }
        public string HashCode { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime? DateModified { get; set; }
    }

}
