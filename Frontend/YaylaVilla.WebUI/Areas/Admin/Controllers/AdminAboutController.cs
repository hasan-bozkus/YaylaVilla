using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.AboutDtos;
using YaylaVilla.WebUI.Services.AboutServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminAboutController : Controller
    {
        private readonly IAboutServices _aboutService;

        public AdminAboutController(IAboutServices aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _aboutService.AboutListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            await _aboutService.CreateAboutAsync(createAboutDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAbout(int id)
        {
            var values = await _aboutService.DeleteAboutAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }



        [HttpGet]
        public async Task<IActionResult> UpdateAbout(int id)
        {
            var value = await _aboutService.GetAboutAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(ResultGetAboutByIDDto resultGetAboutByIDDto)
        {
            await _aboutService.UpdateAboutAsync(resultGetAboutByIDDto);
            return RedirectToAction("Index");
        }
    }
}
