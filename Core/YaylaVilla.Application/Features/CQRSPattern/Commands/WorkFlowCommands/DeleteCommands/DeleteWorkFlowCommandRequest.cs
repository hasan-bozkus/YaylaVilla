using MediatR;

namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.DeleteCommands
{
    public class DeleteWorkFlowCommandRequest : IRequest<DeleteWorkFlowCommandResponse>
    {
        public int id { get; set; }
    }
}