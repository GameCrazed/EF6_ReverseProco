

namespace Generator
{

    public class PackVersionDocument
    {
        public int PackId { get; set; }
        public int VersionId { get; set; }
        public int DocumentId { get; set; }


        public virtual Document Document { get; set; }

        public virtual PackVersion PackVersion { get; set; }
    }

}
