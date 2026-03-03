using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.CreateCommands
{
    public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}