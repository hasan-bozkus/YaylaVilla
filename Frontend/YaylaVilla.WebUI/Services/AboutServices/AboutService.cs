using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.AboutDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.AboutServices
{
    public class AboutService : IAboutServices
    {
        private readonly HttpClient _httpClient;

        public AboutService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultAboutDto>> AboutListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("Hakkımda Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateAboutAsync(CreateAboutDto createAboutDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateAboutDto>("", createAboutDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("Hakkımda Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteAboutAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            throw new NotImplementedException();
        }

        public async Task<ResultGetAboutByIDDto> GetAboutAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetAboutByIDDto>();
                return values;
            }

            throw new NotImplementedException("Hakkımda Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateAboutAsync(ResultGetAboutByIDDto resultGetAboutByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetAboutByIDDto>("", resultGetAboutByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Hakkımda Güncellenemedi!");
        }
    }
}
