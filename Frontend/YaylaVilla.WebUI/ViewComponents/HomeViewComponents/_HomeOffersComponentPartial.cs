using Microsoft.AspNetCore.Mvc;
using YaylaVilla.WebUI.Services.ProductServices;

namespace YaylaVilla.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeOffersComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _HomeOffersComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetSpecialOfferListAsync();
            return View(values);
        }
    }
}
