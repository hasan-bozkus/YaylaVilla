using YaylaVilla.Dto.Dtos.WorkFlowDtos;
using YaylaVilla.Dto.Dtos.ServiceDtos;
using YaylaVilla.WebUI.Models;

namespace YaylaVilla.WebUI.Services.WorkFlowServices
{
    public interface IWorkFlowService
    {
        Task<List<ResultWorkFlowDto>> WorkFlowListAsync();
        Task<ResultServiceResponseViewModel> CreateWorkFlowAsync(CreateWorkFlowDto createWorkFlowDto);
        Task<ResultServiceResponseViewModel> DeleteWorkFlowAsync(int id);
        Task<ResultServiceResponseViewModel> UpdateWorkFlowAsync(ResultGetWorkFlowByIDDto resultGetWorkFlowByIDDto);
        Task<ResultGetWorkFlowByIDDto> GetWorkFlowAsync(int id);
    }
}
