

namespace Generator
{

    public class PackVersionSignOff
    {
        public int PackId { get; set; }
        public int VersionId { get; set; }
        public int SignOffId { get; set; }


        public virtual PackVersion PackVersion { get; set; }

        public virtual SignOff SignOff { get; set; }
    }

}
