using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.BlogDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.BlogServices
{
    public class BlogService : IBlogService
    {
        private readonly HttpClient _httpClient;

        public BlogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultBlogDto>> BlogListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("Blog Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateBlogAsync(CreateBlogDto createBlogDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateBlogDto>("", createBlogDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("Blog Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteBlogAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Blog Silinemedi");
        }

        public async Task<ResultGetBlogByIDDto> GetBlogAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetBlogByIDDto>();
                return values;
            }

            throw new NotImplementedException("Blog Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateBlogAsync(ResultGetBlogByIDDto resultGetBlogByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetBlogByIDDto>("", resultGetBlogByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Blog Güncellenemedi!");
        }
    }
}
