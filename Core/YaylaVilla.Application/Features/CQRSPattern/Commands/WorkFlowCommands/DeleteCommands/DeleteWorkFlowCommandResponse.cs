namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.DeleteCommands
{
    public class DeleteWorkFlowCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}