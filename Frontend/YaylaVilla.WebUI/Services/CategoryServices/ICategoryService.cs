using YaylaVilla.Dto.Dtos.CategoryDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDto>> CategoryListAsync();
        Task<ResultServiceResponseViewModel> CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task<ResultServiceResponseViewModel> DeleteCategoryAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateCategoryAsync(ResultGetCategoryByIDDto resultGetCategoryByIDDto);
        Task<ResultGetCategoryByIDDto> GetCategoryAsync(int id);
    }
}