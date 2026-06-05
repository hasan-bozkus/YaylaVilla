using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using YaylaVilla.Dto.Dtos.CategoryDtos;
using YaylaVilla.WebUI.Services.CategoryServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public AdminCategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _categoryService.CategoryListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            var values = await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCategory(int id)
        {
            var value = await _categoryService.GetCategoryAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCategory(ResultGetCategoryByIDDto resultGetCategoryByIDDto)
        {
            await _categoryService.UpdateCategoryAsync(resultGetCategoryByIDDto);
            return RedirectToAction("Index");
        }
    }
}
