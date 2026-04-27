using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.CategoryDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultCategoryDto>> CategoryListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("Kategoriler Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateCategoryDto>("", createCategoryDto);
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("Kategori Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteCategoryAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Kategori Silinemedi");
        }

        public async Task<ResultGetCategoryByIDDto> GetCategoryAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetCategoryByIDDto>();
                return values;
            }

            throw new NotImplementedException("Kategori Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateCategoryAsync(ResultGetCategoryByIDDto resultGetCategoryByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetCategoryByIDDto>("", resultGetCategoryByIDDto);
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Kategori Güncellenemedi!");
        }
    }
}
