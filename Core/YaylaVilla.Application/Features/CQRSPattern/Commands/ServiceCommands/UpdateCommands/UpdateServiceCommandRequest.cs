using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.UpdateCommands
{
    public class UpdateServiceCommandRequest : IRequest<UpdateServiceCommandResponse>
    {
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}