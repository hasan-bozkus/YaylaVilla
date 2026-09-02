using Microsoft.AspNetCore.Mvc;
using YaylaVilla.WebUI.Services.WorkFlowServices;

namespace YaylaVilla.WebUI.ViewComponents.HomeViewComponents
{
    public class _HomeWorkFlowComponentPartial : ViewComponent
    {
        private readonly IWorkFlowService _workFlowService;

        public _HomeWorkFlowComponentPartial(IWorkFlowService workFlowService)
        {
            _workFlowService = workFlowService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _workFlowService.WorkFlowListAsync();

            return View(values);
        }
    }
}
