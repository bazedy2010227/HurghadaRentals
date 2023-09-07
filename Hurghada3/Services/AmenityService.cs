using Hurghada3.Data;
using Hurghada3.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Hurghada3.Services
{
    public class AmenityService : IAmenityService
    {
        private readonly AppDbContext _context;
        public AmenityService(AppDbContext context)
        { 
            _context = context;
        }
        public async Task<List<SelectListItem>> GetAmenitites()
        {
            return await _context.Amenities
                .Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Description
                })
                .OrderBy(a=>a.Text).AsNoTracking().ToListAsync();
        }

        public List<Amenity> GetTestAmenities()
        {
            return _context.Amenities.ToList();
        }

    }
}
