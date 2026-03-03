namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.UpdateCommands
{
    public class UpdateWorkFlowCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}