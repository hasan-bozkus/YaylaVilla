using Microsoft.AspNetCore.Mvc;

namespace YaylaVilla.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeServicesComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
