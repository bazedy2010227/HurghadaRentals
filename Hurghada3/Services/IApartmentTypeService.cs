using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hurghada3.Services
{
    public interface IApartmentTypeService
    {
        public Task<List<SelectListItem>> GetApartmentTypes();
    }
}
