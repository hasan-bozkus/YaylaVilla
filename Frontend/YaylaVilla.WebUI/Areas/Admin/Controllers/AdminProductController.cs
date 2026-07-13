using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.ProductDtos;
using YaylaVilla.WebUI.Services.ProductServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminProductController : Controller
    {
        private readonly IProductService _productService;

        public AdminProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _productService.ProductListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            createProductDto.CreatedDate = DateTime.UtcNow;
            await _productService.CreateProductAsync(createProductDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var values = await _productService.DeleteProductAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var value = await _productService.GetProductAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ResultGetProductByIDDto resultGetProductByIDDto)
        {
            if (resultGetProductByIDDto.CreatedDate.Kind == DateTimeKind.Unspecified)
            {
                resultGetProductByIDDto.CreatedDate = DateTime.SpecifyKind(resultGetProductByIDDto.CreatedDate, DateTimeKind.Utc);
            }
            await _productService.UpdateProductAsync(resultGetProductByIDDto);
            return RedirectToAction("Index");
        }
    }
}
