using Microsoft.AspNetCore.Mvc;

namespace YaylaVilla.WebUI.Controllers
{
    public class PropertyController : Controller
    {
        //api tarafında product olarak kullanılmakta
        public IActionResult Index()
        {
            return View();
        }
    }
}
