using YaylaVilla.Dto.Dtos.ProductDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> ProductListAsync();
        Task<ResultServiceResponseViewModel> CreateProductAsync(CreateProductDto createProductDto);
        Task<ResultServiceResponseViewModel> DeleteProductAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateProductAsync(ResultGetProductByIDDto resultGetProductByIDDto);
        Task<ResultGetProductByIDDto> GetProductAsync(int id);
    }
}