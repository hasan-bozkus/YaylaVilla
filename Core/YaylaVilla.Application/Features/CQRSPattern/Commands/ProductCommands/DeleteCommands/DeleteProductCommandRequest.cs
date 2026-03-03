using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.DeleteCommands
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public int id { get; set; }
    }
}