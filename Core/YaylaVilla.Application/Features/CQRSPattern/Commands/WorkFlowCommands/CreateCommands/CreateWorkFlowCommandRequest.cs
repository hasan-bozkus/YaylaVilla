using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.CreateCommands
{
    public class CreateWorkFlowCommandRequest : IRequest<CreateWorkFlowCommandResponse>
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}