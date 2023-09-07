using System.ComponentModel.DataAnnotations.Schema;

namespace Hurghada3.Models
{
    public class ApartmentAmenity
    {

        public Guid ApartmentId { get; set; }
        public Apartment Apartment { get; set; } = default!;
        public Guid AmenityId { get; set; }
        public Amenity Amenity { get; set; } = default!;
    }
}
