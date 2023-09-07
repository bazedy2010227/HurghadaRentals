
namespace Hurghada3.Models
{
    public class Apartment
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        
        public int DownPayment { get; set; }
        public int MonthlyPayment { get; set; }
        public int DailyPayment { get; set; }
        public int BedRooms { get; set; }
        public int PathRooms { get; set; }
        public int Area { get; set; }
        public Guid LevelId { get; set; }
        public Level Level { get; set; } = default!;
        public string ImageUrl { get; set; } = string.Empty;
        public Guid ApartmentTypeId { get; set; }
        public ApartmentType ApartmentType { get; set; } = default!;
        public List<ApartmentAmenity> ApartmentAmenities { get; set; } = new List<ApartmentAmenity>();
        public bool IsFurnished { get; set; }
        public bool IsAvailable { get; set; }
    }
}
