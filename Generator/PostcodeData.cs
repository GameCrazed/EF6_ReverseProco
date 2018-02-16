

namespace Generator
{

    public class PostcodeData
    {
        public int Id { get; set; }
        public string PartialPostcode { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Region { get; set; }
        public System.Data.Entity.Spatial.DbGeography GeoLocation { get; set; }
        public string StartPostcode { get; set; }
    }

}
