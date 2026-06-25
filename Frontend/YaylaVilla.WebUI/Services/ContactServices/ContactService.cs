using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.ContactDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly HttpClient _httpClient;

        public ContactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultContactDto>> ContactListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("İletişim Talepleri Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateContactAsync(CreateContactDto createContactDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateContactDto>("", createContactDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("İletişim Talebi Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteContactAsync(int id)
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

        public async Task<ResultGetContactByIDDto> GetContactAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetContactByIDDto>();
                return values;
            }

            throw new NotImplementedException("İletişim Talebi Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateContactAsync(ResultGetContactByIDDto resultGetContactByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetContactByIDDto>("", resultGetContactByIDDto);
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
