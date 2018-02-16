

namespace Generator
{

    public class EaExistingloan
    {
        public int ExistingLoanId { get; set; }
        public int ApplicationId { get; set; }
        public int AddressId { get; set; }
        public string Lender { get; set; }
        public string Reference { get; set; }
        public double Payment { get; set; }
        public double Balance { get; set; }
        public string Priority { get; set; }
        public int Ordinal { get; set; }
    }

}
