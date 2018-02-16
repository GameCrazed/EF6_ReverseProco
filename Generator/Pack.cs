

namespace Generator
{

    public class Pack
    {
        public int PackId { get; set; }
        public string Description { get; set; }
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }

        public virtual PackVoid PackVoid { get; set; }
        public virtual System.Collections.Generic.ICollection<PackVersion> PackVersions { get; set; }

        public Pack()
        {
            PackVersions = new System.Collections.Generic.List<PackVersion>();
        }
    }

}
