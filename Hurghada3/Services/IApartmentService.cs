using Hurghada3.Models;
using Hurghada3.ViewModels;

namespace Hurghada3.Services
{
    public interface IApartmentService
    {
        public Task CreateAsync (CreateApartmentViewModel model);
    }
}
