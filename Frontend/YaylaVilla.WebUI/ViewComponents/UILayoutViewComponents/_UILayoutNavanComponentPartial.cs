using Microsoft.AspNetCore.Mvc;

namespace YaylaVilla.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutNavanComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
