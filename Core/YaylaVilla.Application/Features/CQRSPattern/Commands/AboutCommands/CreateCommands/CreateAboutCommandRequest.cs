using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.CreateCommands
{
    public class CreateAboutCommandRequest : IRequest<CreateAboutCommandResponse>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}