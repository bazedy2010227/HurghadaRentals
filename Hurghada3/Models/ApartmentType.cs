namespace Hurghada3.Models
{
    
    public class ApartmentType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Apartment> Apartments { get; set; } = new List<Apartment>();
    }
}
