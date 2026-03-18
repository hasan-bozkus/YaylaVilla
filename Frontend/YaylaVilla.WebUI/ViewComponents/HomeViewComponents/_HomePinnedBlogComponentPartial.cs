using Microsoft.AspNetCore.Mvc;

namespace YaylaVilla.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomePinnedBlogComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
