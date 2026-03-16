using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.CategoryCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.CategoryQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList([FromQuery]ResultCategoryListQueryRequest request)
        {
            List<ResultCategoryListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody]CreateCategoryCommandRequest request)
        {
            CreateCategoryCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory([FromRoute]GetCategoryQueryRepuest repuest)
        {
            GetCategoryQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute]DeleteCategoryCommandRequest request)
        {
            DeleteCategoryCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody]UpdateCategoryCommandRequest request)
        {
            UpdateCategoryCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
