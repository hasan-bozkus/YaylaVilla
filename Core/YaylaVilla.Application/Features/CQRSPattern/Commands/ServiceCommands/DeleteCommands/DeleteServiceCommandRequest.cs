using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.DeleteCommands
{
    public class DeleteServiceCommandRequest : IRequest<DeleteServiceCommandResponse>
    {
        public int id { get; set; }
    }
}