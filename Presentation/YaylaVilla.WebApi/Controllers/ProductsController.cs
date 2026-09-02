using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.CreateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.DeleteCommands;
using YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.UpdateCommands;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetProductSpecialOfferListQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.GetQueries;
using YaylaVilla.Application.Features.CQRSPattern.Queries.ProductQueries.ListQueries;

namespace YaylaVilla.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList([FromQuery] ResultProductListQueryRequest request)
        {
            List<ResultProductListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommandRequest request)
        {
            CreateProductCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] GetProductQueryRepuest repuest)
        {
            GetProductQueryResponse response = await _mediator.Send(repuest);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] DeleteProductCommandRequest request)
        {
            DeleteProductCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductCommandRequest request)
        {
            UpdateProductCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetProductSpecialOfferList")]
        public async Task<IActionResult> GetProductSpecialOfferList([FromQuery] GetProductSpecialOfferListQueryRequest request)
        {
            List<GetProductSpecialOfferListQueryResponse> response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
