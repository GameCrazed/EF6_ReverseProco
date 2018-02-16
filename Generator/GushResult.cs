

namespace Generator
{

    public class GushResult
    {
        public int GushId { get; set; }
        public decimal Value { get; set; }
        public string Comment { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }


        public virtual Gush Gush { get; set; }
    }

}
