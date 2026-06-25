using Newtonsoft.Json;
using YaylaVilla.Dto.Dtos.CommentDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.CommentServices
{
    public class CommentService : ICommentService
    {
        private readonly HttpClient _httpClient;

        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ResultCommentDto>> CommentListAsync()
        {
            var responseMessage = await _httpClient.GetAsync("");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);
                return values;
            }

            throw new NotImplementedException("Kategoriler Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> CreateCommentAsync(CreateCommentDto createCommentDto)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync<CreateCommentDto>("", createCommentDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }

            throw new NotImplementedException("Yorum Eklemedi!");
        }

        public async Task<ResultServiceResponseViewModel> DeleteCommentAsync(int id)
        {
            var responseMessage = await _httpClient.DeleteAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Yorum Silinemedi");
        }

        public async Task<ResultGetCommentByIDDto> GetCommentAsync(int id)
        {
            var responseMessage = await _httpClient.GetAsync($"{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var values = await responseMessage.Content.ReadFromJsonAsync<ResultGetCommentByIDDto>();
                return values;
            }

            throw new NotImplementedException("Yorum Getirilemedi!");
        }

        public async Task<ResultServiceResponseViewModel> UpdateCommentAsync(ResultGetCommentByIDDto resultGetCommentByIDDto)
        {
            var responseMessage = await _httpClient.PutAsJsonAsync<ResultGetCommentByIDDto>("", resultGetCommentByIDDto);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultServiceResponseViewModel>(jsonData);
                return values;
            }
            throw new NotImplementedException("Yorum Güncellenemedi!");
        }
    }
}
