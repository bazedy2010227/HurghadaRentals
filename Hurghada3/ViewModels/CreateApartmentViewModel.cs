using Hurghada3.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Hurghada3.ViewModels
{
    public class CreateApartmentViewModel
    {

        [Display(Name = "Give your property a Title")]
        public string Title { get; set; } = string.Empty;
        [Display(Name = "Describe your property")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Where is your property located?")]
        public string Address { get; set; } = string.Empty;
       
        [Display(Name = "How much is the down payment?")]
        public int DownPayment { get; set; }
        [Display(Name = "How much is the monthly payment?")]
        public int MonthlyPayment { get; set; }
        [Display(Name = "How much is the daily payment?")]
        public int DailyPayment { get; set; }
        [Display(Name = "How many bedrooms does your property have?")]
        public int BedRooms { get; set; }
        [Display(Name = "How many bathrooms does your property have?")]
        public int PathRooms { get; set; }
        [Display(Name = "How much Area does your property is in m^2 ?")]
        public int Area { get; set; }
        [Display(Name = "What level is your property on?")]
        public List<SelectListItem> Levels { get; set; } = new List<SelectListItem>();
        public Guid LevelId { get; set; }

        [Display(Name = "What amenities does your property have?")]
        public List<SelectListItem> Amenities { get; set; } = new List<SelectListItem>();
        public List<Guid> SelectedAmenities { get; set; } = new List<Guid>();

        [Display(Name = "What type of property is it?")]
        public List<SelectListItem> ApartmentTypes { get; set; } = new List<SelectListItem>();
        public Guid ApartmentTypeId { get; set; }

        [Display(Name = "Upload an image for your property")]
        public IFormFile ImageUrl { get; set; } = default!;
        [Display(Name = "Is your property furnished?")]
        public bool IsFurnished { get; set; }
        [Display(Name = "Is your property available?")]
        public bool IsAvailable { get; set; }
    }
}
