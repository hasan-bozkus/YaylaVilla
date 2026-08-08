using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Dto.Dtos.WorkFlowDtos;
using YaylaVilla.WebUI.Services.WorkFlowServices;

namespace YaylaVilla.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminWorkFlowController : Controller
    {
        private readonly IWorkFlowService _workFlowService;

        public AdminWorkFlowController(IWorkFlowService workFlowService)
        {
            _workFlowService = workFlowService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _workFlowService.WorkFlowListAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateWorkFlow()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateWorkFlow(CreateWorkFlowDto createWorkFlowDto)
        {
            createWorkFlowDto.Status = false;
            await _workFlowService.CreateWorkFlowAsync(createWorkFlowDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteWorkFlow(int id)
        {
            var values = await _workFlowService.DeleteWorkFlowAsync(id);
            return RedirectToAction("Index", values.StatusMessage);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateWorkFlow(int id)
        {
            var value = await _workFlowService.GetWorkFlowAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWorkFlow(ResultGetWorkFlowByIDDto resultGetWorkFlowByIDDto)
        {
            await _workFlowService.UpdateWorkFlowAsync(resultGetWorkFlowByIDDto);
            return RedirectToAction("Index");
        }
    }
}
