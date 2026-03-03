namespace YaylaVilla.Application.Features.CQRSPattern.Commands.AboutCommands.CreateCommands
{
    public class CreateAboutCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}