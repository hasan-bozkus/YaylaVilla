using YaylaVilla.Dto.Dtos.ServiceDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.ServiceServices
{
    public interface IServiceService
    {
        Task<List<ResultServiceDto>> ServiceListAsync();
        Task<ResultServiceResponseViewModel> CreateServiceAsync(CreateServiceDto createServiceDto);
        Task<ResultServiceResponseViewModel> DeleteServiceAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateServiceAsync(ResultGetServiceByIDDto resultGetServiceByIDDto);
        Task<ResultGetServiceByIDDto> GetServiceAsync(int id);
    }
}