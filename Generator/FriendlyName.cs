

namespace Generator
{

    public class FriendlyName
    {
        public int FriendlyNameId { get; set; }
        public string FriendlyNameText { get; set; }

        public virtual System.Collections.Generic.ICollection<ProductNameMapping> ProductNameMappings { get; set; }

        public FriendlyName()
        {
            ProductNameMappings = new System.Collections.Generic.List<ProductNameMapping>();
        }
    }

}
