using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.AddressCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.AddressQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AddressList([FromQuery] ResultAddressListQueryRequest request)
        {
            List<ResultAddressListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress([FromBody] CreateAddressCommandRequest request)
        {
            CreateAddressCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddress([FromRoute] GetAddressQueryRepuest repuest)
        {
            GetAddressQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress([FromRoute] DeleteAddressCommandRequest request)
        {
            DeleteAddressCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAddress([FromBody] UpdateAddressCommandRequest request)
        {
            UpdateAddressCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
