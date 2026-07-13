using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.ServiceDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.ServiceServices
{
    public class ServiceService : IServiceService
    {
        private readonly HttpClient _httpClient;

        public ServiceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultServiceDto>> ServiceListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("İletişim Talepleri Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateServiceAsync(CreateServiceDto createServiceDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateServiceDto>("", createServiceDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("İletişim Talebi Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteServiceAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("İletişim Talebi Silinemedi");
        }

        public async Task<ResultGetServiceByIDDto> GetServiceAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetServiceByIDDto>();
                return values;
            }

            throw new NotImplementedException("İletişim Talebi Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateServiceAsync(ResultGetServiceByIDDto resultGetServiceByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetServiceByIDDto>("", resultGetServiceByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("İletişim Talebi Güncellenemedi!");
        }
    }
}
