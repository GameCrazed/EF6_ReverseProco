

namespace Generator
{

    public class SignOff
    {
        public int SignOffId { get; set; }
        public string Name { get; set; }

        public virtual System.Collections.Generic.ICollection<PackVersionSignOff> PackVersionSignOffs { get; set; }

        public SignOff()
        {
            PackVersionSignOffs = new System.Collections.Generic.List<PackVersionSignOff>();
        }
    }

}
