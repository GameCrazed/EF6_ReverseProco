

namespace Generator
{

    public class ProductNameMapping
    {
        public string ProductCode { get; set; }
        public int FriendlyNameId { get; set; }
        public string ProductName { get; set; }


        public virtual FriendlyName FriendlyName { get; set; }
    }

}
