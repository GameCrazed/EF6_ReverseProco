

namespace Generator
{

    public class EaCredithistoryiva
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public double? CurrentBalance { get; set; }
        public double? MonthlyAmount { get; set; }
        public System.DateTime? DateIncepted { get; set; }
        public string Status { get; set; }
        public System.DateTime? DateCleared { get; set; }
    }

}
