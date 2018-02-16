

namespace Generator
{

    public class Gush
    {
        public int GushId { get; set; }
        public string Reason { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int GushThresholdId { get; set; }

        public virtual GushResult GushResult { get; set; }


        public virtual GushThreshold GushThreshold { get; set; }
    }

}
