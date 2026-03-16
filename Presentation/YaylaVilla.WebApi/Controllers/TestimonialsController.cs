using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.TestimonialCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.TestimonialQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestimonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList([FromQuery] ResultTestimonialListQueryRequest request)
        {
            List<ResultTestimonialListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial([FromBody] CreateTestimonialCommandRequest request)
        {
            CreateTestimonialCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial([FromRoute] GetTestimonialQueryRepuest repuest)
        {
            GetTestimonialQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial([FromRoute] DeleteTestimonialCommandRequest request)
        {
            DeleteTestimonialCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial([FromBody] UpdateTestimonialCommandRequest request)
        {
            UpdateTestimonialCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
