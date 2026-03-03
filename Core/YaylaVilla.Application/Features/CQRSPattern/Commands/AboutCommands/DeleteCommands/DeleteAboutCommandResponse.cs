namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.DeleteCommands
{
    public class DeleteAboutCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}