using Microsoft.AspNetCore.Mvc;
using YaylaVilla.WebUI.Services.TestimonialServices;

namespace YaylaVilla.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeTestimonialComponentPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _HomeTestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.TestimonialListAsync();
            return View(values);
        }
    }
}
