using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.ServiceDtos;
using YaylaVilla.WebUI.Services.ServiceServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public AdminServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _serviceService.ServiceListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            createServiceDto.Status = false;
            await _serviceService.CreateServiceAsync(createServiceDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteService(int id)
        {
            var values = await _serviceService.DeleteServiceAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }



        [HttpGet]
        public async Task<IActionResult> UpdateService(int id)
        {
            var value = await _serviceService.GetServiceAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateService(ResultGetServiceByIDDto resultGetServiceByIDDto)
        {
            await _serviceService.UpdateServiceAsync(resultGetServiceByIDDto);
            return RedirectToAction("Index");
        }
    }
}
