using Microsoft.AspNetCore.Mvc;
using X.PagedList.Extensions;
using YaylaVilla.WebUI.Services.BlogServices;

namespace YaylaVilla.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IActionResult> Index(int page = 1, int size = 8)
        {
            var values = await _blogService.BlogListAsync();
            return View(values.ToPagedList(page, size));
        }
    }
}
