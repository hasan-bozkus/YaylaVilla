using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.CreateCommands
{
    public class CreateServiceCommandRequest : IRequest<CreateServiceCommandResponse>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}