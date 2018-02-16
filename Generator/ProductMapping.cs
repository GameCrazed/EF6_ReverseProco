

namespace Generator
{

    public class ProductMapping
    {
        public int SourceAccountNumber { get; set; }
        public int? PhoebusProductNumber { get; set; }
        public string PhoebusProductDescription { get; set; }
        public string ContractInterestType { get; set; }
        public string AccrualHistoryInterestType { get; set; }
        public string InstalmentsInAdvance { get; set; }
        public decimal? ContractMargin { get; set; }
    }

}
