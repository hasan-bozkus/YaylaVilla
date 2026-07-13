using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.TestimonialDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly HttpClient _httpClient;

        public TestimonialService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultTestimonialDto>> TestimonialListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("Referanslar Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateTestimonialDto>("", createTestimonialDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("Referans Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteTestimonialAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Referans Silinemedi");
        }

        public async Task<ResultGetTestimonialByIDDto> GetTestimonialAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetTestimonialByIDDto>();
                return values;
            }

            throw new NotImplementedException("Referans Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateTestimonialAsync(ResultGetTestimonialByIDDto resultGetTestimonialByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetTestimonialByIDDto>("", resultGetTestimonialByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Referans Güncellenemedi!");
        }
    }
}
