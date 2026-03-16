using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ServiceQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList([FromQuery] ResultServiceListQueryRequest request)
        {
            List<ResultServiceListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService([FromBody] CreateServiceCommandRequest request)
        {
            CreateServiceCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService([FromRoute] GetServiceQueryRepuest repuest)
        {
            GetServiceQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService([FromRoute] DeleteServiceCommandRequest request)
        {
            DeleteServiceCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService([FromBody] UpdateServiceCommandRequest request)
        {
            UpdateServiceCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
