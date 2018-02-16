

namespace Generator
{

    public class EaExpenditure
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }
        public string Lender { get; set; }
        public byte Less6Months { get; set; }
        public int Ordinal { get; set; }
    }

}
