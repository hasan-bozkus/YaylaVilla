using YaylaVilla.Dto.Dtos.TagCloudDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.TagCloudServices
{
    public interface ITagCloudService
    {
        Task<List<ResultTagCloudDto>> TagCloudListAsync();
        Task<ResultServiceResponseViewModel> CreateTagCloudAsync(CreateTagCloudDto createTagCloudDto);
        Task<ResultServiceResponseViewModel> DeleteTagCloudAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateTagCloudAsync(ResultGetTagCloudByIDDto resultGetTagCloudByIDDto);
        Task<ResultGetTagCloudByIDDto> GetTagCloudAsync(int id);
    }
}