using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.TagCloudDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.TagCloudServices
{
    public class TagCloudService : ITagCloudService
    {
        private readonly HttpClient _httpClient;

        public TagCloudService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultTagCloudDto>> TagCloudListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTagCloudDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("Etiketler Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateTagCloudAsync(CreateTagCloudDto createTagCloudDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateTagCloudDto>("", createTagCloudDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("Etiket Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteTagCloudAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Etiket Silinemedi");
        }

        public async Task<ResultGetTagCloudByIDDto> GetTagCloudAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetTagCloudByIDDto>();
                return values;
            }

            throw new NotImplementedException("Etiket Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateTagCloudAsync(ResultGetTagCloudByIDDto resultGetTagCloudByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetTagCloudByIDDto>("", resultGetTagCloudByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Etiket Güncellenemedi!");
        }
    }
}
