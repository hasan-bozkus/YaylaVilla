using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.AddressDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.AddressServices
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;

        public AddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultAddressDto>> AddressListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAddressDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("Adres Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateAddressAsync(CreateAddressDto createAddressDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateAddressDto>("", createAddressDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("Adres Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteAddressAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Adres Silinemedi");
        }

        public async Task<ResultGetAddressByIDDto> GetAddressAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetAddressByIDDto>();
                return values;
            }

            throw new NotImplementedException("Adres Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateAddressAsync(ResultGetAddressByIDDto resultGetAddressByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetAddressByIDDto>("", resultGetAddressByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Adres Güncellenemedi!");
        }
    }
}
