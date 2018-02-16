

namespace Generator
{

    public class GushThreshold
    {
        public int GushThresholdId { get; set; }
        public decimal Value { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Gush> Gushes { get; set; }

        public GushThreshold()
        {
            Gushes = new System.Collections.Generic.List<Gush>();
        }
    }

}
