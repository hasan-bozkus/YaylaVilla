using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.ServiceCommands.CreateCommands
{
    public class CreateServiceCommandRequest : IRequest<CreateServiceCommandResponse>
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}