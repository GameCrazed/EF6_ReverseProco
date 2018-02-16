

namespace Generator
{

    public class PackVoid
    {
        public System.DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public int PackId { get; set; }
        public string Reason { get; set; }


        public virtual Pack Pack { get; set; }
    }

}
