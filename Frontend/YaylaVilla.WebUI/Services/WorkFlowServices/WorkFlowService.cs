using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.WorkFlowDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.WorkFlowServices
{
    public class WorkFlowService : IWorkFlowService
    {
        private readonly HttpClient _httpClient;

        public WorkFlowService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultWorkFlowDto>> WorkFlowListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWorkFlowDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("İş Akışı Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateWorkFlowAsync(CreateWorkFlowDto createWorkFlowDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateWorkFlowDto>("", createWorkFlowDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("İş Akışı Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteWorkFlowAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("İş Akışı Silinemedi");
        }

        public async Task<ResultGetWorkFlowByIDDto> GetWorkFlowAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetWorkFlowByIDDto>();
                return values;
            }

            throw new NotImplementedException("İş Akışı Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateWorkFlowAsync(ResultGetWorkFlowByIDDto resultGetWorkFlowByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetWorkFlowByIDDto>("", resultGetWorkFlowByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("İş Akışı Güncellenemedi!");
        }
    }
}
