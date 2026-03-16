using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.WorkFlowQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.WorkFlowQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkFlowsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkFlowsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> WorkFlowList([FromQuery] ResultWorkFlowListQueryRequest request)
        {
            List<ResultWorkFlowListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWorkFlow([FromBody] CreateWorkFlowCommandRequest request)
        {
            CreateWorkFlowCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkFlow([FromRoute] GetWorkFlowQueryRepuest repuest)
        {
            GetWorkFlowQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkFlow([FromRoute] DeleteWorkFlowCommandRequest request)
        {
            DeleteWorkFlowCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWorkFlow([FromBody] UpdateWorkFlowCommandRequest request)
        {
            UpdateWorkFlowCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
