using YaylaVilla.Dto.Dtos.TestimonialDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> TestimonialListAsync();
        Task<ResultServiceResponseViewModel> CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto);
        Task<ResultServiceResponseViewModel> DeleteTestimonialAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateTestimonialAsync(ResultGetTestimonialByIDDto resultGetTestimonialByIDDto);
        Task<ResultGetTestimonialByIDDto> GetTestimonialAsync(int id);
    }
}