

namespace Generator
{

    public class EaAddress
    {
        public int AddressId { get; set; }
        public string Organisation { get; set; }
        public string FlatNo { get; set; }
        public string BuildingNo { get; set; }
        public string HouseNumber { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public System.DateTime? FromDate { get; set; }
    }

}
