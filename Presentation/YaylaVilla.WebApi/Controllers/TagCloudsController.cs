using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.TagCloudQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.TagCloudQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagCloudsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagCloudList([FromQuery] ResultTagCloudListQueryRequest request)
        {
            List<ResultTagCloudListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTagCloud([FromBody] CreateTagCloudCommandRequest request)
        {
            CreateTagCloudCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloud([FromRoute] GetTagCloudQueryRepuest repuest)
        {
            GetTagCloudQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTagCloud([FromRoute] DeleteTagCloudCommandRequest request)
        {
            DeleteTagCloudCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud([FromBody] UpdateTagCloudCommandRequest request)
        {
            UpdateTagCloudCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
