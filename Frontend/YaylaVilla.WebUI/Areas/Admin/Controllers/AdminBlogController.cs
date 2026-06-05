using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.BlogDtos;
using YaylaVilla.WebUI.Services.BlogServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        private readonly IBlogService _blogService;

        public AdminBlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _blogService.BlogListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
        {
            createBlogDto.CreatedDate = DateTime.UtcNow;
            await _blogService.CreateBlogAsync(createBlogDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            var values = await _blogService.DeleteBlogAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int id)
        {
            var value = await _blogService.GetBlogAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlog(ResultGetBlogByIDDto resultGetBlogByIDDto)
        {
            if(resultGetBlogByIDDto.CreatedDate.Kind == DateTimeKind.Unspecified)
            {
                resultGetBlogByIDDto.CreatedDate = DateTime.SpecifyKind(resultGetBlogByIDDto.CreatedDate, DateTimeKind.Utc);
            }
            await _blogService.UpdateBlogAsync(resultGetBlogByIDDto);
            return RedirectToAction("Index");
        }
    }
}
