

namespace Generator
{

    public class Reportoffercommissionindividual
    {
        public int AccountNumber { get; set; }
        public System.DateTime OfferDate { get; set; }
        public System.DateTime? DateOfFirstOffer { get; set; }
        public string Surname { get; set; }
        public string Postcode { get; set; }
        public decimal LoanAmount { get; set; }
        public decimal Commission { get; set; }
        public decimal? Commission37 { get; set; }
        public string BrokerIndividualName { get; set; }
        public string BrokerFirm { get; set; }
    }

}
