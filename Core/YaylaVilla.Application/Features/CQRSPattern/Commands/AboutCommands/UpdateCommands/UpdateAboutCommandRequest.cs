using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.UpdateCommands
{
    public class UpdateAboutCommandRequest : IRequest<UpdateAboutCommandResponse>
    {
        public int AboutID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}