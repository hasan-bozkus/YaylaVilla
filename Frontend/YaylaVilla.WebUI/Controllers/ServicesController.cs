using Microsoft.AspNetCore.Mvc;

namespace YaylaVilla.WebUI.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
