namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.CreateCommands
{
    public class CreateTagCloudCommandResponse
    {
        public bool IsStatus { get; set; } 
        public List<string> StatusMessage { get; set; }
    }
}