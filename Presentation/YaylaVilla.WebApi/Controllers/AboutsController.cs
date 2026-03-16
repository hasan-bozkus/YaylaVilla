using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.AboutQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.AboutQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList([FromQuery] ResultAboutListQueryRequest request)
        {
            List<ResultAboutListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout([FromBody] CreateAboutCommandRequest request)
        {
            CreateAboutCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout([FromRoute] GetAboutQueryRepuest repuest)
        {
            GetAboutQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout([FromRoute] DeleteAboutCommandRequest request)
        {
            DeleteAboutCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout([FromBody] UpdateAboutCommandRequest request)
        {
            UpdateAboutCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
