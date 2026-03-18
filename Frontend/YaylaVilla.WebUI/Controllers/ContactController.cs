using Microsoft.AspNetCore.Mvc;

namespace YaylaVilla.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
