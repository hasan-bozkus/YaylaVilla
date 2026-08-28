using Microsoft.AspNetCore.Mvc;
using YaylaVilla.WebUI.Services.BlogServices;

namespace YaylaVilla.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomePinnedBlogComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _HomePinnedBlogComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _blogService.GetLast4BlogListAsync();

            return View(values);
        }
    }
}
