

namespace Generator
{

    public class Document
    {
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public byte[] BinaryData { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }

        public virtual System.Collections.Generic.ICollection<PackVersionDocument> PackVersionDocuments { get; set; }

        public Document()
        {
            PackVersionDocuments = new System.Collections.Generic.List<PackVersionDocument>();
        }
    }

}
