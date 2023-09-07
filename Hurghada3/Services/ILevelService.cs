using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hurghada3.Services
{
    public interface ILevelService
    {
        public Task<List<SelectListItem>> GetLevels();
    }
}
