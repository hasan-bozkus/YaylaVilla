using YaylaVilla.Dto.Dtos.BlogDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.BlogServices
{
    public interface IBlogService
    {
        Task<List<ResultBlogDto>> BlogListAsync();
        Task<ResultServiceResponseViewModel> CreateBlogAsync(CreateBlogDto createBlogDto);
        Task<ResultServiceResponseViewModel> DeleteBlogAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateBlogAsync(ResultGetBlogByIDDto resultGetBlogByIDDto);
        Task<ResultGetBlogByIDDto> GetBlogAsync(int id);
        Task<List<ResultGetLast4BlogListDto>> GetLast4BlogListAsync();

    }
}