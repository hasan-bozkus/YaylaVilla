using Microsoft.AspNetCore.Mvc;

namespace YaylaVilla.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
