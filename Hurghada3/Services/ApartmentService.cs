using Hurghada3.Data;
using Hurghada3.Models;
using Hurghada3.ViewModels;
using System.Runtime.CompilerServices;

namespace Hurghada3.Services
{
    public class ApartmentService : IApartmentService
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _ImagePath; 
        public ApartmentService(AppDbContext context,IWebHostEnvironment webHostEnvironment) 
        {

            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _ImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images/apartments");

        }
        public async Task CreateAsync(CreateApartmentViewModel model)
        {
           var ImageName = $"{Guid.NewGuid()}{Path.GetExtension(model.ImageUrl.FileName)}";
           var ImagePath = Path.Combine(_ImagePath, ImageName);
           using var stream = File.Create(ImagePath);
           await model.ImageUrl.CopyToAsync(stream);
           
            Apartment apartment = new ()
            {
                Title = model.Title,
                Description = model.Description,
                Address = model.Address,
                DownPayment = model.DownPayment,
                MonthlyPayment = model.MonthlyPayment,
                DailyPayment = model.DailyPayment,
                BedRooms = model.BedRooms,
                PathRooms = model.PathRooms,
                Area = model.Area,
                ImageUrl = ImageName,
                LevelId = model.LevelId,
                ApartmentTypeId = model.ApartmentTypeId,
                ApartmentAmenities = model.SelectedAmenities.Select(a => new ApartmentAmenity { AmenityId = a }).ToList(),
                IsAvailable = model.IsAvailable,
                IsFurnished = model.IsFurnished,
               
            };
            await _context.Apartments.AddAsync(apartment);
            await _context.SaveChangesAsync();
        }
    }
}
