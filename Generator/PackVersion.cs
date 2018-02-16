

namespace Generator
{

    public class PackVersion
    {
        public int PackId { get; set; }
        public int VersionId { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }

        public virtual System.Collections.Generic.ICollection<PackVersionDocument> PackVersionDocuments { get; set; }
        public virtual System.Collections.Generic.ICollection<PackVersionSignOff> PackVersionSignOffs { get; set; }


        public virtual Pack Pack { get; set; }

        public PackVersion()
        {
            PackVersionDocuments = new System.Collections.Generic.List<PackVersionDocument>();
            PackVersionSignOffs = new System.Collections.Generic.List<PackVersionSignOff>();
        }
    }

}
