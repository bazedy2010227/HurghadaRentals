using Hurghada3.Data;
using Hurghada3.Models;
using Hurghada3.Services;
using Hurghada3.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hurghada3.Controllers
{
    public class ApartmentsController : Controller
    {
        private readonly IApartmentService _apartmentService;
        private readonly IAmenityService _amenityService;
        private readonly IApartmentTypeService _apartmentTypeService;
        private readonly ILevelService _levelService;
        
        public ApartmentsController(IApartmentService apartmentService, IAmenityService amenityService, IApartmentTypeService apartmentTypeService, ILevelService levelService)
        {
            _apartmentService = apartmentService;
            _amenityService=amenityService;
            _apartmentTypeService=apartmentTypeService;
            _levelService=levelService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            try
            {
                var AmenitiesTask = await _amenityService.GetAmenitites();
                var ApartmentTypesTask = await _apartmentTypeService.GetApartmentTypes();
                var LevelsTask = await _levelService.GetLevels();
                var model = new CreateApartmentViewModel
                {
                    Amenities = AmenitiesTask,
                    ApartmentTypes = ApartmentTypesTask,
                    Levels = LevelsTask
                 };
                return View(model);
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { RequestId = ex.Message });
            }
            
                
            

        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateApartmentViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _apartmentService.CreateAsync(model);
                    return RedirectToAction(nameof(Index));
                }
                var AmenitiesTask = await _amenityService.GetAmenitites();
                var ApartmentTypesTask = await _apartmentTypeService.GetApartmentTypes();
                var LevelsTask = await _levelService.GetLevels();
                model.Amenities = AmenitiesTask;
                model.ApartmentTypes = ApartmentTypesTask;
                model.Levels = LevelsTask;
                return View(model);
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { RequestId = ex.Message });
            }
           
        }

    }
}
