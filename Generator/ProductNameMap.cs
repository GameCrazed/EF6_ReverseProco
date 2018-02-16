

namespace Generator
{

    // The table 'productNameMap' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class ProductNameMap
    {
        public long? TableId { get; set; }
        public string Productcode { get; set; }
        public string Productname { get; set; }
        public string FriendlyName { get; set; }
    }

}
