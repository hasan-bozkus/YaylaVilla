using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ProductCommands.UpdateCommands
{
    public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}