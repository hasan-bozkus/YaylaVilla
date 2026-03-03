namespace YaylaVilla.Application.Features.CQRSPattern.Commands.TagCloudCommands.UpdateCommands
{
    public class UpdateTagCloudCommandResponse
    {
        public bool IsStatus { get; set; }
        public List<string> StatusMessage { get; set; }
    }
}