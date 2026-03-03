using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.UpdateCommands
{
    public class UpdateWorkFlowCommandRequest : IRequest<UpdateWorkFlowCommandResponse>
    {
        public int WorkFlowID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}