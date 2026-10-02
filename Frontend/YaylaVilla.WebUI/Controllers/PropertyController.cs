using Microsoft.AspNetCore.Mvc;
using X.PagedList.Extensions;
using YaylaVilla.WebUI.Services.ProductServices;

namespace YaylaVilla.WebUI.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IProductService _productService;

        public PropertyController(IProductService productService)
        {
            _productService = productService;
        }

        //api tarafında product olarak kullanılmakta
        public async Task<IActionResult> Index(int page = 1, int size = 21)
        {
            var values = await _productService.ProductListAsync();            
            return View(values.ToPagedList(page, size));
        }
    }
}
