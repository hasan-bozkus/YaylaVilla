using Microsoft.AspNetCore.Mvc;
using YaylaVilla.WebUI.Services.ServiceServices;

namespace YaylaVilla.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeServicesComponentPartial : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _HomeServicesComponentPartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _serviceService.ServiceListAsync();
            return View(values);
        }
    }
}
