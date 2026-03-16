using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CommentCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.CommentQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CommentList([FromQuery] ResultCommentListQueryRequest request)
        {
            List<ResultCommentListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment([FromBody] CreateCommentCommandRequest request)
        {
            CreateCommentCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment([FromRoute] GetCommentQueryRepuest repuest)
        {
            GetCommentQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment([FromRoute] DeleteCommentCommandRequest request)
        {
            DeleteCommentCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment([FromBody] UpdateCommentCommandRequest request)
        {
            UpdateCommentCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
