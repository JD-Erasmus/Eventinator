namespace Eventinator.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
