using Hurghada3.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hurghada3.Services
{
    public interface IAmenityService
    {
        public Task<List<SelectListItem>> GetAmenitites();
        
    }
}
