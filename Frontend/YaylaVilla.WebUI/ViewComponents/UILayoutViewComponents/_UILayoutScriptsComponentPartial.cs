using Microsoft.AspNetCore.Mvc;

namespace YaylaVilla.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
