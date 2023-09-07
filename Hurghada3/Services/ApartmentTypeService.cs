using Hurghada3.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Hurghada3.Services
{
    public class ApartmentTypeService:IApartmentTypeService
    {
        private readonly AppDbContext _context;
        public ApartmentTypeService(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<List<SelectListItem>> GetApartmentTypes()
        {
            return await _context.ApartmentTypes
                .Select(at => new SelectListItem
                {
                    Value = at.Id.ToString(),
                    Text = at.Name
                })
                .OrderBy(at => at.Text).AsNoTracking().ToListAsync();
        }
    }
}
