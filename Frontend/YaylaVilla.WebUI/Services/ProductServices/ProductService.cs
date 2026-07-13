using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.ProductDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultProductDto>> ProductListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("İlanlar Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateProductAsync(CreateProductDto createProductDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateProductDto>("", createProductDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("İlan Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteProductAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("İlan Silinemedi");
        }

        public async Task<ResultGetProductByIDDto> GetProductAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetProductByIDDto>();
                return values;
            }

            throw new NotImplementedException("İlan Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateProductAsync(ResultGetProductByIDDto resultGetProductByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetProductByIDDto>("", resultGetProductByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("İlan Güncellenemedi!");
        }
    }
}
