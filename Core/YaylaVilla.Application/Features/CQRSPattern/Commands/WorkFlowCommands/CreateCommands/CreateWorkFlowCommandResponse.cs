namespace YaylaVilla.Application.Features.CQRSPattern.Commands.WorkFlowCommands.CreateCommands
{
    public class CreateWorkFlowCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}