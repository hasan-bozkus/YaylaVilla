using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.BlogCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.BlogQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList([FromQuery] ResultBlogListQueryRequest request)
        {
            List<ResultBlogListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog([FromBody] CreateBlogCommandRequest request)
        {
            CreateBlogCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog([FromRoute] GetBlogQueryRepuest repuest)
        {
            GetBlogQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog([FromRoute] DeleteBlogCommandRequest request)
        {
            DeleteBlogCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog([FromBody] UpdateBlogCommandRequest request)
        {
            UpdateBlogCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
