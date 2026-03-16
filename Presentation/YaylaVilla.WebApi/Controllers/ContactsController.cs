using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ContactCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ContactQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ContactList([FromQuery] ResultContactListQueryRequest request)
        {
            List<ResultContactListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact([FromBody] CreateContactCommandRequest request)
        {
            CreateContactCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact([FromRoute] GetContactQueryRepuest repuest)
        {
            GetContactQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact([FromRoute] DeleteContactCommandRequest request)
        {
            DeleteContactCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact([FromBody] UpdateContactCommandRequest request)
        {
            UpdateContactCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
