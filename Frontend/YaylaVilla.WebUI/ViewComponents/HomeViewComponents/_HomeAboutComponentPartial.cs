using Microsoft.AspNetCore.Mvc;
using YaylaVilla.WebUI.Services.AboutServices;

namespace YaylaVilla.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeAboutComponentPartial : ViewComponent
    {
        private readonly IAboutServices _aboutServices;

        public _HomeAboutComponentPartial(IAboutServices aboutServices)
        {
            _aboutServices = aboutServices;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var about = await _aboutServices.AboutListAsync();
            var values = about.Take(1).ToList();

            return View(values);
        }
    }
}
