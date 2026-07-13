using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.TestimonialDtos;
using YaylaVilla.WebUI.Services.TestimonialServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminTestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public AdminTestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _testimonialService.TestimonialListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {

            createTestimonialDto.Status = "deneme";
            await _testimonialService.CreateTestimonialAsync(createTestimonialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            var values = await _testimonialService.DeleteTestimonialAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var value = await _testimonialService.GetTestimonialAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(ResultGetTestimonialByIDDto resultGetTestimonialByIDDto)
        {
            await _testimonialService.UpdateTestimonialAsync(resultGetTestimonialByIDDto);
            return RedirectToAction("Index");
        }
    }
}
