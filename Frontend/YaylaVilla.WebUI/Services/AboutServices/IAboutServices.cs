using YaylaVilla.Dto.Dtos.AboutDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.AboutServices
{
    public interface IAboutServices
    {
        Task<List<ResultAboutDto>> AboutListAsync();
        Task<ResultServiceResponseViewModel> CreateAboutAsync(CreateAboutDto createAboutDto);
        Task<ResultServiceResponseViewModel> DeleteAboutAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateAboutAsync(ResultGetAboutByIDDto resultGetAboutByIDDto);
        Task<ResultGetAboutByIDDto> GetAboutAsync(int id);
    }
}