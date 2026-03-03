namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.UpdateCommands
{
    public class UpdateAboutCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}