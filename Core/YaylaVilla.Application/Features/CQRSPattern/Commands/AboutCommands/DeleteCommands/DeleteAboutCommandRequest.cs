using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.DeleteCommands
{
    public class DeleteAboutCommandRequest : IRequest<DeleteAboutCommandResponse>
    {
        public int id { get; set; }
    }
}