using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.TagCloudDtos;
using YaylaVilla.WebUI.Services.TagCloudServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminTagCloudController : Controller
    {
        private readonly ITagCloudService _tagCloudService;

        public AdminTagCloudController(ITagCloudService tagCloudService)
        {
            _tagCloudService = tagCloudService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _tagCloudService.TagCloudListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTagCloud()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudDto createTagCloudDto)
        {
            await _tagCloudService.CreateTagCloudAsync(createTagCloudDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTagCloud(int id)
        {
            var values = await _tagCloudService.DeleteTagCloudAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTagCloud(int id)
        {
            var value = await _tagCloudService.GetTagCloudAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTagCloud(ResultGetTagCloudByIDDto resultGetTagCloudByIDDto)
        {
            await _tagCloudService.UpdateTagCloudAsync(resultGetTagCloudByIDDto);
            return RedirectToAction("Index");
        }
    }
}
